
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using Alkirat2.GlobalClass;
using BissnussLayer;

namespace Alkirat2
{
	public partial class uctl_Sell : UserControl
	{
		public uctl_Sell()
		{
			InitializeComponent();
		}

		public class ReternEvent : EventArgs 
		{
			public decimal TotalSalary { get; set; }

			public ReternEvent(decimal total)
			{
				this.TotalSalary = total;
			}
		}
		public event EventHandler<ReternEvent> OnAction;
		public void OnAddFatora(decimal salary)
		{
			OnAddFatora(new ReternEvent(salary));
		}
		public virtual void OnAddFatora(ReternEvent e)
		{
		   OnAction?.Invoke(this, e);
		}


		//DataTable dt_Makazen;
		clsBalata _Balata = null;

		public bool GropBox
		{
			get { return groupBox1.Enabled; }
			set { groupBox1.Enabled = value; }
		}
	
		public List<BissnussLayer.FauaterAlMakazen> List_Fatora { get; set; } 

		public void LockedAddRow()
		{
			this.Enabled = false;
		}

		private void _FillComboMakazen()
		{
			DataRowCollection row = clsMakzen.GetAll().Rows;
			

			foreach (DataRow dr in row)
			{ 
				cb_MakazinList.Items.Add(dr["Makzan"]);
			}

			
			//cb_MakazinList.SelectedIndex = 0;
		}

		public decimal TotalSalary()
		{
			if(dgv_FauaterRows.Rows.Count < 1) return 0;

			decimal total = 0;

			for(int i = 0;i < dgv_FauaterRows.Rows.Count;i++)
			{
				var CellValue = dgv_FauaterRows.Rows[i].Cells[3].Value;
				total += (decimal)CellValue;
			}
			return total;
		}

		public void btn_Find_Click(object sender, EventArgs e)
		{
			_Balata = clsBalata.FindByCode_and_MakzenID(tb_BalatCode.Text,
				 clsMakzen.Find(cb_MakazinList.Text).MakazenID);

			if (_Balata != null) 
			{
			   groupBox1.Enabled = true;
			   lab_BalatCode.Text = _Balata.Code;
			   tb_Miter.Text = "";
			   tb_Boxis.Text = "";
			   tb_SalaryToFatora.Text = "";
			}
			else
			{
				MessageBox.Show($"Balat has Code({tb_BalatCode.Text}) Not Found", "Error");
			}
		}


		private void ازالةToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if(dgv_FauaterRows.Rows.Count < 1) return;

			int B_id = (int)dgv_FauaterRows.CurrentRow.Cells[0].Value;

			var ftr = List_Fatora.Where(x => x.BalataID == B_id).FirstOrDefault();
			List_Fatora.Remove(ftr);

			dgv_FauaterRows.DataSource = clsTransfers.convertToTable(List_Fatora);
		}

		private void btn_AddToRows_Click(object sender, EventArgs e)
		{
			if (String.IsNullOrEmpty(tb_Miter.Text) || _Balata == null)
				return;

			FauaterAlMakazen fato = new FauaterAlMakazen();

			fato.MakzanID = _Balata.MakazenID;
			fato.Box = int.Parse(tb_Boxis.Text);
			fato.BalataID = _Balata.BalatID;
			fato.TotalSalary = _Balata.Salary * decimal.Parse(tb_Miter.Text.Trim());
	

			List_Fatora.Add(fato);
		   dgv_FauaterRows.DataSource = clsTransfers.convertToTable(List_Fatora);

			if (OnAction != null)
				OnAddFatora(TotalSalary());

			groupBox1.Enabled = false;
		}

		private void tb_Miter_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(tb_Miter.Text))
			{
				tb_Miter.Text = string.Empty;
				return;
			}

			tb_Boxis.Text =  clsTransfers.FromMeterToBoxis(float.Parse(tb_Miter.Text.Trim()),
				_Balata.MiterInBox).ToString();
            
			float sf = (float)_Balata.Salary * float.Parse(tb_Miter.Text);
            tb_SalaryToFatora.Text = sf.ToString();

		}

		private void tb_Miter_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if(!clsValidate.IsNumber(tb_Miter.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(tb_Miter, "ادخل ارقام");
			}
			else
			{
				errorProvider1.SetError(tb_Miter, null);
			}
		}

		private void uctl_Sell_Load(object sender, EventArgs e)
		{
			_FillComboMakazen();
			this.List_Fatora = new List<FauaterAlMakazen>();
			GropBox = false;
		}

		private void tb_SalaryToFatora_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!clsValidate.IsNumber(tb_SalaryToFatora.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(tb_SalaryToFatora, "ادخل ارقام");
			}
			else
			{
				errorProvider1.SetError(tb_SalaryToFatora, null);
			}
		}

		private void tb_Boxis_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			if (!clsValidate.IsNumber(tb_Boxis.Text))
			{
				e.Cancel = true;
				errorProvider1.SetError(tb_Boxis, "ادخل ارقام");
			}
			else
			{
				errorProvider1.SetError(tb_Boxis, null);
			}
		}


	}
}
