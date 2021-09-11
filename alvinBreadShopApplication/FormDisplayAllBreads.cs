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
    public partial class FormDisplayAllBreads : Form
    {
        FormMenu formMenu;
        public FormDisplayAllBreads()
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

        private void FormDisplayAllBreads_Load(object sender, EventArgs e)
        {
            formMenu =(FormMenu) this.Owner;
            //menampilkan semua data roti
            TampilData();
        }
    }
}
