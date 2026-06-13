using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alkirat2.GlobalClass;
using BissnussLayer;

namespace Sahab_Balat.Makazen
{
    public partial class Uctl_Makazen : UserControl
    {
        public Uctl_Makazen()
        {
            InitializeComponent();
        }

        private DataTable dt_Makazen = new DataTable();

        private DataTable Format_Table()
        {
            List<string> list_col = new List<string> { "ID", "Name", "Number" };
            list_col.ForEach(l =>
            {
                Type type = l == "ID" ? typeof(int) : typeof(string);
                dt_Makazen.Columns.Add(l, type);
            });

            dt_Makazen = clsMakzen.GetMakazenTableWhitInfo();

            return dt_Makazen;
        }

        private void _FillMakazenDGV()
        {
            dt_Makazen = Format_Table();
            dgv_Makazen.DataSource = dt_Makazen;

            if (dt_Makazen.Rows.Count > 0)
            {
                dgv_Makazen.Columns[0].HeaderText = "ID";
                dgv_Makazen.Columns[0].Width = 50;

                dgv_Makazen.Columns[1].HeaderText = "Name";
                dgv_Makazen.Columns[1].Width = 100;

                dgv_Makazen.Columns[2].HeaderText = "Number";
                dgv_Makazen.Columns[2].Width = 150;

            }

            lab_Count.Text = dt_Makazen.Rows.Count.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            bool Admin = Global.CurrentUser.IsAdmin;
            حذفToolStripMenuItem.Enabled = Admin;
            تعديلToolStripMenuItem.Enabled = Admin;
        }

        //================================================== Fawater

        DataTable DT_Makazn = new DataTable();
        DataTable dt_Fawater = new DataTable();

        private void FillComboBox()
        {
            DT_Makazn = clsMakzen.GetAll();
            cb_MakazenList.Items.Add("All");

            foreach (DataRow row in DT_Makazn.Rows)
                cb_MakazenList.Items.Add(row["Makzan"]);


            // cb_MakazenList.SelectedIndex = 0;
        }

        private DataTable ReturnColumn(DataTable DT)
        {
            DataTable dt = new DataTable();

            List<string> col = new List<string> { "ID", "المخزن", "الكود", "الصناديق", "اجمالي الفاتورة", "الحالة", "التاريخ", "اسم الزبون", "رقم الزبون" };

            col.ForEach(c => dt.Columns.Add(c));

            dt.Columns[0].DataType = typeof(int);

            // Get alat of time
            foreach (DataRow row in DT.Rows)
            {
                dt.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7], row[8]);
            }

            return dt;
        }
        private void GetFawaterData(bool BitweenDate = false)
        {
            if (BitweenDate)
            {
                DataTable DTFatora = FauaterAlMakazen.LastMonth_F(dtp_From.Value, dtp_To.Value);
                dt_Fawater = ReturnColumn(DTFatora);
                dgv_Fauater.DataSource = dt_Fawater;
            }
            else
            {
                DataTable DTF = FauaterAlMakazen.Getall();
                dt_Fawater = ReturnColumn(DTF);
                dgv_Fauater.DataSource = dt_Fawater;
            }
        }

        private void RefreshFawaterData(bool BitweenDate = false)
        {
            GetFawaterData(BitweenDate);

            if (dgv_Fauater.Rows.Count > 0)
            {
                dgv_Fauater.Columns[0].HeaderText = "ID";
                dgv_Fauater.Columns[0].Width = 50;

                dgv_Fauater.Columns[1].HeaderText = "المخزن";
                dgv_Fauater.Columns[1].Width = 100;

                dgv_Fauater.Columns[2].HeaderText = "الكود";
                dgv_Fauater.Columns[2].Width = 70;

                dgv_Fauater.Columns[3].HeaderText = "الصناديق";
                dgv_Fauater.Columns[3].Width = 70;

                dgv_Fauater.Columns[4].HeaderText = "اجمالي الفاتورة";
                dgv_Fauater.Columns[4].Width = 100;

                dgv_Fauater.Columns[5].HeaderText = "الحالة";
                dgv_Fauater.Columns[5].Width = 60;

                dgv_Fauater.Columns[6].HeaderText = "التاريخ";
                dgv_Fauater.Columns[6].Width = 120;

                dgv_Fauater.Columns[7].HeaderText = "اسم الزبون";
                dgv_Fauater.Columns[7].Width = 100;

                dgv_Fauater.Columns[8].HeaderText = "رقم الزبون";
                dgv_Fauater.Columns[8].Width = 100;


            }

            lab_FatoraRecord.Text = dgv_Fauater.Rows.Count.ToString();
        }

        private void btn_GetFauaterBetweenDate_Click(object sender, EventArgs e)
        {
            if (dtp_From.Value <= dtp_To.Value)
            {
                MessageBox.Show("", "");
                return;
            }
            RefreshFawaterData(true);
        }

        private void btn_ShowAll_Click(object sender, EventArgs e)
        {
            RefreshFawaterData();
        }

        private void cb_FilterFatora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FilterFatora.Text == "الجميع")
                dt_Fawater.DefaultView.RowFilter = "";
            else
                dt_Fawater.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "الحالة", cb_FilterFatora.Text);

            lab_FatoraRecord.Text = dt_Fawater.Rows.Count.ToString();
        }

        private void cb_MakazenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_FilterFatora.Text == "الجميع")
                dt_Fawater.DefaultView.RowFilter = "";
            else
                dt_Fawater.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", "المخزن", cb_MakazenList.Text);

            lab_FatoraRecord.Text = dt_Fawater.Rows.Count.ToString();
        }

        private void Uctl_Makazen_Load(object sender, EventArgs e)
        {
            _FillMakazenDGV();

            FillComboBox();
            RefreshFawaterData();

            cb_FilterFatora.SelectedIndex = 0;
            cb_MakazenList.SelectedIndex = 0;

            dtp_From.MaxDate = DateTime.Now.AddDays(-1);
            dtp_From.MinDate = DateTime.Now.AddYears(-3);

            dtp_To.MaxDate = DateTime.Now;
            dtp_To.MinDate = DateTime.Now.AddYears(-3);
        }



        //==================================================================== AddUpdate

        private clsMakzen _Makzen;
        private int _MakzenID = -1;
        enum Mode { Add, Update }
        private Mode _Mode = Mode.Add;


        private void button1_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
                return;

            _Makzen.Name = textBox1.Text.Trim();
            _Makzen.Number = textBox2.Text.Trim();

            if (_Makzen.Save())
                MessageBox.Show("Add Succssfuly", "Addeing", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Add Fail", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            _Makzen = new clsMakzen();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (clsValidate.IsNumber(textBox1.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "Inter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (!clsValidate.IsNumber(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "Inter Number");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, null);
            }
        }

        private void تعديلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Mode = Mode.Update;
            _MakzenID = (int)dgv_Makazen.CurrentRow.Cells[0].Value;

            this.Text = "Update";
            lab_Title.Text = "Update";
            button1.Text = "Update";
            _Makzen = clsMakzen.Find(_MakzenID);
            textBox1.Text = _Makzen.Name;
            textBox2.Text = _Makzen.Number;
        }
    }
}
