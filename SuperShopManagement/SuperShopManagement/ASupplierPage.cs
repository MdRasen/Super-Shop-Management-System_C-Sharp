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
    public partial class ASupplierPage : Form
    {
        //LoginPage PrePage;
        AInventoryPage InventoryP;
        AExpensePage ExpenseP;
        AdminPage DashboardP;
        AManagerPage ManagerP;
        ASupplierPage SupplierP;
        ASalesmanPage SalesmanP;
        ANoticePage NoticeP;
        AProfilePage ProfileP;
        ConfirmLogout ConfirmLO;
        public ASupplierPage()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            DashboardP = new AdminPage();
            DashboardP.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();

            InventoryP = new AInventoryPage();
            InventoryP.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();

            ExpenseP = new AExpensePage();
            ExpenseP.Show();
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

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Supplier_Table(Supplier_ID, S_Name, S_Type, S_Phone, S_Address) VALUES (@Supplier_ID, @S_Name, @S_Type, @S_Phone, @S_Address)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Supplier_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@S_Type", (textBox3.Text));
                cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox4.Text)));
                cmd.Parameters.AddWithValue("@S_Address", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Supplier has been inserted!");

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

        void DataBind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Supplier_Table WHERE Supplier_ID= @Supplier_ID", con);
            cmd.Parameters.AddWithValue("@Supplier_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@S_Type", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox4.Text)));
            //cmd.Parameters.AddWithValue("@S_Address", (textBox5.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Supplier has been deleted!");

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

            SqlCommand cmd = new SqlCommand("UPDATE Supplier_Table SET S_Name=@S_Name, S_Type=@S_Type, S_Phone=@S_Phone, S_Address=@S_Address WHERE Supplier_ID= @Supplier_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Supplier_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@S_Type", (textBox3.Text));
                cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox4.Text)));
                cmd.Parameters.AddWithValue("@S_Address", (textBox5.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Supplier details has been modified!");

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

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier_Table WHERE Supplier_ID=@Supplier_ID", con);
            cmd.Parameters.AddWithValue("@Supplier_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@S_Type", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox4.Text)));
            //cmd.Parameters.AddWithValue("@S_Address", (textBox5.Text));

            cmd.ExecuteNonQuery();
            con.Close();

            //MessageBox.Show("Supplier has been inserted!");

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

        private void ASupplierPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier_Table", con);

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
                errorProvider1.SetError(textBox1, "Enter a valid Supplier ID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
