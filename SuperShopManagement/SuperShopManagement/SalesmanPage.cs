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
    public partial class SalesmanPage : Form
    {
        ConfirmLogout ConfirmLO;
        SInventory SInventoryP;
        SExpense SExpenseP;
        SSupplier SSupplierP;
        SNotice SNoticeP;
        SProfile SProfileP;
        public SalesmanPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            this.Hide();

            SInventoryP = new SInventory();
            SInventoryP.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //this.Hide();

            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
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

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

            SProfileP = new SProfile();
            SProfileP.Show();
        }
    }
}
