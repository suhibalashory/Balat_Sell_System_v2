using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alkirat2;
using BissnussLayer;
using Sahab_Balat._Mabiat;
using Sahab_Balat.AL_Tkarir;
using Sahab_Balat.Balata;
using Sahab_Balat.Mabiat;
using Sahab_Balat.Makazen;
using Sahab_Balat.Setting;

namespace Sahab_Balat.Forms
{
    public partial class New_frm_Main : Form
    {

        Uctl_Almakazen Uctl_Almakazen;
        uctl_Almabiat uctl_Almabiat;
        Uctl_E3dadat Uctl_E3Dadat;
        Uctl_Al3rod uctl_Al3Rod;
        Uctl_Al_Takarir Uctl_Al_Takarir;

        string[] Adkar = { "","سبحان الله و بحمده", " الحمد لله عدد خلقه و رضي نفسه", " اللهم أغفر لي و لوالدي ",
            "لا أله إلا الله وحده لا شريك له"};


        DateTime time  = DateTime.Now;
        Random random = new Random();

        public New_frm_Main()
        {
            InitializeComponent();
        }



        private void New_frm_Main_Load(object sender, EventArgs e)
        {
            
            this.uctl_Al3Rod = new Uctl_Al3rod();
            this.uctl_Almabiat = new uctl_Almabiat();
            this.Uctl_Almakazen = new Uctl_Almakazen();
            this.Uctl_E3Dadat = new Uctl_E3dadat();
            this.Uctl_Al_Takarir = new Uctl_Al_Takarir();

            Alkirat2.GlobalClass.Global.CurrentUser = clsUser.GetUserBy_Name_Password("Admin", "1234");

            pnl_WorkSpace.Controls.Clear();

            pnl_WorkSpace.Controls.Add(uctl_Al3Rod);
        }

        private void Resit_a_btn_Color()
        {
            gbtn_3orod.BackColor = panel1.BackColor;
            gbtn_Mabiat.BackColor = panel1.BackColor;
            guna2Button1.BackColor = panel1.BackColor;
            guna2Button3.BackColor = panel1.BackColor;
            guna2Button4.BackColor = panel1.BackColor;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

            Form frm_fatora = new frm_Fatora();
            frm_fatora.Show();
        }

        private void gbtn_3orod_Click(object sender, EventArgs e)
        {
            Resit_a_btn_Color();
            gbtn_3orod.BackColor = Color.Gray;

            pnl_WorkSpace.Controls.Clear();

            pnl_WorkSpace.Controls.Add(uctl_Al3Rod);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Resit_a_btn_Color();
            guna2Button1.BackColor = Color.Gray;

            pnl_WorkSpace.Controls.Clear();


           pnl_WorkSpace.Controls.Add(Uctl_Almakazen); 
        }

        private void gbtn_Mabiat_Click(object sender, EventArgs e)
        {
            Resit_a_btn_Color();
            gbtn_Mabiat.BackColor = Color.Gray;

            pnl_WorkSpace.Controls.Clear();


            pnl_WorkSpace.Controls.Add(uctl_Almabiat);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Resit_a_btn_Color();
            guna2Button4.BackColor = Color.Gray;

            pnl_WorkSpace.Controls.Clear();


            pnl_WorkSpace.Controls.Add(Uctl_E3Dadat);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Resit_a_btn_Color();
            guna2Button3.BackColor = Color.Gray;

            pnl_WorkSpace.Controls.Clear();


            pnl_WorkSpace.Controls.Add(Uctl_Al_Takarir);
        }




    }
}
