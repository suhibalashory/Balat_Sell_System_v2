using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahab_Balat.Controls
{
    public partial class Uctl_EmployeeSalarys_List : UserControl
    {
        public Uctl_EmployeeSalarys_List()
        {
            InitializeComponent();
        }

        public string lab_text {
            get { return this.textBox1.Text; }
            set {  this.textBox1.Text = value; }
                }

        
        private void Uctl_EmployeeSalarys_List_Load(object sender, EventArgs e)
        {

        }
    }
}
