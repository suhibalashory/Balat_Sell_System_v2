namespace Sahab_Balat.Mabiat
{
    partial class Uctl_Mabiat
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cb_Filter = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.عرضالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.حذفالفاتورةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tb_FilterBy = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_faltara = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_To = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Search = new System.Windows.Forms.Button();
            this.dtp_From = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_Mabiat = new Guna.UI2.WinForms.Guna2DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mabiat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Filter
            // 
            this.cb_Filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Filter.FormattingEnabled = true;
            this.cb_Filter.Items.AddRange(new object[] {
            "اسم العميل",
            "رقم العميل"});
            this.cb_Filter.Location = new System.Drawing.Point(37, 545);
            this.cb_Filter.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Filter.Name = "cb_Filter";
            this.cb_Filter.Size = new System.Drawing.Size(268, 41);
            this.cb_Filter.TabIndex = 1;
            this.cb_Filter.SelectedIndexChanged += new System.EventHandler(this.cb_Filter_SelectedIndexChanged_1);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عرضالفاتورةToolStripMenuItem,
            this.toolStripMenuItem1,
            this.حذفالفاتورةToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 58);
            // 
            // عرضالفاتورةToolStripMenuItem
            // 
            this.عرضالفاتورةToolStripMenuItem.Name = "عرضالفاتورةToolStripMenuItem";
            this.عرضالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.عرضالفاتورةToolStripMenuItem.Text = "عرض الفاتورة";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
            // 
            // حذفالفاتورةToolStripMenuItem
            // 
            this.حذفالفاتورةToolStripMenuItem.Name = "حذفالفاتورةToolStripMenuItem";
            this.حذفالفاتورةToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.حذفالفاتورةToolStripMenuItem.Text = "حذف الفاتورة";
            // 
            // tb_FilterBy
            // 
            this.tb_FilterBy.Location = new System.Drawing.Point(37, 602);
            this.tb_FilterBy.Margin = new System.Windows.Forms.Padding(4);
            this.tb_FilterBy.Name = "tb_FilterBy";
            this.tb_FilterBy.Size = new System.Drawing.Size(268, 40);
            this.tb_FilterBy.TabIndex = 2;
            this.tb_FilterBy.TextChanged += new System.EventHandler(this.tb_FilterBy_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_faltara);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtp_To);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Search);
            this.groupBox1.Controls.Add(this.tb_FilterBy);
            this.groupBox1.Controls.Add(this.dtp_From);
            this.groupBox1.Controls.Add(this.cb_Filter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(851, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 762);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "فلاتر البحث ";
            // 
            // btn_faltara
            // 
            this.btn_faltara.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_faltara.Location = new System.Drawing.Point(48, 341);
            this.btn_faltara.Margin = new System.Windows.Forms.Padding(4);
            this.btn_faltara.Name = "btn_faltara";
            this.btn_faltara.Size = new System.Drawing.Size(243, 50);
            this.btn_faltara.TabIndex = 32;
            this.btn_faltara.Text = "فلترة";
            this.btn_faltara.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 34);
            this.label2.TabIndex = 31;
            this.label2.Text = "الفترة الزمنية ";
            // 
            // dtp_To
            // 
            this.dtp_To.BorderRadius = 8;
            this.dtp_To.BorderThickness = 2;
            this.dtp_To.Checked = true;
            this.dtp_To.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtp_To.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_To.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_To.Location = new System.Drawing.Point(48, 260);
            this.dtp_To.MaxDate = new System.DateTime(2077, 11, 16, 23, 59, 59, 999);
            this.dtp_To.MinDate = new System.DateTime(1900, 4, 30, 0, 0, 0, 0);
            this.dtp_To.Name = "dtp_To";
            this.dtp_To.Size = new System.Drawing.Size(203, 36);
            this.dtp_To.TabIndex = 29;
            this.dtp_To.Value = new System.DateTime(2025, 12, 19, 16, 35, 36, 406);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(113, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 40);
            this.label1.TabIndex = 30;
            this.label1.Text = "نوع الفلتر";
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(74, 678);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(205, 50);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "بحث ";
            this.btn_Search.UseVisualStyleBackColor = true;
            // 
            // dtp_From
            // 
            this.dtp_From.BorderRadius = 8;
            this.dtp_From.BorderThickness = 2;
            this.dtp_From.Checked = true;
            this.dtp_From.FillColor = System.Drawing.SystemColors.MenuHighlight;
            this.dtp_From.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_From.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_From.Location = new System.Drawing.Point(48, 199);
            this.dtp_From.MaxDate = new System.DateTime(2077, 11, 16, 23, 59, 59, 999);
            this.dtp_From.MinDate = new System.DateTime(1900, 4, 30, 0, 0, 0, 0);
            this.dtp_From.Name = "dtp_From";
            this.dtp_From.Size = new System.Drawing.Size(203, 36);
            this.dtp_From.TabIndex = 28;
            this.dtp_From.Value = new System.DateTime(2025, 12, 19, 16, 35, 36, 406);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(272, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = ": من ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 260);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = ": الي";
            // 
            // dgv_Mabiat
            // 
            this.dgv_Mabiat.AllowUserToAddRows = false;
            this.dgv_Mabiat.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_Mabiat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Mabiat.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Mabiat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Mabiat.ColumnHeadersHeight = 40;
            this.dgv_Mabiat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Mabiat.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_Mabiat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Mabiat.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Mabiat.Location = new System.Drawing.Point(0, 0);
            this.dgv_Mabiat.Name = "dgv_Mabiat";
            this.dgv_Mabiat.ReadOnly = true;
            this.dgv_Mabiat.RowHeadersVisible = false;
            this.dgv_Mabiat.RowHeadersWidth = 51;
            this.dgv_Mabiat.RowTemplate.Height = 26;
            this.dgv_Mabiat.Size = new System.Drawing.Size(851, 762);
            this.dgv_Mabiat.TabIndex = 11;
            this.dgv_Mabiat.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Mabiat.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_Mabiat.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_Mabiat.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_Mabiat.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_Mabiat.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Mabiat.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_Mabiat.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_Mabiat.ThemeStyle.ReadOnly = true;
            this.dgv_Mabiat.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Mabiat.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_Mabiat.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 8F);
            this.dgv_Mabiat.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_Mabiat.ThemeStyle.RowsStyle.Height = 26;
            this.dgv_Mabiat.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_Mabiat.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Uctl_Mabiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgv_Mabiat);
            this.Controls.Add(this.groupBox1);
            this.Name = "Uctl_Mabiat";
            this.Size = new System.Drawing.Size(1200, 762);
            this.Load += new System.EventHandler(this.Uctl_Mabiat_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Mabiat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Filter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عرضالفاتورةToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem حذفالفاتورةToolStripMenuItem;
        private System.Windows.Forms.TextBox tb_FilterBy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_Mabiat;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_To;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_From;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_faltara;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
