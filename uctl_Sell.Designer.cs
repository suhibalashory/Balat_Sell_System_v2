namespace Alkirat2
{
	partial class uctl_Sell
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ازالةToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_BalatCode = new System.Windows.Forms.TextBox();
            this.cb_MakazinList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_AddToRows = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_SalaryToFatora = new System.Windows.Forms.TextBox();
            this.lab_BalatCode = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Boxis = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Miter = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btn_Find = new System.Windows.Forms.Button();
            this.dgv_FauaterRows = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FauaterRows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ازالةToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(105, 28);
            // 
            // ازالةToolStripMenuItem1
            // 
            this.ازالةToolStripMenuItem1.Name = "ازالةToolStripMenuItem1";
            this.ازالةToolStripMenuItem1.Size = new System.Drawing.Size(104, 24);
            this.ازالةToolStripMenuItem1.Text = "ازالة";
            this.ازالةToolStripMenuItem1.Click += new System.EventHandler(this.ازالةToolStripMenuItem1_Click);
            // 
            // tb_BalatCode
            // 
            this.tb_BalatCode.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BalatCode.Location = new System.Drawing.Point(470, 91);
            this.tb_BalatCode.Margin = new System.Windows.Forms.Padding(4);
            this.tb_BalatCode.Name = "tb_BalatCode";
            this.tb_BalatCode.Size = new System.Drawing.Size(155, 35);
            this.tb_BalatCode.TabIndex = 7;
            // 
            // cb_MakazinList
            // 
            this.cb_MakazinList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MakazinList.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MakazinList.FormattingEnabled = true;
            this.cb_MakazinList.Location = new System.Drawing.Point(472, 36);
            this.cb_MakazinList.Margin = new System.Windows.Forms.Padding(4);
            this.cb_MakazinList.Name = "cb_MakazinList";
            this.cb_MakazinList.Size = new System.Drawing.Size(153, 36);
            this.cb_MakazinList.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(632, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = " : كود  الصنف";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(636, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = ":    المخزن ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_AddToRows);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_SalaryToFatora);
            this.groupBox1.Controls.Add(this.lab_BalatCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Boxis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Miter);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(457, 203);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btn_AddToRows
            // 
            this.btn_AddToRows.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToRows.Location = new System.Drawing.Point(262, 143);
            this.btn_AddToRows.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddToRows.Name = "btn_AddToRows";
            this.btn_AddToRows.Size = new System.Drawing.Size(187, 52);
            this.btn_AddToRows.TabIndex = 14;
            this.btn_AddToRows.Text = "اضافة للفاتورة";
            this.btn_AddToRows.UseVisualStyleBackColor = true;
            this.btn_AddToRows.Click += new System.EventHandler(this.btn_AddToRows_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(161, 169);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = ": السعر ";
            // 
            // tb_SalaryToFatora
            // 
            this.tb_SalaryToFatora.BackColor = System.Drawing.Color.Black;
            this.tb_SalaryToFatora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SalaryToFatora.ForeColor = System.Drawing.Color.Lime;
            this.tb_SalaryToFatora.Location = new System.Drawing.Point(23, 163);
            this.tb_SalaryToFatora.Margin = new System.Windows.Forms.Padding(4);
            this.tb_SalaryToFatora.Name = "tb_SalaryToFatora";
            this.tb_SalaryToFatora.Size = new System.Drawing.Size(129, 32);
            this.tb_SalaryToFatora.TabIndex = 16;
            this.tb_SalaryToFatora.Validating += new System.ComponentModel.CancelEventHandler(this.tb_SalaryToFatora_Validating);
            // 
            // lab_BalatCode
            // 
            this.lab_BalatCode.AutoSize = true;
            this.lab_BalatCode.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_BalatCode.ForeColor = System.Drawing.Color.Red;
            this.lab_BalatCode.Location = new System.Drawing.Point(281, 19);
            this.lab_BalatCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_BalatCode.Name = "lab_BalatCode";
            this.lab_BalatCode.Size = new System.Drawing.Size(72, 24);
            this.lab_BalatCode.TabIndex = 14;
            this.lab_BalatCode.Text = "[????]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(361, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = " :  الكود ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(161, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = ": الصناديق ";
            // 
            // tb_Boxis
            // 
            this.tb_Boxis.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Boxis.Location = new System.Drawing.Point(23, 116);
            this.tb_Boxis.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Boxis.Name = "tb_Boxis";
            this.tb_Boxis.Size = new System.Drawing.Size(130, 32);
            this.tb_Boxis.TabIndex = 2;
            this.tb_Boxis.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Boxis_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = ": الأمتار ";
            // 
            // tb_Miter
            // 
            this.tb_Miter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Miter.Location = new System.Drawing.Point(23, 64);
            this.tb_Miter.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Miter.MaxLength = 1000;
            this.tb_Miter.Name = "tb_Miter";
            this.tb_Miter.Size = new System.Drawing.Size(129, 32);
            this.tb_Miter.TabIndex = 0;
            this.tb_Miter.TextChanged += new System.EventHandler(this.tb_Miter_TextChanged);
            this.tb_Miter.Validating += new System.ComponentModel.CancelEventHandler(this.tb_Miter_Validating);
            // 
            // btn_Find
            // 
            this.btn_Find.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Find.Location = new System.Drawing.Point(472, 141);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(167, 47);
            this.btn_Find.TabIndex = 12;
            this.btn_Find.Text = "بحت";
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // dgv_FauaterRows
            // 
            this.dgv_FauaterRows.AllowUserToAddRows = false;
            this.dgv_FauaterRows.AllowUserToDeleteRows = false;
            this.dgv_FauaterRows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgv_FauaterRows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_FauaterRows.ContextMenuStrip = this.contextMenuStrip1;
            this.dgv_FauaterRows.Location = new System.Drawing.Point(4, 226);
            this.dgv_FauaterRows.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_FauaterRows.Name = "dgv_FauaterRows";
            this.dgv_FauaterRows.ReadOnly = true;
            this.dgv_FauaterRows.RowHeadersWidth = 51;
            this.dgv_FauaterRows.Size = new System.Drawing.Size(768, 256);
            this.dgv_FauaterRows.TabIndex = 13;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // uctl_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.dgv_FauaterRows);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_BalatCode);
            this.Controls.Add(this.cb_MakazinList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uctl_Sell";
            this.Size = new System.Drawing.Size(782, 489);
            this.Load += new System.EventHandler(this.uctl_Sell_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FauaterRows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem ازالةToolStripMenuItem1;
		public System.Windows.Forms.TextBox tb_BalatCode;
		private System.Windows.Forms.ComboBox cb_MakazinList;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.Windows.Forms.TextBox tb_Miter;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lab_BalatCode;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tb_Boxis;
		private System.Windows.Forms.Button btn_Find;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox tb_SalaryToFatora;
		private System.Windows.Forms.Button btn_AddToRows;
		private System.Windows.Forms.DataGridView dgv_FauaterRows;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}
