﻿namespace App.UI.Desktop
{
    partial class MDIPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteDeTracksConRepositoriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem,
            this.reporteDeTracksConRepositoriosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // reporteDeTrakcsConRepositoriosToolStripMenuItem
            // 
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem.Name = "reporteDeTrakcsConRepositoriosToolStripMenuItem";
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem.Text = "Reporte de Tracks con EF";
            this.reporteDeTrakcsConRepositoriosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeTrakcsConRepositoriosToolStripMenuItem_Click);
            // 
            // reporteDeTracksConRepositoriosToolStripMenuItem
            // 
            this.reporteDeTracksConRepositoriosToolStripMenuItem.Name = "reporteDeTracksConRepositoriosToolStripMenuItem";
            this.reporteDeTracksConRepositoriosToolStripMenuItem.Size = new System.Drawing.Size(258, 22);
            this.reporteDeTracksConRepositoriosToolStripMenuItem.Text = "Reporte de Tracks con Repositorios";
            this.reporteDeTracksConRepositoriosToolStripMenuItem.Click += new System.EventHandler(this.reporteDeTracksConRepositoriosToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.Text = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeTrakcsConRepositoriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteDeTracksConRepositoriosToolStripMenuItem;
    }
}