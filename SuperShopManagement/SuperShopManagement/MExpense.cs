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
    public partial class MExpense : Form
    {
        ConfirmLogout ConfirmLO;
        ManagerPage MDashboardP;
        MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        //MSalesman MSalesmanP;
        MNotice MNoticeP;
        MProfile MProfileP;
        public MExpense()
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

        private void button20_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSupplierP = new MSupplier();
            MSupplierP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            MSupplierP = new MSupplier();
            MSupplierP.Show();
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Expense_Table(Expense_ID, E_Details, E_Date, E_Type, E_Amount) VALUES (@Expense_ID, @E_Details, @E_Date, @E_Type, @E_Amount)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Expense_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@E_Details", (textBox2.Text));
                cmd.Parameters.AddWithValue("@E_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@E_Type", (textBox4.Text));
                cmd.Parameters.AddWithValue("@E_Amount", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Expense details has been inserted!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                DataBind();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        void DataBind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Expense_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Expense_Table WHERE Expense_ID=@Expense_ID", con);
            cmd.Parameters.AddWithValue("@Expense_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@E_Details", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@E_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@E_Type", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@E_Amount", (textBox5.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Expense details has been deleted!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Expense_Table SET E_Details=@E_Details, E_Date=@E_Date, E_Type=@E_Type, E_Amount=@E_Amount WHERE Expense_ID=@Expense_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Expense_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@E_Details", (textBox2.Text));
                cmd.Parameters.AddWithValue("@E_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@E_Type", (textBox4.Text));
                cmd.Parameters.AddWithValue("@E_Amount", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Expense details has been modified!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";

                DataBind();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Expense_Table WHERE Expense_ID=@Expense_ID", con);
            cmd.Parameters.AddWithValue("@Expense_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@E_Details", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@E_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@E_Type", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@E_Amount", (textBox5.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            //MessageBox.Show("Expense details has been inserted!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";

            //DataBind();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MExpense_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Expense_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Enter a valid Expense ID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            MExpenseP = new MExpense();
            MExpenseP.Show();
        }
    }
}
