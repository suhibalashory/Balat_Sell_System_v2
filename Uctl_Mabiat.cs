using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using BissnussLayer;
using System.Windows.Forms;
using Alkirat2.GlobalClass;

namespace Sahab_Balat.Mabiat
{
    public partial class Uctl_Mabiat : UserControl
    {
        public Uctl_Mabiat()
        {
            InitializeComponent();
        }

        private DataTable dt_Mabiat;

        private void button1_Click(object sender, EventArgs e)
        {
            SetDefultValue(true);
        }

        private void SetDefultValue(bool setDate = false)
        {
            if(setDate) 
                dt_Mabiat = BissnussLayer.Mabiat.GetAllBetween(dtp_From.Value,dtp_To.Value);
            else
                dt_Mabiat = BissnussLayer.Mabiat.GetAll();


            dgv_Mabiat.DataSource = dt_Mabiat;

            if (dgv_Mabiat.Rows.Count > 0) { 

                dgv_Mabiat.Columns[0].HeaderText = "أسم الزبون";
                dgv_Mabiat.Columns[0].Width = 100;

                dgv_Mabiat.Columns[1].HeaderText = "رقم الزبون";
                dgv_Mabiat.Columns[1].Width = 100;

                dgv_Mabiat.Columns[2].HeaderText = "إجمالي المبلغ";
                dgv_Mabiat.Columns[2].Width = 100;

                dgv_Mabiat.Columns[3].HeaderText = "الباقي";
                dgv_Mabiat.Columns[3].Width = 100;

                dgv_Mabiat.Columns[4].HeaderText = "التاريخ";
                dgv_Mabiat.Columns[4].Width = 100;
            }



        }


        private void حذفالفاتورةToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Uctl_Mabiat_Load(object sender, EventArgs e)
        {
         
            SetDefultValue();
            cb_Filter.SelectedIndex = 0;
        }

        private void cb_Filter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            tb_FilterBy.Text = "";
        }

        private void tb_FilterBy_TextChanged(object sender, EventArgs e)
        {
          

        }

        //private void tb_FilterBy_Validating(object sender, CancelEventArgs e)
        //{
        //    if (cb_Filter.SelectedIndex == 0)
        //    {
        //        if (clsValidate.IsNumber(tb_FilterBy.Text) || string.IsNullOrWhiteSpace(tb_FilterBy.Text))
        //        {
        //            e.Cancel = true;
        //            errorProvider1.SetError(tb_FilterBy, "أدخل حروف فقط للبجث !!");
        //        }
        //        else
        //        {
        //            errorProvider1.SetError(tb_FilterBy, null);
        //        }
        //    }
        //    else
        //    { 
        //        if (!clsValidate.IsNumber(tb_FilterBy.Text))
        //        {
        //            e.Cancel= true;
        //            errorProvider1.SetError(tb_FilterBy, "");

        //        }
        //        else
        //        {
        //            errorProvider1.SetError(tb_FilterBy, null);
        //        }
        //    }

        //}
    }
}
