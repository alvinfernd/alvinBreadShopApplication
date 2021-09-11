
namespace alvinBreadShopApplication
{
    partial class FormMadeTheBreads
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
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxVariantMade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMade = new System.Windows.Forms.Button();
            this.textBoxQuantityMade = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(27, 144);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(359, 212);
            this.listBoxData.TabIndex = 30;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(267, 376);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 34);
            this.buttonExit.TabIndex = 29;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxVariantMade
            // 
            this.comboBoxVariantMade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariantMade.FormattingEnabled = true;
            this.comboBoxVariantMade.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxVariantMade.Location = new System.Drawing.Point(139, 14);
            this.comboBoxVariantMade.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVariantMade.Name = "comboBoxVariantMade";
            this.comboBoxVariantMade.Size = new System.Drawing.Size(247, 24);
            this.comboBoxVariantMade.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Variant Name :";
            // 
            // buttonMade
            // 
            this.buttonMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMade.Location = new System.Drawing.Point(139, 89);
            this.buttonMade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMade.Name = "buttonMade";
            this.buttonMade.Size = new System.Drawing.Size(120, 34);
            this.buttonMade.TabIndex = 26;
            this.buttonMade.Text = "MADE";
            this.buttonMade.UseVisualStyleBackColor = true;
            this.buttonMade.Click += new System.EventHandler(this.buttonMade_Click);
            // 
            // textBoxQuantityMade
            // 
            this.textBoxQuantityMade.Location = new System.Drawing.Point(139, 51);
            this.textBoxQuantityMade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantityMade.Name = "textBoxQuantityMade";
            this.textBoxQuantityMade.Size = new System.Drawing.Size(97, 22);
            this.textBoxQuantityMade.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 55);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 27;
            this.label7.Text = "Quantity :";
            // 
            // FormMadeTheBreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 425);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxVariantMade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonMade);
            this.Controls.Add(this.textBoxQuantityMade);
            this.Controls.Add(this.label7);
            this.Name = "FormMadeTheBreads";
            this.Text = "Made The Breads";
            this.Load += new System.EventHandler(this.FormMadeTheBreads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxVariantMade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonMade;
        private System.Windows.Forms.TextBox textBoxQuantityMade;
        private System.Windows.Forms.Label label7;
    }
}