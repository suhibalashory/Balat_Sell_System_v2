namespace Alkirat2
{
    partial class frmShowFatora
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
            this.uctl_formshowing1 = new Sahab_Balat.Controls.uctl_formshowing();
            this.SuspendLayout();
            // 
            // uctl_formshowing1
            // 
            this.uctl_formshowing1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctl_formshowing1.Location = new System.Drawing.Point(0, 0);
            this.uctl_formshowing1.Name = "uctl_formshowing1";
            this.uctl_formshowing1.Size = new System.Drawing.Size(901, 759);
            this.uctl_formshowing1.TabIndex = 0;
            // 
            // frmShowFatora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 759);
            this.Controls.Add(this.uctl_formshowing1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShowFatora";
            this.Text = "frmShowFatora";
            this.Load += new System.EventHandler(this.frmShowFatora_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sahab_Balat.Controls.uctl_formshowing uctl_formshowing1;
    }
}