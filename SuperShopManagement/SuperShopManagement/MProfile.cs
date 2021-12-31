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
    public partial class MProfile : Form
    {
        ConfirmLogout ConfirmLO;
        ManagerPage MDashboardP;
        MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        MSalesman MSalesmanP;
        MNotice MNoticeP;
        public MProfile()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.Hide();

            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            this.Hide();

            MDashboardP = new ManagerPage();
            MDashboardP.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();

            MInventoryP = new MInventory();
            MInventoryP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            MExpenseP = new MExpense();
            MExpenseP.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSupplierP = new MSupplier();
            MSupplierP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSalesmanP = new MSalesman();
            MSalesmanP.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();

            MNoticeP = new MNotice();
            MNoticeP.Show();
        }
    }
}
