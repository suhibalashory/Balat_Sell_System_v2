using System;
using System.Windows.Forms;
using Alkirat2.GlobalClass;
using BissnussLayer;
using Sahab_Balat;


namespace Alkirat2
{
    public partial class frm_Fatora: Form
    {
        public frm_Fatora()
        {
            InitializeComponent();
        }

        Mabiat _Mabiat;

        private void frm_Fatora_Load(object sender, EventArgs e)
        {
           _Mabiat = new Mabiat();
        }


        private void gbtn_Save_Click(object sender, EventArgs e)
        {
            Generat_Fatora(true);
        }

  
        private void Generat_Fatora(bool is_Loked )
        {
            int MabiatID = -1;

            _Mabiat.ClientName = tb_ClientName.Text;
            _Mabiat.ClientPhone = tb_ClientPhone.Text;
            _Mabiat.Date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            _Mabiat.IsLocked = is_Loked;
            _Mabiat.TotalSalary = decimal.Parse(tb_TotalSalary.Text);

            if (_Mabiat.Save())
            {
                MabiatID = _Mabiat.MabiatID;

                foreach (var item in uctl_Sell.List_Fatora)
                {
                    item.MabiatID = MabiatID;

                    if (!item.Save())
                        MessageBox.Show($"balat {clsBalata.Find(item.BalataID).Code} not Saved.");

                }

                uctl_Sell.Enabled = false;

                string pdf_Path = InvoiceGenerator.CreateArabicInvoice("abo", tb_TotalSalary.Text,
                    _Mabiat.ClientName, _Mabiat.ClientPhone, Global.CurrentUser.UserName, "afdsasdf", "0928374993");


                Form frm = new frmShowFatora(pdf_Path);
                frm.ShowDialog();

            }
            else
            {
                MessageBox.Show("", "");
            }
        }
        private void uctl_Sell_OnAction(object sender, uctl_Sell.ReternEvent e)
        {
            tb_TotalSalary.Text = e.TotalSalary.ToString();
        }

        private void tb_ClientName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(clsValidate.IsNumber(tb_ClientName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb_ClientName, "أدخل حروف فقط.");
            }
            else
            {
                errorProvider1.SetError(tb_ClientName, null);
            }
        }

        private void tb_ClientPhone_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(!clsValidate.IsNumber(tb_ClientPhone.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tb_ClientPhone, "أدخل أرقام فقط.");
            }
            else
            {
                errorProvider1.SetError(tb_ClientPhone, null);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

            Generat_Fatora(false);
        }
    }
}
