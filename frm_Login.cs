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
using Alkirat2;
using Alkirat2.GlobalClass;
using BissnussLayer;
using Sahab_Balat.Forms;

namespace Sahab_Balat
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            gcb_UsersNames.Items.AddRange(clsUser.GetUserNames().ToArray());

          timer1_Tick(null, EventArgs.Empty);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();
            lab_Houre.Text = DateTime.Now.ToString("yyyy/mm/dd");
        }
        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            clsUser userTemp = clsUser.GetUserBy_Name_Password(gcb_UsersNames.Text, tb_Password.Text);

            if (userTemp != null)
            {
                Global.CurrentUser = userTemp;

                Form mainfrm = new New_frm_Main();
                mainfrm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Erorr : name or password");
            }
        }



    }
}
