using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sahab_Balat._Mabiat
{
    public partial class uctl_Almabiat : UserControl
    {
        public uctl_Almabiat()
        {
            InitializeComponent();
        }

        private void uctl_Almabiat_Load(object sender, EventArgs e)
        {
           
        }

        private void uctl_Almabiat_Resize(object sender, EventArgs e)
        {
            this.uctl_Mabiat1.Size = this.Size;
        }
    }
}
