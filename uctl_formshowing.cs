using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahab_Balat.Controls
{
    public partial class uctl_formshowing : UserControl
    {
        public uctl_formshowing()
        {
            InitializeComponent();
        }

        private void pb_fatora_Click(object sender, EventArgs e)
        {

        }

        public void load_img(string path)
        {
            List<byte[]> imageBytesList =  InvoiceGenerator.Convatr_Pdf_img(path);

            foreach (byte[] imageBytes in imageBytesList)
            {
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    pb_fatora.Image = Image.FromStream(ms);
                }
            }
        }


    }
}
