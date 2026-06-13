namespace Sahab_Balat.Balata
{
    partial class Uctl_BalataAddUpdate
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
            this.tb_CodeToFind = new System.Windows.Forms.TextBox();
            this.gcbtn_FindByCode = new Guna.UI2.WinForms.Guna2CircleButton();
            this.cb_Makazen_To_Find = new System.Windows.Forms.ComboBox();
            this.gb_WorkSpace = new System.Windows.Forms.GroupBox();
            this.cb_Makas = new System.Windows.Forms.ComboBox();
            this.cb_BalataType = new System.Windows.Forms.ComboBox();
            this.cb_MadeIn = new System.Windows.Forms.ComboBox();
            this.cb_Makazen = new System.Windows.Forms.ComboBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_AddPicture = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.picture_Balat = new System.Windows.Forms.PictureBox();
            this.tb_M_in_B = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_RemovePicture = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TB_Salary = new System.Windows.Forms.TextBox();
            this.TB_Code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_balatFind = new System.Windows.Forms.GroupBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gb_WorkSpace.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Balat)).BeginInit();
            this.gb_balatFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_CodeToFind
            // 
            this.tb_CodeToFind.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CodeToFind.Location = new System.Drawing.Point(57, 19);
            this.tb_CodeToFind.Name = "tb_CodeToFind";
            this.tb_CodeToFind.Size = new System.Drawing.Size(242, 28);
            this.tb_CodeToFind.TabIndex = 0;
          //  this.tb_CodeToFind.Validating += new System.ComponentModel.CancelEventHandler(this.tb_CodeToFind_Validating);
            // 
            // gcbtn_FindByCode
            // 
            this.gcbtn_FindByCode.BackColor = System.Drawing.Color.Transparent;
            this.gcbtn_FindByCode.BackgroundImage = global::Sahab_Balat.Properties.Resources.search_line;
            this.gcbtn_FindByCode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.gcbtn_FindByCode.CustomBorderColor = System.Drawing.Color.Transparent;
            this.gcbtn_FindByCode.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gcbtn_FindByCode.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gcbtn_FindByCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gcbtn_FindByCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gcbtn_FindByCode.FillColor = System.Drawing.Color.Transparent;
            this.gcbtn_FindByCode.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gcbtn_FindByCode.ForeColor = System.Drawing.Color.White;
            this.gcbtn_FindByCode.Location = new System.Drawing.Point(1, 18);
            this.gcbtn_FindByCode.Name = "gcbtn_FindByCode";
            this.gcbtn_FindByCode.Padding = new System.Windows.Forms.Padding(2);
            this.gcbtn_FindByCode.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.gcbtn_FindByCode.Size = new System.Drawing.Size(50, 29);
            this.gcbtn_FindByCode.TabIndex = 1;
            this.gcbtn_FindByCode.Click += new System.EventHandler(this.gcbtn_FindByCode_Click);
            // 
            // cb_Makazen_To_Find
            // 
            this.cb_Makazen_To_Find.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Makazen_To_Find.Font = new System.Drawing.Font("Berlin Sans FB Demi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Makazen_To_Find.FormattingEnabled = true;
            this.cb_Makazen_To_Find.Location = new System.Drawing.Point(305, 18);
            this.cb_Makazen_To_Find.Name = "cb_Makazen_To_Find";
            this.cb_Makazen_To_Find.Size = new System.Drawing.Size(115, 29);
            this.cb_Makazen_To_Find.TabIndex = 2;
            // 
            // gb_WorkSpace
            // 
            this.gb_WorkSpace.Controls.Add(this.cb_Makas);
            this.gb_WorkSpace.Controls.Add(this.cb_BalataType);
            this.gb_WorkSpace.Controls.Add(this.cb_MadeIn);
            this.gb_WorkSpace.Controls.Add(this.cb_Makazen);
            this.gb_WorkSpace.Controls.Add(this.btn_Save);
            this.gb_WorkSpace.Controls.Add(this.btn_AddPicture);
            this.gb_WorkSpace.Controls.Add(this.label8);
            this.gb_WorkSpace.Controls.Add(this.picture_Balat);
            this.gb_WorkSpace.Controls.Add(this.tb_M_in_B);
            this.gb_WorkSpace.Controls.Add(this.label5);
            this.gb_WorkSpace.Controls.Add(this.btn_RemovePicture);
            this.gb_WorkSpace.Controls.Add(this.label7);
            this.gb_WorkSpace.Controls.Add(this.TB_Salary);
            this.gb_WorkSpace.Controls.Add(this.TB_Code);
            this.gb_WorkSpace.Controls.Add(this.label6);
            this.gb_WorkSpace.Controls.Add(this.label4);
            this.gb_WorkSpace.Controls.Add(this.label3);
            this.gb_WorkSpace.Controls.Add(this.label2);
            this.gb_WorkSpace.Controls.Add(this.label1);
            this.gb_WorkSpace.Location = new System.Drawing.Point(33, 103);
            this.gb_WorkSpace.Name = "gb_WorkSpace";
            this.gb_WorkSpace.Size = new System.Drawing.Size(815, 446);
            this.gb_WorkSpace.TabIndex = 3;
            this.gb_WorkSpace.TabStop = false;
            // 
            // cb_Makas
            // 
            this.cb_Makas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Makas.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cb_Makas.FormattingEnabled = true;
            this.cb_Makas.Location = new System.Drawing.Point(458, 346);
            this.cb_Makas.Name = "cb_Makas";
            this.cb_Makas.Size = new System.Drawing.Size(149, 32);
            this.cb_Makas.TabIndex = 94;
            // 
            // cb_BalataType
            // 
            this.cb_BalataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BalataType.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cb_BalataType.FormattingEnabled = true;
            this.cb_BalataType.Location = new System.Drawing.Point(458, 155);
            this.cb_BalataType.Name = "cb_BalataType";
            this.cb_BalataType.Size = new System.Drawing.Size(149, 32);
            this.cb_BalataType.TabIndex = 93;
            // 
            // cb_MadeIn
            // 
            this.cb_MadeIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MadeIn.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.cb_MadeIn.FormattingEnabled = true;
            this.cb_MadeIn.Location = new System.Drawing.Point(458, 106);
            this.cb_MadeIn.Name = "cb_MadeIn";
            this.cb_MadeIn.Size = new System.Drawing.Size(149, 32);
            this.cb_MadeIn.TabIndex = 92;
            // 
            // cb_Makazen
            // 
            this.cb_Makazen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Makazen.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Makazen.FormattingEnabled = true;
            this.cb_Makazen.Location = new System.Drawing.Point(458, 58);
            this.cb_Makazen.Name = "cb_Makazen";
            this.cb_Makazen.Size = new System.Drawing.Size(149, 32);
            this.cb_Makazen.TabIndex = 3;
            // 
            // btn_Save
            // 
            this.btn_Save.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(592, 396);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(164, 44);
            this.btn_Save.TabIndex = 80;
            this.btn_Save.Text = "حفط";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_AddPicture
            // 
            this.btn_AddPicture.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_AddPicture.FlatAppearance.BorderSize = 3;
            this.btn_AddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddPicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddPicture.ForeColor = System.Drawing.Color.Black;
            this.btn_AddPicture.Location = new System.Drawing.Point(210, 335);
            this.btn_AddPicture.Name = "btn_AddPicture";
            this.btn_AddPicture.Size = new System.Drawing.Size(115, 32);
            this.btn_AddPicture.TabIndex = 90;
            this.btn_AddPicture.Text = "اضف ";
            this.btn_AddPicture.UseVisualStyleBackColor = false;
            this.btn_AddPicture.Click += new System.EventHandler(this.btn_AddPicture_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(229, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 23);
            this.label8.TabIndex = 89;
            this.label8.Text = " :  الصورة";
            // 
            // picture_Balat
            // 
            this.picture_Balat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picture_Balat.Location = new System.Drawing.Point(91, 72);
            this.picture_Balat.Name = "picture_Balat";
            this.picture_Balat.Size = new System.Drawing.Size(234, 255);
            this.picture_Balat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture_Balat.TabIndex = 88;
            this.picture_Balat.TabStop = false;
            // 
            // tb_M_in_B
            // 
            this.tb_M_in_B.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.tb_M_in_B.Location = new System.Drawing.Point(458, 305);
            this.tb_M_in_B.MaxLength = 10;
            this.tb_M_in_B.Name = "tb_M_in_B";
            this.tb_M_in_B.Size = new System.Drawing.Size(152, 30);
            this.tb_M_in_B.TabIndex = 86;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(664, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 23);
            this.label5.TabIndex = 85;
            this.label5.Text = " :   العبوة ";
            // 
            // btn_RemovePicture
            // 
            this.btn_RemovePicture.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_RemovePicture.FlatAppearance.BorderSize = 3;
            this.btn_RemovePicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemovePicture.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RemovePicture.ForeColor = System.Drawing.Color.Black;
            this.btn_RemovePicture.Location = new System.Drawing.Point(91, 335);
            this.btn_RemovePicture.Name = "btn_RemovePicture";
            this.btn_RemovePicture.Size = new System.Drawing.Size(113, 33);
            this.btn_RemovePicture.TabIndex = 91;
            this.btn_RemovePicture.Text = "ازالة ";
            this.btn_RemovePicture.UseVisualStyleBackColor = false;
            this.btn_RemovePicture.Click += new System.EventHandler(this.btn_RemovePicture_Click_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(662, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 23);
            this.label7.TabIndex = 81;
            this.label7.Text = " :  المخزن";
            // 
            // TB_Salary
            // 
            this.TB_Salary.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.TB_Salary.Location = new System.Drawing.Point(458, 256);
            this.TB_Salary.MaxLength = 10;
            this.TB_Salary.Name = "TB_Salary";
            this.TB_Salary.Size = new System.Drawing.Size(152, 30);
            this.TB_Salary.TabIndex = 79;
            // 
            // TB_Code
            // 
            this.TB_Code.Font = new System.Drawing.Font("Berlin Sans FB Demi", 12F, System.Drawing.FontStyle.Bold);
            this.TB_Code.Location = new System.Drawing.Point(458, 207);
            this.TB_Code.MaxLength = 10;
            this.TB_Code.Name = "TB_Code";
            this.TB_Code.Size = new System.Drawing.Size(152, 30);
            this.TB_Code.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(658, 352);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 23);
            this.label6.TabIndex = 77;
            this.label6.Text = ": المقاس ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(673, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 76;
            this.label4.Text = ":    النوع";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(665, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 23);
            this.label3.TabIndex = 75;
            this.label3.Text = ":   السعر   ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(662, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 23);
            this.label2.TabIndex = 74;
            this.label2.Text = " :     الكود ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(662, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 23);
            this.label1.TabIndex = 73;
            this.label1.Text = " :    الصنع";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(97, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(556, 28);
            this.label9.TabIndex = 4;
            this.label9.Text = "أختر المخزن و أبحث عن الكود لتعديل بيانات البلاظة";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(727, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 52);
            this.button1.TabIndex = 81;
            this.button1.Text = "اضافة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gb_balatFind
            // 
            this.gb_balatFind.Controls.Add(this.tb_CodeToFind);
            this.gb_balatFind.Controls.Add(this.gcbtn_FindByCode);
            this.gb_balatFind.Controls.Add(this.cb_Makazen_To_Find);
            this.gb_balatFind.Location = new System.Drawing.Point(33, 50);
            this.gb_balatFind.Name = "gb_balatFind";
            this.gb_balatFind.Size = new System.Drawing.Size(479, 55);
            this.gb_balatFind.TabIndex = 82;
            this.gb_balatFind.TabStop = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Uctl_BalataAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.gb_balatFind);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.gb_WorkSpace);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Uctl_BalataAddUpdate";
            this.Size = new System.Drawing.Size(1015, 590);
            this.Load += new System.EventHandler(this.Uctl_BalataAddUpdate_Load);
            this.gb_WorkSpace.ResumeLayout(false);
            this.gb_WorkSpace.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture_Balat)).EndInit();
            this.gb_balatFind.ResumeLayout(false);
            this.gb_balatFind.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_CodeToFind;
        private Guna.UI2.WinForms.Guna2CircleButton gcbtn_FindByCode;
        private System.Windows.Forms.ComboBox cb_Makazen_To_Find;
        private System.Windows.Forms.GroupBox gb_WorkSpace;
        private System.Windows.Forms.Button btn_AddPicture;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox picture_Balat;
        private System.Windows.Forms.TextBox tb_M_in_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_RemovePicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox TB_Salary;
        private System.Windows.Forms.TextBox TB_Code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_balatFind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cb_Makazen;
        private System.Windows.Forms.ComboBox cb_BalataType;
        private System.Windows.Forms.ComboBox cb_MadeIn;
        private System.Windows.Forms.ComboBox cb_Makas;
    }
}
