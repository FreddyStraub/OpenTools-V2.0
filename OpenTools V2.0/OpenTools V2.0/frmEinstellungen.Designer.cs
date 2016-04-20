namespace OpenTools_V2._0
{
    partial class frmEinstellungen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEinstellungen));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bBrowse = new System.Windows.Forms.Button();
            this.fbdEinstellungen = new System.Windows.Forms.FolderBrowserDialog();
            this.cmsBrose = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ordnerÖffnenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bSpeichern = new System.Windows.Forms.Button();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.cmsBrose.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.ContextMenuStrip = this.cmsBrose;
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bBrowse
            // 
            this.bBrowse.ContextMenuStrip = this.cmsBrose;
            this.bBrowse.Location = new System.Drawing.Point(337, 10);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(29, 23);
            this.bBrowse.TabIndex = 1;
            this.bBrowse.Text = "...";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmsBrose
            // 
            this.cmsBrose.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordnerÖffnenToolStripMenuItem});
            this.cmsBrose.Name = "cmsBrose";
            this.cmsBrose.Size = new System.Drawing.Size(150, 26);
            // 
            // ordnerÖffnenToolStripMenuItem
            // 
            this.ordnerÖffnenToolStripMenuItem.Name = "ordnerÖffnenToolStripMenuItem";
            this.ordnerÖffnenToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.ordnerÖffnenToolStripMenuItem.Text = "Ordner öffnen";
            this.ordnerÖffnenToolStripMenuItem.Click += new System.EventHandler(this.ordnerÖffnenToolStripMenuItem_Click);
            // 
            // bSpeichern
            // 
            this.bSpeichern.Location = new System.Drawing.Point(210, 239);
            this.bSpeichern.Name = "bSpeichern";
            this.bSpeichern.Size = new System.Drawing.Size(75, 23);
            this.bSpeichern.TabIndex = 3;
            this.bSpeichern.Text = "Speichern";
            this.bSpeichern.UseVisualStyleBackColor = true;
            this.bSpeichern.Click += new System.EventHandler(this.bSpeichern_Click);
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAbbrechen.Location = new System.Drawing.Point(291, 239);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechen.TabIndex = 4;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            // 
            // frmEinstellungen
            // 
            this.AcceptButton = this.bSpeichern;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bAbbrechen;
            this.ClientSize = new System.Drawing.Size(376, 309);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bSpeichern);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEinstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTools V2.0 - Einstellungen";
            this.Load += new System.EventHandler(this.frmEinstellungen_Load);
            this.cmsBrose.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.FolderBrowserDialog fbdEinstellungen;
        private System.Windows.Forms.ContextMenuStrip cmsBrose;
        private System.Windows.Forms.ToolStripMenuItem ordnerÖffnenToolStripMenuItem;
        private System.Windows.Forms.Button bSpeichern;
        private System.Windows.Forms.Button bAbbrechen;
    }
}