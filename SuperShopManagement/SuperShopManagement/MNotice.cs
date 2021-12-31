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
    public partial class MNotice : Form
    {
        ConfirmLogout ConfirmLO;
        ManagerPage MDashboardP;
        MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        MSalesman MSalesmanP;
        MProfile MProfileP;
        public MNotice()
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

            catch (Exception error)
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

        private void MNotice_Load(object sender, EventArgs e)
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
    }
}
