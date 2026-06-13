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

namespace Sahab_Balat.Setting
{
    public partial class uctl_Setting : UserControl
    {

        /*  Algo 
         *  1 - fill combos .
         *  2 - enable false to grop user
         *  3- fill BaseInfo
         
         */

        BaseInfo _BaseInfo;

        public uctl_Setting()
        {
            InitializeComponent();
        }

        int EmployeesCount { get; set; }

        // ===================== BaseInfo 
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pnl_EmployeesSalary.Controls.Clear();

            if (tb_EmployeesCount.Text.Length < 0 || string.IsNullOrEmpty(tb_EmployeesCount.Text) || int.Parse(tb_EmployeesCount.Text) > 10)
                return;

            EmployeesCount = int.Parse(tb_EmployeesCount.Text);

            for (int i = 1; i <= EmployeesCount; i++)
            {
                pnl_EmployeesSalary.Controls.Add(new Sahab_Balat.Controls.Uctl_EmployeeSalarys_List()
                {
                    lab_text = i.ToString(),
                    Dock = DockStyle.Top
                });
            }

        }

        private void FillBaseInfo()
        {
            _BaseInfo = BaseInfo.getBaseInfo();
            tb_StoreName.Text = _BaseInfo.StoreName;
            tb_BaseInfo_Phone.Text = _BaseInfo.Phone;
            tb_Location.Text = _BaseInfo.Location;
            tb_StoreRent.Text = _BaseInfo.StoreRent.ToString();
            tb_EmployeesCount.Text = "5";
        }
        

        private void uctl_Setting_Load(object sender, EventArgs e)
        {
            gb_UserInfo_update.Enabled = false;
            FillBaseInfo();
            FillCombos();
            cb_ListUserNames.Items.AddRange(clsUser.GetUserNames().ToArray());
            guna2Button5.PerformClick();

        }

        private void cb_ListUserNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool isSameUser = cb_ListUserNames.SelectedText == Global.CurrentUser.UserName;

            if(isSameUser)
            {
                tb_PassWord_update.Enabled = false;
                tb_PassWord_Agin_update.Enabled = false;
            }

        }


        // =================== Setting

        private void FillCombos()
        {
            dgv_Makas.DataSource = clsMakas.GetAll();
            dgv_MakeIn.DataSource = clsMadeIn.GetAll(); 
            dgv_BalatsType.DataSource = clsBalatType.GetAll();
        }

        private void btn_UpdateUser_Click(object sender, EventArgs e)
        {
           if(this.ValidateChildren() || tb_PassWord_update.Text == tb_PassWord_Agin_update.Text)
            {
                return;
            }

           clsUser newUser = new clsUser();

            newUser.UserName = tb_UserName_update.Text.Trim();
            newUser.UserPassword = tb_PassWord_Agin_update.Text.Trim();
            newUser.IsAdmin = checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked;
            
            if(newUser.Save())
            {

            }
        }

        private void btn_SaveNewUser_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_addMeadIn_Click(object sender, EventArgs e)
        {
            frm_Add_blatsInfo frm = new frm_Add_blatsInfo(1);
            frm.ShowDialog();

            this.uctl_Setting_Load(null,null);
            tabControl1.TabPages.Contains(tabPage5);
        }

        private void btn_addBalatType_Click(object sender, EventArgs e)
        {
            frm_Add_blatsInfo frm = new frm_Add_blatsInfo(3);
            frm.ShowDialog();

            this.uctl_Setting_Load(null, null);
            tabControl1.TabPages.Contains(tabPage5);

        }

        private void btn_Add_Makas_Click(object sender, EventArgs e)
        {
            frm_Add_blatsInfo frm = new frm_Add_blatsInfo(2);
            frm.ShowDialog();

            this.uctl_Setting_Load(null, null);
            tabControl1.TabPages.Contains(tabPage5);

        }
    }
}
