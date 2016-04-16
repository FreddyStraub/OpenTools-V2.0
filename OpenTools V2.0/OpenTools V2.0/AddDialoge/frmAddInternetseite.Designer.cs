namespace OpenTools_V2._0.AddDialoge
{
    partial class frmAddInternetseite
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.bFertig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAbbrechen.Location = new System.Drawing.Point(394, 36);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechen.TabIndex = 3;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            // 
            // bFertig
            // 
            this.bFertig.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bFertig.Location = new System.Drawing.Point(313, 36);
            this.bFertig.Name = "bFertig";
            this.bFertig.Size = new System.Drawing.Size(75, 23);
            this.bFertig.TabIndex = 2;
            this.bFertig.Text = "Fertig";
            this.bFertig.UseVisualStyleBackColor = true;
            this.bFertig.Click += new System.EventHandler(this.bFertig_Click);
            // 
            // frmAddInternetseite
            // 
            this.AcceptButton = this.bFertig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bAbbrechen;
            this.ClientSize = new System.Drawing.Size(474, 64);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bFertig);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmAddInternetseite";
            this.Text = "Internetseite hinzufügen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAbbrechen;
        private System.Windows.Forms.Button bFertig;
    }
}