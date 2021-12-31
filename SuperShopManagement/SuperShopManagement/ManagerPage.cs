using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagement
{
    public partial class ManagerPage : Form
    {
        ConfirmLogout ConfirmLO;
        MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        MSalesman MSalesmanP;
        MNotice MNoticeP;
        MProfile MProfileP;
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSalesmanP = new MSalesman();
            MSalesmanP.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();

            MInventoryP = new MInventory();
            MInventoryP.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSupplierP = new MSupplier();
            MSupplierP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            MExpenseP = new MExpense();
            MExpenseP.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();

            MNoticeP = new MNotice();
            MNoticeP.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

            MProfileP = new MProfile();
            MProfileP.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.Hide();

            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            MExpenseP = new MExpense();
            MExpenseP.Show();
        }
    }
}
