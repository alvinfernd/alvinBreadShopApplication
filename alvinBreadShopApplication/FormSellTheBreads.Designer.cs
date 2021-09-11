
namespace alvinBreadShopApplication
{
    partial class FormSellTheBreads
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
            this.comboBoxVariantSell = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxQuantitySell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(26, 191);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(375, 196);
            this.listBoxData.TabIndex = 33;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(282, 395);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(120, 34);
            this.buttonExit.TabIndex = 32;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxVariantSell
            // 
            this.comboBoxVariantSell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVariantSell.FormattingEnabled = true;
            this.comboBoxVariantSell.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxVariantSell.Location = new System.Drawing.Point(154, 19);
            this.comboBoxVariantSell.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVariantSell.Name = "comboBoxVariantSell";
            this.comboBoxVariantSell.Size = new System.Drawing.Size(247, 24);
            this.comboBoxVariantSell.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Variant Name :";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxPayment.Location = new System.Drawing.Point(154, 58);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(247, 24);
            this.comboBoxPayment.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 61);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Payment Method :";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(154, 141);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(120, 34);
            this.buttonSell.TabIndex = 29;
            this.buttonSell.Text = "SELL";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxQuantitySell
            // 
            this.textBoxQuantitySell.Location = new System.Drawing.Point(154, 96);
            this.textBoxQuantitySell.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantitySell.Name = "textBoxQuantitySell";
            this.textBoxQuantitySell.Size = new System.Drawing.Size(97, 22);
            this.textBoxQuantitySell.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 99);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Quantity :";
            // 
            // FormSellTheBreads
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 449);
            this.Controls.Add(this.listBoxData);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.comboBoxVariantSell);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxPayment);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonSell);
            this.Controls.Add(this.textBoxQuantitySell);
            this.Controls.Add(this.label5);
            this.Name = "FormSellTheBreads";
            this.Text = "Sell The Breads";
            this.Load += new System.EventHandler(this.FormSellTheBreads_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxVariantSell;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxQuantitySell;
        private System.Windows.Forms.Label label5;
    }
}