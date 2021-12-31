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
    public partial class MInventory : Form
    {
        ConfirmLogout ConfirmLO;
        ManagerPage MDashboardP;
       // MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        MSalesman MSalesmanP;
        MNotice MNoticeP;
        MProfile MProfileP;
        public MInventory()
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

            SqlCommand cmd = new SqlCommand("INSERT INTO Inventory_Table(Product_ID, P_Name, P_Type, P_Quantity, P_Price) VALUES (@Product_ID, @P_Name, @P_Type, @P_Quantity, @P_Price)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Product_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@P_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@P_Type", (textBox3.Text));
                cmd.Parameters.AddWithValue("@P_Quantity", (textBox4.Text));
                cmd.Parameters.AddWithValue("@P_Price", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product has been inserted!");

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Inventory_Table WHERE Product_ID=@Product_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Product_ID", (textBox1.Text));
                //cmd.Parameters.AddWithValue("@P_Name", (textBox2.Text));
                //cmd.Parameters.AddWithValue("@P_Type", (textBox3.Text));
                //cmd.Parameters.AddWithValue("@P_Quantity", (textBox4.Text));
                //cmd.Parameters.AddWithValue("@P_Price", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product has been deleted!");

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

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Inventory_Table SET P_Name=@P_Name, P_Type=@P_Type, P_Quantity=@P_Quantity, P_Price=@P_Price WHERE Product_ID=@Product_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Product_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@P_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@P_Type", (textBox3.Text));
                cmd.Parameters.AddWithValue("@P_Quantity", (textBox4.Text));
                cmd.Parameters.AddWithValue("@P_Price", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product has been modified!");

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

            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory_Table WHERE Product_ID=@Product_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Product_ID", (textBox1.Text));
                //cmd.Parameters.AddWithValue("@P_Name", (textBox2.Text));
                //cmd.Parameters.AddWithValue("@P_Type", (textBox3.Text));
                //cmd.Parameters.AddWithValue("@P_Quantity", (textBox4.Text));
                //cmd.Parameters.AddWithValue("@P_Price", (textBox5.Text));

                //cmd.ExecuteNonQuery();
                //con.Close();

                //MessageBox.Show("Product has been inserted!");

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

        private void MInventory_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Inventory_Table", con);

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
                errorProvider1.SetError(textBox1, "Enter a valid product ID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
