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
    public partial class ANoticePage : Form
    {
        //LoginPage PrePage;
        AInventoryPage InventoryP;
        AExpensePage ExpenseP;
        AdminPage DashboardP;
        AManagerPage ManagerP;
        ASupplierPage SupplierP;
        ASalesmanPage SalesmanP;
        AProfilePage ProfileP;
        ConfirmLogout ConfirmLO;
        public ANoticePage()
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

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();

            ProfileP = new AProfilePage();
            ProfileP.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Notice_Table(Notice_Num, N_Topic, Notice) VALUES (@Notice_Num, @N_Topic, @Notice)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Notice_Num", (int.Parse(textBox1.Text)));
                cmd.Parameters.AddWithValue("@N_Topic", (textBox3.Text));
                cmd.Parameters.AddWithValue("@Notice", (textBox2.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Notice has been updated!");

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";

                DataBind();
            }

            catch(Exception error)
            {
                MessageBox.Show(error.Message);

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        void DataBind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notice_table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ANoticePage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notice_table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Notice_Table WHERE Notice_Num=@Notice_Num", con);
            try
            {
                cmd.Parameters.AddWithValue("@Notice_Num", (int.Parse(textBox1.Text)));
                //cmd.Parameters.AddWithValue("@N_Topic", (textBox3.Text));
                //cmd.Parameters.AddWithValue("@Notice", (textBox2.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Notice has been deleted!");

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";

                DataBind();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Notice_Table SET N_Topic=@N_Topic, Notice=@Notice WHERE Notice_Num=@Notice_Num", con);
            try
            {
                cmd.Parameters.AddWithValue("@Notice_Num", (int.Parse(textBox1.Text)));
                cmd.Parameters.AddWithValue("@N_Topic", (textBox3.Text));
                cmd.Parameters.AddWithValue("@Notice", (textBox2.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Notice has been modified!");

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";

                DataBind();
            }

            catch (Exception error)
            {
                MessageBox.Show(error.Message);

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Notice_Table WHERE Notice_Num=@Notice_Num", con);
            try
            {
                cmd.Parameters.AddWithValue("@Notice_Num", (int.Parse(textBox1.Text)));
                //cmd.Parameters.AddWithValue("@N_Topic", (textBox3.Text));
                //cmd.Parameters.AddWithValue("@Notice", (textBox2.Text));

                //cmd.ExecuteNonQuery();
                //con.Close();

                //MessageBox.Show("Notice has been modified!");

                textBox1.Text = "";
                textBox3.Text = "";
                textBox2.Text = "";

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
                textBox3.Text = "";
                textBox2.Text = "";
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Enter a valid Notice Number!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
