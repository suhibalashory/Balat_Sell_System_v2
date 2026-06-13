namespace Sahab_Balat
{
    partial class frm_Login
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
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.gcb_UsersNames = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Sahab = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lab_Houre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 9;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(564, 263);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(134, 33);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Login";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(350, 193);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(169, 28);
            this.tb_Password.TabIndex = 2;
            // 
            // gcb_UsersNames
            // 
            this.gcb_UsersNames.BackColor = System.Drawing.Color.Transparent;
            this.gcb_UsersNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gcb_UsersNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gcb_UsersNames.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb_UsersNames.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gcb_UsersNames.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcb_UsersNames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.gcb_UsersNames.ItemHeight = 30;
            this.gcb_UsersNames.Location = new System.Drawing.Point(350, 151);
            this.gcb_UsersNames.Name = "gcb_UsersNames";
            this.gcb_UsersNames.Size = new System.Drawing.Size(169, 36);
            this.gcb_UsersNames.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(534, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = " : أسم المستخدم ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(545, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = ": الرقم السري ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Sahab_Balat.Properties.Resources.تصميم_بدون_عنوان__1_;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(326, 319);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Sahab
            // 
            this.Sahab.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Sahab.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Sahab.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sahab.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sahab.Location = new System.Drawing.Point(326, 0);
            this.Sahab.Name = "Sahab";
            this.Sahab.Size = new System.Drawing.Size(388, 27);
            this.Sahab.TabIndex = 7;
            this.Sahab.Text = "Sahab";
            this.Sahab.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_Houre
            // 
            this.lab_Houre.AutoSize = true;
            this.lab_Houre.BackColor = System.Drawing.Color.LightGray;
            this.lab_Houre.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Houre.Location = new System.Drawing.Point(589, 30);
            this.lab_Houre.Name = "lab_Houre";
            this.lab_Houre.Size = new System.Drawing.Size(125, 33);
            this.lab_Houre.TabIndex = 10;
            this.lab_Houre.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(714, 319);
            this.Controls.Add(this.lab_Houre);
            this.Controls.Add(this.Sahab);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcb_UsersNames);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.guna2Button1);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frm_Login";
            this.Text = "sahab";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.TextBox tb_Password;
        private Guna.UI2.WinForms.Guna2ComboBox gcb_UsersNames;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Sahab;
        private System.Windows.Forms.Label lab_Houre;
        private System.Windows.Forms.Timer timer1;
    }
}

