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
    public partial class MSalesman : Form
    {
        ConfirmLogout ConfirmLO;
        ManagerPage MDashboardP;
        MInventory MInventoryP;
        MExpense MExpenseP;
        MSupplier MSupplierP;
        MNotice MNoticeP;
        MProfile MProfileP;
        public MSalesman()
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

            SqlCommand cmd = new SqlCommand("INSERT INTO Salesman_Table(Salesman_ID, S_Name, SJoining_Date, SLeaving_Date, S_Salary, S_Phone) VALUES (@Salesman_ID, @S_Name, @SJoining_Date, @SLeaving_Date, @S_Salary, @S_Phone)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Salesman_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@SJoining_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@SLeaving_Date", (textBox4.Text));
                cmd.Parameters.AddWithValue("@S_Salary", int.Parse((textBox6.Text)));
                cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox5.Text)));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salesman has been inserted!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
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
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }

        void DataBind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Salesman_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Salesman_Table WHERE Salesman_ID= @Salesman_ID", con);
            cmd.Parameters.AddWithValue("@Salesman_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@SJoining_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@SLeaving_Date", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@S_Salary", int.Parse((textBox6.Text)));
            //cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox5.Text)));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Salesman has been removed!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";

            DataBind();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Salesman_Table SET S_Name=@S_Name, SJoining_Date=@SJoining_Date, SLeaving_Date=@SLeaving_Date, S_Salary=@S_Salary, S_Phone=@S_Phone WHERE Salesman_ID= @Salesman_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Salesman_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@SJoining_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@SLeaving_Date", (textBox4.Text));
                cmd.Parameters.AddWithValue("@S_Salary", int.Parse((textBox6.Text)));
                cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox5.Text)));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Salesman has been modified!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
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
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Salesman_Table WHERE Salesman_ID=@Salesman_ID", con);
            cmd.Parameters.AddWithValue("@Salesman_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@S_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@SJoining_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@SLeaving_Date", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@S_Salary", int.Parse((textBox6.Text)));
            //cmd.Parameters.AddWithValue("@S_Phone", int.Parse((textBox5.Text)));

            cmd.ExecuteNonQuery();
            con.Close();

            //MessageBox.Show("Salesman has been modified!");

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox5.Text = "";

            //DataBind();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void MSalesman_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Salesman_Table", con);

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
                errorProvider1.SetError(textBox1, "Enter a valid Salesman ID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
