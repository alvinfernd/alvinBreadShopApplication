
namespace alvinBreadShopApplication
{
    partial class Form1
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonClearData = new System.Windows.Forms.Button();
            this.buttonDisplayData = new System.Windows.Forms.Button();
            this.listBoxData = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.groupBoxSell = new System.Windows.Forms.GroupBox();
            this.comboBoxPayment = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.textBoxQuantitySell = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonMade = new System.Windows.Forms.Button();
            this.textBoxQuantityMade = new System.Windows.Forms.TextBox();
            this.groupBoxMade = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxNewVariant = new System.Windows.Forms.GroupBox();
            this.groupBoxDisplayData = new System.Windows.Forms.GroupBox();
            this.comboBoxVariantMade = new System.Windows.Forms.ComboBox();
            this.comboBoxVariantSell = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxSell.SuspendLayout();
            this.groupBoxMade.SuspendLayout();
            this.groupBoxNewVariant.SuspendLayout();
            this.groupBoxDisplayData.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(132, 128);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(120, 34);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(132, 85);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(119, 22);
            this.textBoxPrice.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Variant Name :";
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(411, 522);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(4);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(107, 34);
            this.buttonExit.TabIndex = 11;
            this.buttonExit.Text = "EXIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonClearData
            // 
            this.buttonClearData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearData.Location = new System.Drawing.Point(177, 521);
            this.buttonClearData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClearData.Name = "buttonClearData";
            this.buttonClearData.Size = new System.Drawing.Size(156, 34);
            this.buttonClearData.TabIndex = 10;
            this.buttonClearData.Text = "CLEAR DATA";
            this.buttonClearData.UseVisualStyleBackColor = true;
            this.buttonClearData.Click += new System.EventHandler(this.buttonClearData_Click);
            // 
            // buttonDisplayData
            // 
            this.buttonDisplayData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDisplayData.Location = new System.Drawing.Point(13, 521);
            this.buttonDisplayData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDisplayData.Name = "buttonDisplayData";
            this.buttonDisplayData.Size = new System.Drawing.Size(156, 34);
            this.buttonDisplayData.TabIndex = 9;
            this.buttonDisplayData.Text = "DISPLAY DATA";
            this.buttonDisplayData.UseVisualStyleBackColor = true;
            this.buttonDisplayData.Click += new System.EventHandler(this.buttonDisplayData_Click);
            // 
            // listBoxData
            // 
            this.listBoxData.FormattingEnabled = true;
            this.listBoxData.ItemHeight = 16;
            this.listBoxData.Location = new System.Drawing.Point(13, 22);
            this.listBoxData.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxData.Name = "listBoxData";
            this.listBoxData.Size = new System.Drawing.Size(503, 484);
            this.listBoxData.TabIndex = 0;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(132, 42);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(236, 22);
            this.textBoxName.TabIndex = 1;
            // 
            // groupBoxSell
            // 
            this.groupBoxSell.Controls.Add(this.label4);
            this.groupBoxSell.Controls.Add(this.comboBoxVariantSell);
            this.groupBoxSell.Controls.Add(this.comboBoxPayment);
            this.groupBoxSell.Controls.Add(this.label6);
            this.groupBoxSell.Controls.Add(this.buttonSell);
            this.groupBoxSell.Controls.Add(this.textBoxQuantitySell);
            this.groupBoxSell.Controls.Add(this.label5);
            this.groupBoxSell.Location = new System.Drawing.Point(27, 388);
            this.groupBoxSell.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxSell.Name = "groupBoxSell";
            this.groupBoxSell.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxSell.Size = new System.Drawing.Size(435, 201);
            this.groupBoxSell.TabIndex = 11;
            this.groupBoxSell.TabStop = false;
            this.groupBoxSell.Text = "Sell the Bread";
            // 
            // comboBoxPayment
            // 
            this.comboBoxPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPayment.FormattingEnabled = true;
            this.comboBoxPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit Card"});
            this.comboBoxPayment.Location = new System.Drawing.Point(132, 59);
            this.comboBoxPayment.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxPayment.Name = "comboBoxPayment";
            this.comboBoxPayment.Size = new System.Drawing.Size(220, 24);
            this.comboBoxPayment.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Payment Method :";
            // 
            // buttonSell
            // 
            this.buttonSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSell.Location = new System.Drawing.Point(132, 151);
            this.buttonSell.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(120, 34);
            this.buttonSell.TabIndex = 8;
            this.buttonSell.Text = "SELL";
            this.buttonSell.UseVisualStyleBackColor = true;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // textBoxQuantitySell
            // 
            this.textBoxQuantitySell.Location = new System.Drawing.Point(132, 102);
            this.textBoxQuantitySell.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantitySell.Name = "textBoxQuantitySell";
            this.textBoxQuantitySell.Size = new System.Drawing.Size(97, 22);
            this.textBoxQuantitySell.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 106);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Quantity :";
            // 
            // buttonMade
            // 
            this.buttonMade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMade.Location = new System.Drawing.Point(132, 104);
            this.buttonMade.Margin = new System.Windows.Forms.Padding(4);
            this.buttonMade.Name = "buttonMade";
            this.buttonMade.Size = new System.Drawing.Size(120, 34);
            this.buttonMade.TabIndex = 8;
            this.buttonMade.Text = "MADE";
            this.buttonMade.UseVisualStyleBackColor = true;
            this.buttonMade.Click += new System.EventHandler(this.buttonMade_Click);
            // 
            // textBoxQuantityMade
            // 
            this.textBoxQuantityMade.Location = new System.Drawing.Point(132, 66);
            this.textBoxQuantityMade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxQuantityMade.Name = "textBoxQuantityMade";
            this.textBoxQuantityMade.Size = new System.Drawing.Size(97, 22);
            this.textBoxQuantityMade.TabIndex = 3;
            // 
            // groupBoxMade
            // 
            this.groupBoxMade.Controls.Add(this.label3);
            this.groupBoxMade.Controls.Add(this.comboBoxVariantMade);
            this.groupBoxMade.Controls.Add(this.buttonMade);
            this.groupBoxMade.Controls.Add(this.textBoxQuantityMade);
            this.groupBoxMade.Controls.Add(this.label7);
            this.groupBoxMade.Location = new System.Drawing.Point(27, 209);
            this.groupBoxMade.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxMade.Name = "groupBoxMade";
            this.groupBoxMade.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxMade.Size = new System.Drawing.Size(435, 160);
            this.groupBoxMade.TabIndex = 10;
            this.groupBoxMade.TabStop = false;
            this.groupBoxMade.Text = "Made the Bread";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 70);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Quantity :";
            // 
            // groupBoxNewVariant
            // 
            this.groupBoxNewVariant.Controls.Add(this.buttonAdd);
            this.groupBoxNewVariant.Controls.Add(this.textBoxPrice);
            this.groupBoxNewVariant.Controls.Add(this.label2);
            this.groupBoxNewVariant.Controls.Add(this.textBoxName);
            this.groupBoxNewVariant.Controls.Add(this.label1);
            this.groupBoxNewVariant.Location = new System.Drawing.Point(27, 18);
            this.groupBoxNewVariant.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxNewVariant.Name = "groupBoxNewVariant";
            this.groupBoxNewVariant.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxNewVariant.Size = new System.Drawing.Size(435, 183);
            this.groupBoxNewVariant.TabIndex = 8;
            this.groupBoxNewVariant.TabStop = false;
            this.groupBoxNewVariant.Text = "Add New Bread";
            // 
            // groupBoxDisplayData
            // 
            this.groupBoxDisplayData.Controls.Add(this.buttonExit);
            this.groupBoxDisplayData.Controls.Add(this.buttonClearData);
            this.groupBoxDisplayData.Controls.Add(this.buttonDisplayData);
            this.groupBoxDisplayData.Controls.Add(this.listBoxData);
            this.groupBoxDisplayData.Location = new System.Drawing.Point(471, 18);
            this.groupBoxDisplayData.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDisplayData.Name = "groupBoxDisplayData";
            this.groupBoxDisplayData.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDisplayData.Size = new System.Drawing.Size(541, 571);
            this.groupBoxDisplayData.TabIndex = 9;
            this.groupBoxDisplayData.TabStop = false;
            this.groupBoxDisplayData.Text = "Display Data";
            // 
            // comboBoxVariantMade
            // 
            this.comboBoxVariantMade.FormattingEnabled = true;
            this.comboBoxVariantMade.Location = new System.Drawing.Point(132, 35);
            this.comboBoxVariantMade.Name = "comboBoxVariantMade";
            this.comboBoxVariantMade.Size = new System.Drawing.Size(236, 24);
            this.comboBoxVariantMade.TabIndex = 9;
            // 
            // comboBoxVariantSell
            // 
            this.comboBoxVariantSell.FormattingEnabled = true;
            this.comboBoxVariantSell.Location = new System.Drawing.Point(132, 28);
            this.comboBoxVariantSell.Name = "comboBoxVariantSell";
            this.comboBoxVariantSell.Size = new System.Drawing.Size(236, 24);
            this.comboBoxVariantSell.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Variant Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Variant Name :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 606);
            this.Controls.Add(this.groupBoxSell);
            this.Controls.Add(this.groupBoxMade);
            this.Controls.Add(this.groupBoxNewVariant);
            this.Controls.Add(this.groupBoxDisplayData);
            this.Name = "Form1";
            this.Text = "Bread Shop Alvin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxSell.ResumeLayout(false);
            this.groupBoxSell.PerformLayout();
            this.groupBoxMade.ResumeLayout(false);
            this.groupBoxMade.PerformLayout();
            this.groupBoxNewVariant.ResumeLayout(false);
            this.groupBoxNewVariant.PerformLayout();
            this.groupBoxDisplayData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonClearData;
        private System.Windows.Forms.Button buttonDisplayData;
        private System.Windows.Forms.ListBox listBoxData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.GroupBox groupBoxSell;
        private System.Windows.Forms.ComboBox comboBoxPayment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.TextBox textBoxQuantitySell;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonMade;
        private System.Windows.Forms.TextBox textBoxQuantityMade;
        private System.Windows.Forms.GroupBox groupBoxMade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxNewVariant;
        private System.Windows.Forms.GroupBox groupBoxDisplayData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxVariantSell;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxVariantMade;
    }
}

