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
    public partial class FormMenu : Form
    {
        //deklarasikan listBread di FormMenu agar bisa diakses di semua form yang terhubung ke FormMenu
        //tambahkan hak akses public agar list bisa diakses di form lain
        public List<alvinBreads> listBread = new List<alvinBreads>();

        public FormMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewVariantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menampilkan formAddNewVariants
            FormAddNewVariants form = new FormAddNewVariants();
            form.Owner = this;
            form.ShowDialog();
        }

        private void displayAllBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menampilkan formDisplayAllBreads
            FormDisplayAllBreads form = new FormDisplayAllBreads();
            form.Owner = this;
            form.ShowDialog();
        }

        private void madeTheBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menampilkan formMadeTheBreads
            FormMadeTheBreads form = new FormMadeTheBreads();
            form.Owner = this;
            form.ShowDialog();
        }

        private void sellTheBreadsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //menampilkan formSellTheBreads
            FormSellTheBreads form = new FormSellTheBreads();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}
