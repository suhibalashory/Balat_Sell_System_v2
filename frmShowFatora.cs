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
using Sahab_Balat.Controls;

namespace Alkirat2
{
	public partial class frmShowFatora : Form
	{
		string Fatora_img_Path = string.Empty;

        public frmShowFatora(string img_Path = "")
		{
			InitializeComponent();

			this.Fatora_img_Path = "C:\\Users\\hp\\Desktop\\Fawater_pdf\\فاتورة_بيع.pdf";
        }


		private void frmShowFatora_Load(object sender, EventArgs e)
		{
			uctl_formshowing1.load_img(Fatora_img_Path);
		}



	}
}
