using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BissnussLayer;


namespace Sahab_Balat.Balata
{
    public partial class Uctl_Balats : UserControl
    {
        public Uctl_Balats()
        {
            InitializeComponent();
        }

        DataTable dt_Makazen = new DataTable();
        DataTable DT_Balat = clsBalata.GetAll();
        DataTable dt_balat = new DataTable();// DT_Balat.DefaultView.ToTable(false, "ID", "النوع", "الكود", "الصنع", "سعر المتر", "المقاس", "المتر في الصندوق");


        private void _FillComboMakazen()
        {
            dt_Makazen = clsMakzen.GetAll();

            cb_MakazenList.Items.Add("الجميع");

            // Get Alat of time
            foreach (DataRow dr in dt_Makazen.Rows)
            {
                cb_MakazenList.Items.Add(dr[0]);
            }

            cb_MakazenList.SelectedIndex = 0;
        }

        private DataTable ReturnColumn(DataTable DT)
        {
            DataTable dt = new DataTable();

            List<string> col = new List<string> { "ID", "النوع", "الكود", "الصنع", "المخزن", "المقاس", "المتر في الصندوق","سعر الصندوق" };

            col.ForEach(c => dt.Columns.Add(c));

            dt.Columns[0].DataType = typeof(int);

            // Get alat of time
            foreach (DataRow row in DT.Rows)
            {
                dt.Rows.Add(row[0], row[1], row[2], row[3], row[4], row[5], row[6], row[7]);
            }

            return dt;
        }

        private void Refresh_Balats(int _MakzanID = -1)
        {
            if (_MakzanID == -1)
                DT_Balat = clsBalata.GetAll();
            else
                DT_Balat = clsBalata.GetAllBalatsInMakzan(_MakzanID);

            dt_balat = ReturnColumn(DT_Balat);

            gdgv_BalatList.DataSource = dt_balat;
            //    cb_BalatFilter.SelectedIndex = 0;

            
            
            if (gdgv_BalatList.Rows.Count > 0)
            {
                gdgv_BalatList.Columns[0].HeaderText = "ID";
                gdgv_BalatList.Columns[0].Width = 50;

                gdgv_BalatList.Columns[1].HeaderText = "النوع";
                gdgv_BalatList.Columns[1].Width = 100;

                gdgv_BalatList.Columns[2].HeaderText = "الكود";
                gdgv_BalatList.Columns[2].Width = 100;

                gdgv_BalatList.Columns[3].HeaderText = "الصنع";
                gdgv_BalatList.Columns[3].Width = 100;

                gdgv_BalatList.Columns[4].HeaderText = "المخرن";
                gdgv_BalatList.Columns[4].Width = 100;

                gdgv_BalatList.Columns[5].HeaderText = "المقاس";
                gdgv_BalatList.Columns[5].Width = 100;

                gdgv_BalatList.Columns[6].HeaderText = "المتر في الصندوق";
                gdgv_BalatList.Columns[6].Width = 100;

                gdgv_BalatList.Columns[7].HeaderText = "سعر الصندوق";
                gdgv_BalatList.Columns[7].Width = 100;

            }


            lab_BalatRecord.Text = gdgv_BalatList.RowCount.ToString();
        }



        private void _FillComboFilter()
        {
            DataTable dataTable = new DataTable();

            if (cb_BalatFilter.Text == "النوع")
                dataTable = clsBalatType.GetAll();
            else
                dataTable = clsMakas.GetAll();

            cb_Balata_TypeAndMakas.Items.Add("الجميع");

            foreach (DataRow row in dataTable.Rows)
            {
                cb_Balata_TypeAndMakas.Items.Add(row[1].ToString());
            }
        }


       
        private void cb_MakazenList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_MakazenList.Text != "الجميع")
            {
                int MID = clsMakzen.Find(cb_MakazenList.Text).MakazenID;
                Refresh_Balats(MID);
            }
            else
            {
                Refresh_Balats();
            }
        }

        private void Uctl_Balats_Load(object sender, EventArgs e)
        {
            cb_Balata_TypeAndMakas.Visible = false;
            tb_BalatFilter.Visible = false;
            _FillComboMakazen();
            Refresh_Balats();
        }

        private void gdgv_BalatList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // uctl_BalatInfo1.LoadBalatInfo((int)gdgv_BalatList.CurrentRow.Cells[0].Value);
        }

        private void cb_BalatFilter_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (cb_BalatFilter.Text)
            {
                case "الجميع":
                    tb_BalatFilter.Visible = false;
                    cb_Balata_TypeAndMakas.Visible = false;
                    dt_balat.DefaultView.RowFilter = "";
                    break;

                case "الكود":
                    dt_balat.DefaultView.RowFilter = "";
                    cb_Balata_TypeAndMakas.Visible = false;
                    tb_BalatFilter.Visible = true;
                    tb_BalatFilter.Text = "";
                    tb_BalatFilter.Focus();
                    break;

                default:
                    tb_BalatFilter.Visible = false;
                    cb_Balata_TypeAndMakas.Visible = true;
                    cb_Balata_TypeAndMakas.Items.Clear();
                    _FillComboFilter();
                    cb_Balata_TypeAndMakas.SelectedIndex = 0;
                    break;
            }
        }



        private void tb_BalatFilter_TextChanged_1(object sender, EventArgs e)
        {
            string FilterBalat = "الكود";

            dt_balat.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterBalat, tb_BalatFilter.Text);
            lab_BalatRecord.Text = DT_Balat.Rows.Count.ToString();
        }

        private void cb_Balata_TypeAndMakas_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cb_Balata_TypeAndMakas.Text == "الجميع")
                dt_balat.DefaultView.RowFilter = "";
            else
                dt_balat.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", cb_BalatFilter.Text, cb_Balata_TypeAndMakas.Text);

            lab_BalatRecord.Text = gdgv_BalatList.RowCount.ToString();

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Refresh_Balats();
        }
    }
}
