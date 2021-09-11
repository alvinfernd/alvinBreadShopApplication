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
    public partial class FormAddNewVariants : Form
    {
        alvinBreads myBread;

        //deklarasi objek bertipe FormMenu supaya form ini bisa mengakses form menu
        FormMenu formMenu;

        public FormAddNewVariants()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TampilData()
        {
            foreach (alvinBreads bread in formMenu.listBread)
            {
                //menampilkan data roti
                listBoxData.Items.Add("Variant Name : " + bread.Name);
                listBoxData.Items.Add("Price per pcs : " + bread.Price);
                listBoxData.Items.Add("Stock : " + bread.Stock);

                //menambah 1 baris kosong 
                listBoxData.Items.Add("");
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //membuat roti baru dengan parameterized constructor
                myBread = new alvinBreads(textBoxName.Text, int.Parse(textBoxPrice.Text));

                /*//mengisi data roti
                myBread.Name = textBoxName.Text;
                myBread.Price = int.Parse(textBoxPrice.Text);*/

                //simpan atau tambahkan objek roti baru ke dalam list
                formMenu.listBread.Add(myBread);

                //kosongi dulu listBox
                listBoxData.Items.Clear();

                TampilData();

                //kosongi inputan user
                textBoxName.Text = "";
                textBoxPrice.Text = "";
                textBoxName.Focus();
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void FormAddNewVariants_Load(object sender, EventArgs e)
        {
            formMenu = (FormMenu) this.Owner;
        }
    }
}
