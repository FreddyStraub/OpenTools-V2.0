namespace OpenTools_V2._0
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.listToolgruppen = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbToolgruppen = new System.Windows.Forms.Label();
            this.llbWolf066LP = new System.Windows.Forms.LinkLabel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listToolgruppen
            // 
            this.listToolgruppen.FormattingEnabled = true;
            this.listToolgruppen.Location = new System.Drawing.Point(14, 47);
            this.listToolgruppen.Name = "listToolgruppen";
            this.listToolgruppen.Size = new System.Drawing.Size(342, 199);
            this.listToolgruppen.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuToolStripMenuItem,
            this.bearbeiToolStripMenuItem,
            this.löschenToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.beendenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // neuToolStripMenuItem
            // 
            this.neuToolStripMenuItem.Name = "neuToolStripMenuItem";
            this.neuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.neuToolStripMenuItem.Text = "Neu...";
            // 
            // bearbeiToolStripMenuItem
            // 
            this.bearbeiToolStripMenuItem.Name = "bearbeiToolStripMenuItem";
            this.bearbeiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bearbeiToolStripMenuItem.Text = "Bearbeiten...";
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.löschenToolStripMenuItem.Text = "Löschen";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen...";
            // 
            // beendenToolStripMenuItem
            // 
            this.beendenToolStripMenuItem.Name = "beendenToolStripMenuItem";
            this.beendenToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.beendenToolStripMenuItem.Text = "Beenden";
            this.beendenToolStripMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // lbToolgruppen
            // 
            this.lbToolgruppen.AutoSize = true;
            this.lbToolgruppen.Location = new System.Drawing.Point(11, 28);
            this.lbToolgruppen.Name = "lbToolgruppen";
            this.lbToolgruppen.Size = new System.Drawing.Size(70, 13);
            this.lbToolgruppen.TabIndex = 3;
            this.lbToolgruppen.Text = "Toolgruppen:";
            // 
            // llbWolf066LP
            // 
            this.llbWolf066LP.AutoSize = true;
            this.llbWolf066LP.Location = new System.Drawing.Point(283, 249);
            this.llbWolf066LP.Name = "llbWolf066LP";
            this.llbWolf066LP.Size = new System.Drawing.Size(74, 13);
            this.llbWolf066LP.TabIndex = 4;
            this.llbWolf066LP.TabStop = true;
            this.llbWolf066LP.Text = "by Wolf066LP";
            this.llbWolf066LP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbWolf066LP_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 269);
            this.Controls.Add(this.llbWolf066LP);
            this.Controls.Add(this.lbToolgruppen);
            this.Controls.Add(this.listToolgruppen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTools V2.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listToolgruppen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem neuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bearbeiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem löschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beendenToolStripMenuItem;
        private System.Windows.Forms.Label lbToolgruppen;
        private System.Windows.Forms.LinkLabel llbWolf066LP;
    }
}

