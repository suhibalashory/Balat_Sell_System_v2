namespace Sahab_Balat._Mabiat
{
    partial class uctl_Almabiat
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
            this.lab_Adkar = new System.Windows.Forms.Label();
            this.uctl_Mabiat1 = new Sahab_Balat.Mabiat.Uctl_Mabiat();
            this.SuspendLayout();
            // 
            // lab_Adkar
            // 
            this.lab_Adkar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lab_Adkar.Dock = System.Windows.Forms.DockStyle.Top;
            this.lab_Adkar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lab_Adkar.Font = new System.Drawing.Font("Andalus", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Adkar.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lab_Adkar.Location = new System.Drawing.Point(0, 0);
            this.lab_Adkar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_Adkar.Name = "lab_Adkar";
            this.lab_Adkar.Size = new System.Drawing.Size(1531, 79);
            this.lab_Adkar.TabIndex = 20;
            this.lab_Adkar.Text = "منظومة  سحاب لسرميك و البرسلين";
            this.lab_Adkar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uctl_Mabiat1
            // 
            this.uctl_Mabiat1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctl_Mabiat1.Location = new System.Drawing.Point(0, 79);
            this.uctl_Mabiat1.Name = "uctl_Mabiat1";
            this.uctl_Mabiat1.Size = new System.Drawing.Size(1531, 789);
            this.uctl_Mabiat1.TabIndex = 21;
            // 
            // uctl_Almabiat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uctl_Mabiat1);
            this.Controls.Add(this.lab_Adkar);
            this.Name = "uctl_Almabiat";
            this.Size = new System.Drawing.Size(1531, 868);
            this.Load += new System.EventHandler(this.uctl_Almabiat_Load);
            this.Resize += new System.EventHandler(this.uctl_Almabiat_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_Adkar;
        private Mabiat.Uctl_Mabiat uctl_Mabiat1;
    }
}
