﻿namespace OpenTools_V2._0
{
    partial class frmToolgruppeBearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToolgruppeBearbeiten));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDateien = new System.Windows.Forms.Label();
            this.bInternetseiteLöschen = new System.Windows.Forms.Button();
            this.listDateien = new System.Windows.Forms.ListBox();
            this.cmsDateien = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bInternetseiteHinzufügen = new System.Windows.Forms.Button();
            this.listOrdner = new System.Windows.Forms.ListBox();
            this.cmsOrdner = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOrdnerLöschen = new System.Windows.Forms.Button();
            this.listInternetseiten = new System.Windows.Forms.ListBox();
            this.cmsInternetseiten = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.hinzufügenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.bOrdnerHinzufügen = new System.Windows.Forms.Button();
            this.lbOrdner = new System.Windows.Forms.Label();
            this.bDateiEntfernen = new System.Windows.Forms.Button();
            this.lbInternetseiten = new System.Windows.Forms.Label();
            this.bDateiHinzufügen = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAbbrechen = new System.Windows.Forms.Button();
            this.bFertig = new System.Windows.Forms.Button();
            this.ofdDatei = new System.Windows.Forms.OpenFileDialog();
            this.fbdOrdner = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.cmsDateien.SuspendLayout();
            this.cmsOrdner.SuspendLayout();
            this.cmsInternetseiten.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbDateien);
            this.panel1.Controls.Add(this.bInternetseiteLöschen);
            this.panel1.Controls.Add(this.listDateien);
            this.panel1.Controls.Add(this.bInternetseiteHinzufügen);
            this.panel1.Controls.Add(this.listOrdner);
            this.panel1.Controls.Add(this.bOrdnerLöschen);
            this.panel1.Controls.Add(this.listInternetseiten);
            this.panel1.Controls.Add(this.bOrdnerHinzufügen);
            this.panel1.Controls.Add(this.lbOrdner);
            this.panel1.Controls.Add(this.bDateiEntfernen);
            this.panel1.Controls.Add(this.lbInternetseiten);
            this.panel1.Controls.Add(this.bDateiHinzufügen);
            this.panel1.Location = new System.Drawing.Point(15, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 259);
            this.panel1.TabIndex = 21;
            // 
            // lbDateien
            // 
            this.lbDateien.AutoSize = true;
            this.lbDateien.Location = new System.Drawing.Point(1, 0);
            this.lbDateien.Name = "lbDateien";
            this.lbDateien.Size = new System.Drawing.Size(47, 13);
            this.lbDateien.TabIndex = 5;
            this.lbDateien.Text = "Dateien:";
            // 
            // bInternetseiteLöschen
            // 
            this.bInternetseiteLöschen.Location = new System.Drawing.Point(576, 234);
            this.bInternetseiteLöschen.Name = "bInternetseiteLöschen";
            this.bInternetseiteLöschen.Size = new System.Drawing.Size(75, 23);
            this.bInternetseiteLöschen.TabIndex = 15;
            this.bInternetseiteLöschen.Text = "Entfernen";
            this.toolTip1.SetToolTip(this.bInternetseiteLöschen, "Internetseite löschen (Entf)");
            this.bInternetseiteLöschen.UseVisualStyleBackColor = true;
            this.bInternetseiteLöschen.Click += new System.EventHandler(this.bInternetseiteLöschen_Click);
            // 
            // listDateien
            // 
            this.listDateien.AllowDrop = true;
            this.listDateien.ContextMenuStrip = this.cmsDateien;
            this.listDateien.FormattingEnabled = true;
            this.listDateien.Location = new System.Drawing.Point(1, 16);
            this.listDateien.Name = "listDateien";
            this.listDateien.Size = new System.Drawing.Size(213, 212);
            this.listDateien.TabIndex = 4;
            this.listDateien.DragDrop += new System.Windows.Forms.DragEventHandler(this.listDateien_DragDrop);
            this.listDateien.DragEnter += new System.Windows.Forms.DragEventHandler(this.listDateien_DragEnter);
            // 
            // cmsDateien
            // 
            this.cmsDateien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.entfernenToolStripMenuItem});
            this.cmsDateien.Name = "cmsDateien";
            this.cmsDateien.Size = new System.Drawing.Size(137, 48);
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // bInternetseiteHinzufügen
            // 
            this.bInternetseiteHinzufügen.Location = new System.Drawing.Point(495, 234);
            this.bInternetseiteHinzufügen.Name = "bInternetseiteHinzufügen";
            this.bInternetseiteHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bInternetseiteHinzufügen.TabIndex = 14;
            this.bInternetseiteHinzufügen.Text = "Hinzufügen";
            this.toolTip1.SetToolTip(this.bInternetseiteHinzufügen, "Internetseite hinzufügen (Strg + I)");
            this.bInternetseiteHinzufügen.UseVisualStyleBackColor = true;
            this.bInternetseiteHinzufügen.Click += new System.EventHandler(this.bInternetseiteHinzufügen_Click);
            // 
            // listOrdner
            // 
            this.listOrdner.AllowDrop = true;
            this.listOrdner.ContextMenuStrip = this.cmsOrdner;
            this.listOrdner.FormattingEnabled = true;
            this.listOrdner.Location = new System.Drawing.Point(219, 16);
            this.listOrdner.Name = "listOrdner";
            this.listOrdner.Size = new System.Drawing.Size(213, 212);
            this.listOrdner.TabIndex = 6;
            this.listOrdner.DragDrop += new System.Windows.Forms.DragEventHandler(this.listOrdner_DragDrop);
            this.listOrdner.DragEnter += new System.Windows.Forms.DragEventHandler(this.listOrdner_DragEnter);
            // 
            // cmsOrdner
            // 
            this.cmsOrdner.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.entfernenToolStripMenuItem1});
            this.cmsOrdner.Name = "cmsDateien";
            this.cmsOrdner.Size = new System.Drawing.Size(137, 48);
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem1_Click);
            // 
            // entfernenToolStripMenuItem1
            // 
            this.entfernenToolStripMenuItem1.Name = "entfernenToolStripMenuItem1";
            this.entfernenToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.entfernenToolStripMenuItem1.Text = "Entfernen";
            this.entfernenToolStripMenuItem1.Click += new System.EventHandler(this.entfernenToolStripMenuItem1_Click);
            // 
            // bOrdnerLöschen
            // 
            this.bOrdnerLöschen.Location = new System.Drawing.Point(357, 234);
            this.bOrdnerLöschen.Name = "bOrdnerLöschen";
            this.bOrdnerLöschen.Size = new System.Drawing.Size(75, 23);
            this.bOrdnerLöschen.TabIndex = 13;
            this.bOrdnerLöschen.Text = "Entfernen";
            this.toolTip1.SetToolTip(this.bOrdnerLöschen, "Ordner löschen (Entf)");
            this.bOrdnerLöschen.UseVisualStyleBackColor = true;
            this.bOrdnerLöschen.Click += new System.EventHandler(this.bOrdnerLöschen_Click);
            // 
            // listInternetseiten
            // 
            this.listInternetseiten.AllowDrop = true;
            this.listInternetseiten.ContextMenuStrip = this.cmsInternetseiten;
            this.listInternetseiten.FormattingEnabled = true;
            this.listInternetseiten.Location = new System.Drawing.Point(438, 16);
            this.listInternetseiten.Name = "listInternetseiten";
            this.listInternetseiten.Size = new System.Drawing.Size(213, 212);
            this.listInternetseiten.TabIndex = 7;
            // 
            // cmsInternetseiten
            // 
            this.cmsInternetseiten.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem2,
            this.entfernenToolStripMenuItem2});
            this.cmsInternetseiten.Name = "cmsDateien";
            this.cmsInternetseiten.Size = new System.Drawing.Size(137, 48);
            // 
            // hinzufügenToolStripMenuItem2
            // 
            this.hinzufügenToolStripMenuItem2.Name = "hinzufügenToolStripMenuItem2";
            this.hinzufügenToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem2.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem2.Click += new System.EventHandler(this.hinzufügenToolStripMenuItem2_Click);
            // 
            // entfernenToolStripMenuItem2
            // 
            this.entfernenToolStripMenuItem2.Name = "entfernenToolStripMenuItem2";
            this.entfernenToolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.entfernenToolStripMenuItem2.Text = "Entfernen";
            this.entfernenToolStripMenuItem2.Click += new System.EventHandler(this.entfernenToolStripMenuItem2_Click);
            // 
            // bOrdnerHinzufügen
            // 
            this.bOrdnerHinzufügen.Location = new System.Drawing.Point(276, 234);
            this.bOrdnerHinzufügen.Name = "bOrdnerHinzufügen";
            this.bOrdnerHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bOrdnerHinzufügen.TabIndex = 12;
            this.bOrdnerHinzufügen.Text = "Hinzufügen";
            this.toolTip1.SetToolTip(this.bOrdnerHinzufügen, "Ordner hinzufügen (Strg + O)");
            this.bOrdnerHinzufügen.UseVisualStyleBackColor = true;
            this.bOrdnerHinzufügen.Click += new System.EventHandler(this.bOrdnerHinzufügen_Click);
            // 
            // lbOrdner
            // 
            this.lbOrdner.AutoSize = true;
            this.lbOrdner.Location = new System.Drawing.Point(219, 0);
            this.lbOrdner.Name = "lbOrdner";
            this.lbOrdner.Size = new System.Drawing.Size(42, 13);
            this.lbOrdner.TabIndex = 8;
            this.lbOrdner.Text = "Ordner:";
            // 
            // bDateiEntfernen
            // 
            this.bDateiEntfernen.Location = new System.Drawing.Point(138, 234);
            this.bDateiEntfernen.Name = "bDateiEntfernen";
            this.bDateiEntfernen.Size = new System.Drawing.Size(75, 23);
            this.bDateiEntfernen.TabIndex = 11;
            this.bDateiEntfernen.Text = "Entfernen";
            this.toolTip1.SetToolTip(this.bDateiEntfernen, "Datei löschen (Entf)");
            this.bDateiEntfernen.UseVisualStyleBackColor = true;
            this.bDateiEntfernen.Click += new System.EventHandler(this.bDateiEntfernen_Click);
            // 
            // lbInternetseiten
            // 
            this.lbInternetseiten.AutoSize = true;
            this.lbInternetseiten.Location = new System.Drawing.Point(438, 0);
            this.lbInternetseiten.Name = "lbInternetseiten";
            this.lbInternetseiten.Size = new System.Drawing.Size(74, 13);
            this.lbInternetseiten.TabIndex = 9;
            this.lbInternetseiten.Text = "Internetseiten:";
            // 
            // bDateiHinzufügen
            // 
            this.bDateiHinzufügen.Location = new System.Drawing.Point(57, 234);
            this.bDateiHinzufügen.Name = "bDateiHinzufügen";
            this.bDateiHinzufügen.Size = new System.Drawing.Size(75, 23);
            this.bDateiHinzufügen.TabIndex = 10;
            this.bDateiHinzufügen.Text = "Hinzufügen";
            this.toolTip1.SetToolTip(this.bDateiHinzufügen, "Datei hinzufügen (Strg + D)");
            this.bDateiHinzufügen.UseVisualStyleBackColor = true;
            this.bDateiHinzufügen.Click += new System.EventHandler(this.bDateiHinzufügen_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(12, 9);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 20;
            this.lbName.Text = "Name:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(56, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(610, 20);
            this.textBox1.TabIndex = 19;
            // 
            // bAbbrechen
            // 
            this.bAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bAbbrechen.Location = new System.Drawing.Point(591, 297);
            this.bAbbrechen.Name = "bAbbrechen";
            this.bAbbrechen.Size = new System.Drawing.Size(75, 23);
            this.bAbbrechen.TabIndex = 18;
            this.bAbbrechen.Text = "Abbrechen";
            this.bAbbrechen.UseVisualStyleBackColor = true;
            // 
            // bFertig
            // 
            this.bFertig.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bFertig.Location = new System.Drawing.Point(510, 297);
            this.bFertig.Name = "bFertig";
            this.bFertig.Size = new System.Drawing.Size(75, 23);
            this.bFertig.TabIndex = 17;
            this.bFertig.Text = "Fertig";
            this.bFertig.UseVisualStyleBackColor = true;
            this.bFertig.Click += new System.EventHandler(this.bFertig_Click);
            // 
            // ofdDatei
            // 
            this.ofdDatei.FileName = "openFileDialog1";
            // 
            // frmToolgruppeBearbeiten
            // 
            this.AcceptButton = this.bFertig;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.bAbbrechen;
            this.ClientSize = new System.Drawing.Size(669, 323);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bAbbrechen);
            this.Controls.Add(this.bFertig);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmToolgruppeBearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenTools V2.0 - Bearbeiten";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmToolgruppeBearbeiten_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmsDateien.ResumeLayout(false);
            this.cmsOrdner.ResumeLayout(false);
            this.cmsInternetseiten.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDateien;
        private System.Windows.Forms.Button bInternetseiteLöschen;
        private System.Windows.Forms.ListBox listDateien;
        private System.Windows.Forms.Button bInternetseiteHinzufügen;
        private System.Windows.Forms.ListBox listOrdner;
        private System.Windows.Forms.Button bOrdnerLöschen;
        private System.Windows.Forms.ListBox listInternetseiten;
        private System.Windows.Forms.Button bOrdnerHinzufügen;
        private System.Windows.Forms.Label lbOrdner;
        private System.Windows.Forms.Button bDateiEntfernen;
        private System.Windows.Forms.Label lbInternetseiten;
        private System.Windows.Forms.Button bDateiHinzufügen;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAbbrechen;
        private System.Windows.Forms.Button bFertig;
        private System.Windows.Forms.ContextMenuStrip cmsDateien;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip cmsOrdner;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip cmsInternetseiten;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem2;
        private System.Windows.Forms.OpenFileDialog ofdDatei;
        private System.Windows.Forms.FolderBrowserDialog fbdOrdner;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}