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

namespace Sahab_Balat.Setting
{
    public partial class frm_Add_blatsInfo : Form
    {
        enum en_Add_balats_info { MadeIn = 1 ,Makas = 2 , BalatType = 3}

         en_Add_balats_info add_Type;
        TextBox textb = new TextBox();
        public frm_Add_blatsInfo(int add_Type)
        {
            InitializeComponent();
            this.add_Type = (en_Add_balats_info)add_Type;
        }

        private void frm_Add_blatsInfo_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch(add_Type)
            {
                case en_Add_balats_info.MadeIn:

                    clsMadeIn mdn = new clsMadeIn();
                    mdn.Country = textBox1.Text.Trim();

                    if (mdn.Save())
                        MessageBox.Show("succssfule");
                    else
                        MessageBox.Show( "Error","Error", MessageBoxButtons.OK);

                        break;

                case en_Add_balats_info.Makas:

                    clsMakas makas = new clsMakas();
                    makas.Makas = textBox1.Text.Trim();

                    if (makas.Save())
                        MessageBox.Show("Successfule");
                    else
                        MessageBox.Show("Error");

                        break;

                case en_Add_balats_info.BalatType:

                    clsBalatType type = new clsBalatType();

                    type.Type = textBox1.Text.Trim();

                    if (type.Save())
                        MessageBox.Show("Successfule");
                    else
                        MessageBox.Show("Error");

                        break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
