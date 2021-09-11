using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace alvinBreadShopApplication
{
    public partial class FormSellTheBreads : Form
    {
        FormMenu formMenu;
        public FormSellTheBreads()
        {
            InitializeComponent();
        }

        private void FormSellTheBreads_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            comboBoxVariantSell.Items.Clear();

            foreach (alvinBreads bread in formMenu.listBread)
            {
                comboBoxVariantSell.Items.Add(bread.Name);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            try
            {
                //cari di dalam listBread
                foreach (alvinBreads bread in formMenu.listBread)
                {
                    if (bread.Name == comboBoxVariantSell.Text)
                    {
                        //panggil method sell
                        int totalPayment = bread.Sell(int.Parse(textBoxQuantitySell.Text), comboBoxPayment.Text);

                        //mengisi di listbox
                        listBoxData.Items.Add("SELL THE BREADS");
                        listBoxData.Items.Add("Bread Name : " + bread.Name);
                        listBoxData.Items.Add("Quantity to sell : " + textBoxQuantitySell.Text);
                        listBoxData.Items.Add("Payment Method : " + comboBoxPayment.Text);
                        listBoxData.Items.Add("Total Payment : " + totalPayment);
                        listBoxData.Items.Add("===============================");

                        //menampilkan data
                        //TampilData();
                    }
                }
                //mengosongi textbox quantity sell
                textBoxQuantitySell.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }
    }
}
