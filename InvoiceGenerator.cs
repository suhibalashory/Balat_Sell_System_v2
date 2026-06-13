using System;
using System.IO;
using System.Linq;
using PDFtoImage;
using SkiaSharp;
using System.Drawing.Imaging;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Collections.Generic;
using System.Windows.Forms;
//using System.Drawing;

public class InvoiceGenerator
{
    public static string CreateArabicInvoice(string CoumpanyName = "CoumpanyName", string TotalSalary = "00.00",
        string ClientName = "", string ClientPhone = "", string UserName = "", string coumbanyLocation = "", string coumpanyPhone = "")
    {
        string haveGuid = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 8);

        if(!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fawater_pdf"))
        {
            Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fawater_pdf");
        }

        // مسار حفظ الفاتورة
        string invoicePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\Fawater_pdf",
            $"{haveGuid}_{ClientName}فاتورة_.pdf");

        // إنشاء مستند PDF
        Document document = new Document(PageSize.A4);

        try
        {
            // تهيئة كاتب PDF
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(invoicePath, FileMode.Create));

            // تحميل خط يدعم العربية (يجب التأكد من وجود الخط في المسار المحدد)
            string fontPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            BaseFont bf = BaseFont.CreateFont(fontPath, BaseFont.IDENTITY_H, BaseFont.EMBEDDED);
            Font titleFont = new Font(bf, 20, Font.BOLD, BaseColor.DARK_GRAY);
            Font headerFont = new Font(bf, 18, Font.BOLD, BaseColor.BLACK);
            Font normalFont = new Font(bf, 15, Font.NORMAL, BaseColor.BLACK);
            Font boldFont = new Font(bf, 14, Font.BOLD, BaseColor.BLACK);

            // فتح المستند
            document.Open();

            // تحديد اتجاه الكتابة من اليمين لليسار
            writer.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

            // عنوان الفاتورة
            PdfPTable title = ReturnTaple(1, 100);
            AddTitle(title, $"{CoumpanyName}\nفاتورة بيع", titleFont);
            document.Add(title);
            document.Add(new Paragraph(" "));


            // معلومات العميل
            PdfPTable clientTable = ReturnTaple(2, 100);
            clientTable.SetWidths(new float[] { 30, 70 });

            AddInfoCell(clientTable, "معلومات العميل", " ", titleFont, boldFont);
            AddInfoCell(clientTable, "اسم العميل:", ClientName, boldFont, normalFont);
            AddInfoCell(clientTable, "الهاتف:", ClientPhone, boldFont, normalFont);
            AddInfoCell(clientTable, "تاريخ الفاتورة :", DateTime.Now.ToString("yyyy/mm/dd"), boldFont, normalFont);
            AddInfoCell(clientTable, "رقم الفاتورة :", Guid.NewGuid().ToString().Replace("-", ""), boldFont, normalFont);


            document.Add(clientTable);
            document.Add(new Paragraph(" "));

            // تفاصيل الفاتورة
            PdfPTable itemsHeader = ReturnTaple(1, 100);
            AddTitle(itemsHeader, "الأصناف", headerFont);
            document.Add(itemsHeader);
            document.Add(new Paragraph(" "));

            PdfPTable itemsTable = ReturnTaple(5, 100);
            itemsTable.SetWidths(new float[] { 15, 20, 20, 20, 15 });

            // رأس جدول المشتريات
            AddItemHeaderCell(itemsTable, "نوع السلعة", headerFont);
            AddItemHeaderCell(itemsTable, "الكود", headerFont);
            AddItemHeaderCell(itemsTable, "الكمية بالصندوق", headerFont);
            AddItemHeaderCell(itemsTable, "سعر الصندوق", headerFont);
            AddItemHeaderCell(itemsTable, "المجموع", headerFont);

            // إضافة العناصر
            AddItemRow(itemsTable, "2", "حاسوب محمول - طراز X200", "2500 ر.س", "0 ر.س", "5000 ر.س", normalFont);
            AddItemRow(itemsTable, "1", "هاتف ذكي - طراز S10", "1800 ر.س", "100 ر.س", "1700 ر.س", normalFont);
            AddItemRow(itemsTable, "3", "سماعات لاسلكية", "200 ر.س", "30 ر.س", "510 ر.س", normalFont);

            document.Add(itemsTable);
            document.Add(new Paragraph(" "));

            // المجموع النهائي
            PdfPTable totalTable = new PdfPTable(2);
            totalTable.WidthPercentage = 70;
            totalTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;
            totalTable.HorizontalAlignment = Element.ALIGN_LEFT;


            AddTitle(totalTable, $" المجموع النهائي:  {TotalSalary} ", headerFont);
            AddTotalCell(totalTable, " ", " ", boldFont, boldFont);
            AddTotalCell(totalTable, $"اسم البائع: {UserName}", "", boldFont, normalFont);




            document.Add(totalTable);
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));
            document.Add(new Paragraph(" "));

            // تذييل الصفحة

            PdfPTable footer = ReturnTaple(1, 100);
            AddTitle(footer, $"العنوان: {coumbanyLocation} ", boldFont);
            AddTitle(footer, $"شكراً لتعاملكم معنا - للاستفسار اتصل على {coumpanyPhone}", normalFont);
            document.Add(footer);

            Console.WriteLine("تم إنشاء الفاتورة بنجاح: " + invoicePath);
        }
        catch (Exception ex)
        {
            Console.WriteLine("حدث خطأ: " + ex.Message);
        }
        finally
        {
            document.Close();
        }

        return invoicePath;
    }

    private static PdfPTable ReturnTaple(int numColumns, int _WidthPercentage)
    {
        PdfPTable clientTable = new PdfPTable(numColumns);
        clientTable.WidthPercentage = _WidthPercentage;
        clientTable.RunDirection = PdfWriter.RUN_DIRECTION_RTL;

        return clientTable;
    }
    private static void AddInfoCell(PdfPTable table, string label, string value, Font labelFont, Font valueFont)
    {
        PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
        labelCell.BorderWidth = 0;
        labelCell.Padding = 5;
        table.AddCell(labelCell);

        PdfPCell valueCell = new PdfPCell(new Phrase(value, valueFont));
        valueCell.BorderWidth = 0;
        valueCell.Padding = 5;
        table.AddCell(valueCell);
    }

    private static void AddItemHeaderCell(PdfPTable table, string text, Font font)
    {
        PdfPCell cell = new PdfPCell(new Phrase(text, font));
        cell.BackgroundColor = BaseColor.LIGHT_GRAY;
        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        cell.Padding = 8;
        table.AddCell(cell);
    }

    private static void AddTitle(PdfPTable title, string text, Font font)
    {
        PdfPCell cell = new PdfPCell(new Phrase(text, font));
        cell.HorizontalAlignment = Element.ALIGN_CENTER;
        cell.BorderWidth = 0;
        title.AddCell(cell);
    }

    private static void AddItemRow(PdfPTable table, string quantity, string product, string price, string discount, string total, Font font)
    {
        table.AddCell(new Phrase(quantity, font));
        table.AddCell(new Phrase(product, font));
        table.AddCell(new Phrase(price, font));
        table.AddCell(new Phrase(discount, font));
        table.AddCell(new Phrase(total, font));
    }

    private static void AddTotalCell(PdfPTable table, string label, string value, Font labelFont, Font valueFont)
    {
        PdfPCell labelCell = new PdfPCell(new Phrase(label, labelFont));
        labelCell.BorderWidth = 0;
        labelCell.Padding = 5;
        table.AddCell(labelCell);

        PdfPCell valueCell = new PdfPCell(new Phrase(value, valueFont));
        valueCell.BorderWidth = 0;
        valueCell.Padding = 5;
        valueCell.HorizontalAlignment = Element.ALIGN_LEFT;
        table.AddCell(valueCell);
    }


    public static List<byte[]> Convatr_Pdf_img(string inputPdfPath)
    {
        string outputImageDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        List<byte[]> imageBytesList = new List<byte[]>();

        if (!File.Exists(inputPdfPath))
        {
            Console.WriteLine($"Error: Input PDF file not found at {inputPdfPath}");
            return null;
        }

        if (!Directory.Exists(outputImageDirectory))
        {
            Directory.CreateDirectory(outputImageDirectory);
        }

        try
        {
            byte[] pdfBytes = File.ReadAllBytes(inputPdfPath);
            imageBytesList = ConvertPdfToImageBytes(pdfBytes);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Erorr in conveart img");
        }

        return imageBytesList;
    }

    public static List<byte[]> ConvertPdfToImageBytes(byte[] pdfBytes)
    {
        List<byte[]> imageBytesList = new List<byte[]>();
        var pages = Conversion.ToImages(pdfBytes);
        

        foreach (var skBitmap in pages)
        {
            using (var data = skBitmap.Encode(SKEncodedImageFormat.Png, 100))
            {
                imageBytesList.Add(data.ToArray());
            }
        }
        return imageBytesList;
    }


}