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
    public partial class SProfile : Form
    {
        ConfirmLogout ConfirmLO;
        SalesmanPage SDashboardP;
        SInventory SInventoryP;
        SExpense SExpenseP;
        SSupplier SSupplierP;
        SNotice SNoticeP;
        public SProfile()
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

            SDashboardP = new SalesmanPage();
            SDashboardP.Show();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();

            SInventoryP = new SInventory();
            SInventoryP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            SExpenseP = new SExpense();
            SExpenseP.Show();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();

            SSupplierP = new SSupplier();
            SSupplierP.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            this.Hide();

            SNoticeP = new SNotice();
            SNoticeP.Show();
        }
    }
}
