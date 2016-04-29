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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ContextMenuStrip cmsMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.desktopverknüpfungErstellenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolgruppen = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.neuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bearbeiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.löschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbToolgruppen = new System.Windows.Forms.Label();
            this.llbWolf066LP = new System.Windows.Forms.LinkLabel();
            cmsMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            cmsMain.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmsMain
            // 
            cmsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.desktopverknüpfungErstellenToolStripMenuItem,
            this.toolStripSeparator1,
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            cmsMain.Name = "cmsMain";
            cmsMain.Size = new System.Drawing.Size(233, 76);
            // 
            // desktopverknüpfungErstellenToolStripMenuItem
            // 
            this.desktopverknüpfungErstellenToolStripMenuItem.Name = "desktopverknüpfungErstellenToolStripMenuItem";
            this.desktopverknüpfungErstellenToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.desktopverknüpfungErstellenToolStripMenuItem.Text = "Desktopverknüpfung erstellen";
            this.desktopverknüpfungErstellenToolStripMenuItem.Click += new System.EventHandler(this.desktopverknüpfungErstellenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(229, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItem1.Text = "Als Autpstartgruppe festelgen";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(232, 22);
            this.toolStripMenuItem2.Text = "Autpstartgruppe entfernen";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // listToolgruppen
            // 
            this.listToolgruppen.ContextMenuStrip = cmsMain;
            this.listToolgruppen.FormattingEnabled = true;
            this.listToolgruppen.Location = new System.Drawing.Point(14, 47);
            this.listToolgruppen.Name = "listToolgruppen";
            this.listToolgruppen.Size = new System.Drawing.Size(342, 199);
            this.listToolgruppen.TabIndex = 1;
            this.listToolgruppen.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listToolgruppen_MouseDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
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
            this.neuToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // bearbeiToolStripMenuItem
            // 
            this.bearbeiToolStripMenuItem.Name = "bearbeiToolStripMenuItem";
            this.bearbeiToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.bearbeiToolStripMenuItem.Text = "Bearbeiten...";
            this.bearbeiToolStripMenuItem.Click += new System.EventHandler(this.bearbeiToolStripMenuItem_Click);
            // 
            // löschenToolStripMenuItem
            // 
            this.löschenToolStripMenuItem.Name = "löschenToolStripMenuItem";
            this.löschenToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.löschenToolStripMenuItem.Text = "Löschen";
            this.löschenToolStripMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen...";
            this.einstellungenToolStripMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            this.einstellungenToolStripMenuItem.MouseDown += new System.Windows.Forms.MouseEventHandler(this.einstellungenToolStripMenuItem_MouseDown);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTools V2.0";
            this.Activated += new System.EventHandler(this.frmMain_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            cmsMain.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem desktopverknüpfungErstellenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

