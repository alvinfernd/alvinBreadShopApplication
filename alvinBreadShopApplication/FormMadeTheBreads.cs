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
    public partial class FormMadeTheBreads : Form
    {
        FormMenu formMenu;
        public FormMadeTheBreads()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMadeTheBreads_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu)this.Owner;

            //kosongi combobox 
            comboBoxVariantMade.Items.Clear();

            //tambahkan semua roti yang ada di dalam list ke combobox
            foreach(alvinBreads bread in formMenu.listBread)
            {
                comboBoxVariantMade.Items.Add(bread.Name);
            }
        }

        private void buttonMade_Click(object sender, EventArgs e)
        {
            try
            {
                //membuat roti yang dipilih user dari combobox
                //cari di dalam listBread
                foreach (alvinBreads bread in formMenu.listBread)
                {
                    //cek apakah nama roti sama dengan yang dipilih user di combobox
                    if (bread.Name == comboBoxVariantMade.Text)
                    {
                        //membuat roti
                        //memanggil method production dengan parameter
                        bread.Production(int.Parse(textBoxQuantityMade.Text));

                        //tampilkan quantity yang diproduksi
                        listBoxData.Items.Add("Bread Name : " + bread.Name);
                        listBoxData.Items.Add("Quantity to Made : " + textBoxQuantityMade.Text);

                        //tampilkan data
                        //TampilData();
                    }
                }
                //mengosongi textbox quantity made
                textBoxQuantityMade.Text = "";
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        
    }
}
