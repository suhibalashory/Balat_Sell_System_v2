namespace Sahab_Balat.Balata
{
    partial class Uctl_Balats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uctl_Balats));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_BalatRecord = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Balata_TypeAndMakas = new System.Windows.Forms.ComboBox();
            this.tb_BalatFilter = new System.Windows.Forms.TextBox();
            this.cb_BalatFilter = new System.Windows.Forms.ComboBox();
            this.cb_MakazenList = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip_B = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gdgv_BalatList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.uctl_BalataAddUpdate1 = new Sahab_Balat.Balata.Uctl_BalataAddUpdate();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_BalatList)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ImageList = this.imageList1;
            this.tabControl1.ItemSize = new System.Drawing.Size(170, 35);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1418, 739);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1410, 696);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "عروض الصالة";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gdgv_BalatList);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(43, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 653);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lab_BalatRecord);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_Balata_TypeAndMakas);
            this.panel2.Controls.Add(this.tb_BalatFilter);
            this.panel2.Controls.Add(this.cb_BalatFilter);
            this.panel2.Controls.Add(this.cb_MakazenList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1088, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(236, 653);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 15;
            this.label1.Text = " المخزن";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 547);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 35);
            this.label3.TabIndex = 17;
            this.label3.Text = ": عدد البلاط";
            // 
            // lab_BalatRecord
            // 
            this.lab_BalatRecord.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_BalatRecord.Location = new System.Drawing.Point(72, 603);
            this.lab_BalatRecord.Name = "lab_BalatRecord";
            this.lab_BalatRecord.Size = new System.Drawing.Size(39, 35);
            this.lab_BalatRecord.TabIndex = 9;
            this.lab_BalatRecord.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = ": الفلاتر";
            // 
            // cb_Balata_TypeAndMakas
            // 
            this.cb_Balata_TypeAndMakas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Balata_TypeAndMakas.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Balata_TypeAndMakas.Location = new System.Drawing.Point(10, 359);
            this.cb_Balata_TypeAndMakas.Name = "cb_Balata_TypeAndMakas";
            this.cb_Balata_TypeAndMakas.Size = new System.Drawing.Size(207, 43);
            this.cb_Balata_TypeAndMakas.TabIndex = 12;
            this.cb_Balata_TypeAndMakas.SelectedIndexChanged += new System.EventHandler(this.cb_Balata_TypeAndMakas_SelectedIndexChanged_1);
            // 
            // tb_BalatFilter
            // 
            this.tb_BalatFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_BalatFilter.Location = new System.Drawing.Point(9, 361);
            this.tb_BalatFilter.Name = "tb_BalatFilter";
            this.tb_BalatFilter.Size = new System.Drawing.Size(207, 41);
            this.tb_BalatFilter.TabIndex = 14;
            this.tb_BalatFilter.TextChanged += new System.EventHandler(this.tb_BalatFilter_TextChanged_1);
            // 
            // cb_BalatFilter
            // 
            this.cb_BalatFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_BalatFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_BalatFilter.Items.AddRange(new object[] {
            "الجميع",
            "الكود",
            "النوع",
            "المقاس"});
            this.cb_BalatFilter.Location = new System.Drawing.Point(10, 311);
            this.cb_BalatFilter.Name = "cb_BalatFilter";
            this.cb_BalatFilter.Size = new System.Drawing.Size(206, 43);
            this.cb_BalatFilter.TabIndex = 13;
            this.cb_BalatFilter.SelectedIndexChanged += new System.EventHandler(this.cb_BalatFilter_SelectedIndexChanged_1);
            // 
            // cb_MakazenList
            // 
            this.cb_MakazenList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MakazenList.Font = new System.Drawing.Font("Tahoma", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_MakazenList.Location = new System.Drawing.Point(10, 135);
            this.cb_MakazenList.Name = "cb_MakazenList";
            this.cb_MakazenList.Size = new System.Drawing.Size(207, 42);
            this.cb_MakazenList.TabIndex = 11;
            this.cb_MakazenList.SelectedIndexChanged += new System.EventHandler(this.cb_MakazenList_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.uctl_BalataAddUpdate1);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabPage2.ImageIndex = 1;
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1410, 696);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "الأضافة و التعديل";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "checkbox-multiple-blank-line.png");
            this.imageList1.Images.SetKeyName(1, "function-add-line.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // contextMenuStrip_B
            // 
            this.contextMenuStrip_B.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip_B.Name = "contextMenuStrip_B";
            this.contextMenuStrip_B.Size = new System.Drawing.Size(61, 4);
            // 
            // gdgv_BalatList
            // 
            this.gdgv_BalatList.AllowUserToAddRows = false;
            this.gdgv_BalatList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gdgv_BalatList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gdgv_BalatList.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gdgv_BalatList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gdgv_BalatList.ColumnHeadersHeight = 40;
            this.gdgv_BalatList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gdgv_BalatList.DefaultCellStyle = dataGridViewCellStyle3;
            this.gdgv_BalatList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gdgv_BalatList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_BalatList.Location = new System.Drawing.Point(0, 0);
            this.gdgv_BalatList.Name = "gdgv_BalatList";
            this.gdgv_BalatList.ReadOnly = true;
            this.gdgv_BalatList.RowHeadersVisible = false;
            this.gdgv_BalatList.RowHeadersWidth = 51;
            this.gdgv_BalatList.RowTemplate.Height = 26;
            this.gdgv_BalatList.Size = new System.Drawing.Size(1088, 653);
            this.gdgv_BalatList.TabIndex = 52;
            this.gdgv_BalatList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_BalatList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gdgv_BalatList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gdgv_BalatList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gdgv_BalatList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gdgv_BalatList.ThemeStyle.BackColor = System.Drawing.Color.Gainsboro;
            this.gdgv_BalatList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gdgv_BalatList.ThemeStyle.HeaderStyle.Height = 40;
            this.gdgv_BalatList.ThemeStyle.ReadOnly = true;
            this.gdgv_BalatList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gdgv_BalatList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gdgv_BalatList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdgv_BalatList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gdgv_BalatList.ThemeStyle.RowsStyle.Height = 26;
            this.gdgv_BalatList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gdgv_BalatList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // uctl_BalataAddUpdate1
            // 
            this.uctl_BalataAddUpdate1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.uctl_BalataAddUpdate1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uctl_BalataAddUpdate1.Location = new System.Drawing.Point(30, 32);
            this.uctl_BalataAddUpdate1.Name = "uctl_BalataAddUpdate1";
            this.uctl_BalataAddUpdate1.Size = new System.Drawing.Size(1172, 629);
            this.uctl_BalataAddUpdate1.TabIndex = 0;
            // 
            // Uctl_Balats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "Uctl_Balats";
            this.Size = new System.Drawing.Size(1418, 739);
            this.Load += new System.EventHandler(this.Uctl_Balats_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdgv_BalatList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lab_BalatRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_B;
        private System.Windows.Forms.ComboBox cb_BalatFilter;
        private System.Windows.Forms.ComboBox cb_MakazenList;
        private System.Windows.Forms.TextBox tb_BalatFilter;
        private System.Windows.Forms.ComboBox cb_Balata_TypeAndMakas;
        private Uctl_BalataAddUpdate uctl_BalataAddUpdate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2DataGridView gdgv_BalatList;
    }
}
