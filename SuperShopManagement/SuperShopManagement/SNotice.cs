using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperShopManagement
{
    public partial class SNotice : Form
    {
        ConfirmLogout ConfirmLO;
        SalesmanPage SDashboardP;
        SInventory SInventoryP;
        SExpense SExpenseP;
        SSupplier SSupplierP;
        SProfile SProfileP;
        public SNotice()
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

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();

            SProfileP = new SProfile();
            SProfileP.Show();
        }

        private void SNotice_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notice_table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
