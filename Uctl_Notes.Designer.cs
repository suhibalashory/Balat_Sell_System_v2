namespace Sahab_Balat
{
    partial class Uctl_Notes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_Note = new System.Windows.Forms.TextBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.gbtn_AddNote = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_Notes = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.groupBox1.Controls.Add(this.tb_Note);
            this.groupBox1.Controls.Add(this.guna2Button2);
            this.groupBox1.Controls.Add(this.gbtn_AddNote);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(368, 136);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // tb_Note
            // 
            this.tb_Note.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Note.Location = new System.Drawing.Point(6, 71);
            this.tb_Note.Multiline = true;
            this.tb_Note.Name = "tb_Note";
            this.tb_Note.Size = new System.Drawing.Size(289, 59);
            this.tb_Note.TabIndex = 3;
            this.tb_Note.Text = "ssss";
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 10;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.Black;
            this.guna2Button2.Location = new System.Drawing.Point(6, 9);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(95, 39);
            this.guna2Button2.TabIndex = 2;
            this.guna2Button2.Text = "حذف الكل";
            // 
            // gbtn_AddNote
            // 
            this.gbtn_AddNote.BorderRadius = 10;
            this.gbtn_AddNote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_AddNote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gbtn_AddNote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gbtn_AddNote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gbtn_AddNote.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbtn_AddNote.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gbtn_AddNote.Location = new System.Drawing.Point(301, 71);
            this.gbtn_AddNote.Name = "gbtn_AddNote";
            this.gbtn_AddNote.Size = new System.Drawing.Size(61, 33);
            this.gbtn_AddNote.TabIndex = 1;
            this.gbtn_AddNote.Text = "أظافة";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "-: الملاحظات ";
            // 
            // tb_Notes
            // 
            this.tb_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Notes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Notes.Location = new System.Drawing.Point(0, 136);
            this.tb_Notes.Multiline = true;
            this.tb_Notes.Name = "tb_Notes";
            this.tb_Notes.Size = new System.Drawing.Size(368, 530);
            this.tb_Notes.TabIndex = 4;
            // 
            // Uctl_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_Notes);
            this.Controls.Add(this.groupBox1);
            this.Name = "Uctl_Notes";
            this.Size = new System.Drawing.Size(368, 666);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button gbtn_AddNote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Note;
        private System.Windows.Forms.TextBox tb_Notes;
    }
}
