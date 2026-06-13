namespace Sahab_Balat.Setting
{
    partial class Uctl_E3dadat
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
            this.uctl_Setting1 = new Sahab_Balat.Setting.uctl_Setting();
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
            this.lab_Adkar.Size = new System.Drawing.Size(1316, 79);
            this.lab_Adkar.TabIndex = 20;
            this.lab_Adkar.Text = "منظومة  سحاب لسرميك و البرسلين";
            this.lab_Adkar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uctl_Setting1
            // 
            this.uctl_Setting1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uctl_Setting1.Location = new System.Drawing.Point(0, 79);
            this.uctl_Setting1.Name = "uctl_Setting1";
            this.uctl_Setting1.Size = new System.Drawing.Size(1316, 705);
            this.uctl_Setting1.TabIndex = 21;
            // 
            // Uctl_E3dadat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uctl_Setting1);
            this.Controls.Add(this.lab_Adkar);
            this.Name = "Uctl_E3dadat";
            this.Size = new System.Drawing.Size(1316, 784);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lab_Adkar;
        private uctl_Setting uctl_Setting1;
    }
}
