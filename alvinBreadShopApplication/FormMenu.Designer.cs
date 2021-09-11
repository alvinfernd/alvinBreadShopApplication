﻿
namespace alvinBreadShopApplication
{
    partial class FormMenu
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
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewVariantToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayAllBreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madeTheBreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellTheBreadsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.processToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(451, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewVariantToolStripMenuItem});
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // addNewVariantToolStripMenuItem
            // 
            this.addNewVariantToolStripMenuItem.Name = "addNewVariantToolStripMenuItem";
            this.addNewVariantToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addNewVariantToolStripMenuItem.Text = "Add New Variant";
            this.addNewVariantToolStripMenuItem.Click += new System.EventHandler(this.addNewVariantToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayAllBreadsToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // displayAllBreadsToolStripMenuItem
            // 
            this.displayAllBreadsToolStripMenuItem.Name = "displayAllBreadsToolStripMenuItem";
            this.displayAllBreadsToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.displayAllBreadsToolStripMenuItem.Text = "Display All Breads";
            this.displayAllBreadsToolStripMenuItem.Click += new System.EventHandler(this.displayAllBreadsToolStripMenuItem_Click);
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madeTheBreadsToolStripMenuItem,
            this.sellTheBreadsToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // madeTheBreadsToolStripMenuItem
            // 
            this.madeTheBreadsToolStripMenuItem.Name = "madeTheBreadsToolStripMenuItem";
            this.madeTheBreadsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.madeTheBreadsToolStripMenuItem.Text = "Made the Breads";
            this.madeTheBreadsToolStripMenuItem.Click += new System.EventHandler(this.madeTheBreadsToolStripMenuItem_Click);
            // 
            // sellTheBreadsToolStripMenuItem
            // 
            this.sellTheBreadsToolStripMenuItem.Name = "sellTheBreadsToolStripMenuItem";
            this.sellTheBreadsToolStripMenuItem.Size = new System.Drawing.Size(204, 26);
            this.sellTheBreadsToolStripMenuItem.Text = "Sell the Breads";
            this.sellTheBreadsToolStripMenuItem.Click += new System.EventHandler(this.sellTheBreadsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 98);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormMenu";
            this.Text = "Bread Shop Application Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewVariantToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayAllBreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madeTheBreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellTheBreadsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}