namespace Alkirat2
{
	partial class frm_Fatora
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Fatora));
            this.uctl_Sell = new Alkirat2.uctl_Sell();
            this.label1 = new System.Windows.Forms.Label();
            this.gbtn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_ClientName = new System.Windows.Forms.TextBox();
            this.tb_ClientPhone = new System.Windows.Forms.TextBox();
            this.tb_3arbon = new System.Windows.Forms.TextBox();
            this.tb_TotalSalary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // uctl_Sell
            // 
            this.uctl_Sell.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.uctl_Sell.GropBox = false;
            this.uctl_Sell.Location = new System.Drawing.Point(13, 149);
            this.uctl_Sell.Margin = new System.Windows.Forms.Padding(4);
            this.uctl_Sell.Name = "uctl_Sell";
            this.uctl_Sell.Size = new System.Drawing.Size(800, 500);
            this.uctl_Sell.TabIndex = 0;
            this.uctl_Sell.OnAction += new System.EventHandler<Alkirat2.uctl_Sell.ReternEvent>(this.uctl_Sell_OnAction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(282, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = " أصدار الفاتورة ";
            // 
            // gbtn_Save
            // 
            this.gbtn_Save.BorderRadius = 9;
            this.gbtn_Save.BorderThickness = 2;
            this.gbtn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_Save.FocusedColor = System.Drawing.Color.Transparent;
            this.gbtn_Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_Save.ForeColor = System.Drawing.Color.White;
            this.gbtn_Save.Location = new System.Drawing.Point(646, 684);
            this.gbtn_Save.Name = "gbtn_Save";
            this.gbtn_Save.Size = new System.Drawing.Size(167, 45);
            this.gbtn_Save.TabIndex = 2;
            this.gbtn_Save.Text = "اصدار ";
            this.gbtn_Save.Click += new System.EventHandler(this.gbtn_Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = ": أسم الزبون ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = ": رقم الربون";
            // 
            // tb_ClientName
            // 
            this.tb_ClientName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ClientName.Location = new System.Drawing.Point(392, 104);
            this.tb_ClientName.Name = "tb_ClientName";
            this.tb_ClientName.Size = new System.Drawing.Size(210, 35);
            this.tb_ClientName.TabIndex = 5;
            this.tb_ClientName.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ClientName_Validating);
            // 
            // tb_ClientPhone
            // 
            this.tb_ClientPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ClientPhone.Location = new System.Drawing.Point(21, 112);
            this.tb_ClientPhone.Name = "tb_ClientPhone";
            this.tb_ClientPhone.Size = new System.Drawing.Size(210, 32);
            this.tb_ClientPhone.TabIndex = 6;
            this.tb_ClientPhone.Validating += new System.ComponentModel.CancelEventHandler(this.tb_ClientPhone_Validating);
            // 
            // tb_3arbon
            // 
            this.tb_3arbon.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_3arbon.Location = new System.Drawing.Point(13, 697);
            this.tb_3arbon.Name = "tb_3arbon";
            this.tb_3arbon.Size = new System.Drawing.Size(188, 29);
            this.tb_3arbon.TabIndex = 10;
            // 
            // tb_TotalSalary
            // 
            this.tb_TotalSalary.BackColor = System.Drawing.Color.Black;
            this.tb_TotalSalary.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TotalSalary.ForeColor = System.Drawing.Color.Lime;
            this.tb_TotalSalary.Location = new System.Drawing.Point(319, 686);
            this.tb_TotalSalary.Name = "tb_TotalSalary";
            this.tb_TotalSalary.Size = new System.Drawing.Size(188, 40);
            this.tb_TotalSalary.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(204, 697);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = " :      المدفوع ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(513, 695);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = ": السعر النهائي ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FocusedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(150, 49);
            this.guna2Button1.TabIndex = 11;
            this.guna2Button1.Text = "تعليق";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // frm_Fatora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(822, 742);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.tb_3arbon);
            this.Controls.Add(this.tb_TotalSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_ClientPhone);
            this.Controls.Add(this.tb_ClientName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gbtn_Save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uctl_Sell);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Fatora";
            this.Text = "frm_Fatora";
            this.Load += new System.EventHandler(this.frm_Fatora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion

		private uctl_Sell uctl_Sell;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button gbtn_Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_ClientName;
        private System.Windows.Forms.TextBox tb_ClientPhone;
        private System.Windows.Forms.TextBox tb_3arbon;
        private System.Windows.Forms.TextBox tb_TotalSalary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}