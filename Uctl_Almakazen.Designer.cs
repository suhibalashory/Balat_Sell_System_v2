namespace Sahab_Balat.Makazen
{
    partial class Uctl_Almakazen
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
            this.uctl_Makazen1 = new Sahab_Balat.Makazen.Uctl_Makazen();
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
            this.lab_Adkar.Size = new System.Drawing.Size(1144, 79);
            this.lab_Adkar.TabIndex = 21;
            this.lab_Adkar.Text = "منظومة  سحاب لسرميك و البرسلين";
            this.lab_Adkar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uctl_Makazen1
            // 
            this.uctl_Makazen1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctl_Makazen1.Location = new System.Drawing.Point(0, 79);
            this.uctl_Makazen1.Name = "uctl_Makazen1";
            this.uctl_Makazen1.Size = new System.Drawing.Size(1144, 650);
            this.uctl_Makazen1.TabIndex = 22;
            // 
            // Uctl_Almakazen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uctl_Makazen1);
            this.Controls.Add(this.lab_Adkar);
            this.Name = "Uctl_Almakazen";
            this.Size = new System.Drawing.Size(1144, 729);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_Adkar;
        private Uctl_Makazen uctl_Makazen1;
    }
}
