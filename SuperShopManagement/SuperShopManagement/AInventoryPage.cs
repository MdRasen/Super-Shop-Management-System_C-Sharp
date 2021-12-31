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
    public partial class AInventoryPage : Form
    {
        //LoginPage PrePage;
        AExpensePage ExpenseP;
        AdminPage DashboardP;
        AManagerPage ManagerP;
        ASupplierPage SupplierP;
        ASalesmanPage SalesmanP;
        ANoticePage NoticeP;
        AProfilePage ProfileP;
        ConfirmLogout ConfirmLO;
        public AInventoryPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this.Hide();

            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            ExpenseP = new AExpensePage();
            ExpenseP.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            DashboardP = new AdminPage();
            DashboardP.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.Hide();

            ManagerP = new AManagerPage();
            ManagerP.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();

            SupplierP = new ASupplierPage();
            SupplierP.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();

            SalesmanP = new ASalesmanPage();
            SalesmanP.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Hide();

            NoticeP = new ANoticePage();
            NoticeP.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileP = new AProfilePage();
            ProfileP.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("INSERT INTO Inventory_Table(Product_ID, P_Name, P_Type, P_Quantity, P_Price) VALUES (@Product_ID, @P_Name, @P_Type, @P_Quantity, @P_Price)", con);
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

            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }
        void DataBind()
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("SELECT * FROM Inventory_Table", con);

            SqlDataAdapter da = new(cmd);
            DataTable dt = new();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void AInventoryPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("SELECT * FROM Inventory_Table", con);

            SqlDataAdapter da = new(cmd);
            DataTable dt = new();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("DELETE Inventory_Table WHERE Product_ID=@Product_ID", con);
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

            catch(Exception error)
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
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("UPDATE Inventory_Table SET P_Name=@P_Name, P_Type=@P_Type, P_Quantity=@P_Quantity, P_Price=@P_Price WHERE Product_ID=@Product_ID", con);
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

            catch(Exception error)
            {
                MessageBox.Show(error.Message);
                //textBox1.Text = "";
                //textBox2.Text = "";
                //textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new("SELECT * FROM Inventory_Table WHERE Product_ID=@Product_ID", con);
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

                SqlDataAdapter da = new(cmd);
                DataTable dt = new();

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
