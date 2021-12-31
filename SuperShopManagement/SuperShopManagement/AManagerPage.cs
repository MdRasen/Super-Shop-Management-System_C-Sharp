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
    public partial class AManagerPage : Form
    {
        //LoginPage PrePage;
        AInventoryPage InventoryP;
        AExpensePage ExpenseP;
        AdminPage DashboardP;
        ASupplierPage SupplierP;
        ASalesmanPage SalesmanP;
        ANoticePage NoticeP;
        AProfilePage ProfileP;
        ConfirmLogout ConfirmLO;
        public AManagerPage()
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

        private void AManagerPage_Load(object sender, EventArgs e)
        {
            SqlConnection con = new("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Manager_Table", con);

            SqlDataAdapter da = new(cmd);
            DataTable dt = new();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            //this.Hide();
            
            ConfirmLO = new ConfirmLogout();
            ConfirmLO.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Manager_Table(Manager_ID, M_Name, MJoining_Date, MLeaving_Date, M_Salary, M_Phone) VALUES (@Manager_ID, @M_Name, @MJoining_Date, @MLeaving_Date, @M_Salary, @M_Phone)", con);
            try
            {
                cmd.Parameters.AddWithValue("@Manager_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@M_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@MJoining_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@MLeaving_Date", (textBox4.Text));
                cmd.Parameters.AddWithValue("@M_Salary", int.Parse((textBox6.Text)));
                cmd.Parameters.AddWithValue("@M_Phone", int.Parse((textBox5.Text)));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Manager has been inserted!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
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
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }

        void DataBind()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Manager_Table", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("DELETE Manager_Table WHERE Manager_ID=@Manager_ID", con);
            cmd.Parameters.AddWithValue("@Manager_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@M_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@MJoining_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@MLeaving_Date", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@M_Salary", int.Parse((textBox6.Text)));
            //cmd.Parameters.AddWithValue("@M_Phone", int.Parse((textBox5.Text)));

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Manager data has been deleted!");

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

            SqlCommand cmd = new SqlCommand("UPDATE Manager_Table SET M_Name=@M_Name, MJoining_Date=@MJoining_Date, MLeaving_Date=@MLeaving_Date, M_Salary=@M_Salary, M_Phone=@M_Phone WHERE Manager_ID=@Manager_ID", con);
            try
            {
                cmd.Parameters.AddWithValue("@Manager_ID", (textBox1.Text));
                cmd.Parameters.AddWithValue("@M_Name", (textBox2.Text));
                cmd.Parameters.AddWithValue("@MJoining_Date", (textBox3.Text));
                cmd.Parameters.AddWithValue("@MLeaving_Date", (textBox4.Text));
                cmd.Parameters.AddWithValue("@M_Salary", int.Parse((textBox6.Text)));
                cmd.Parameters.AddWithValue("@M_Phone", int.Parse((textBox5.Text)));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Manager data has been updated!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox6.Text = "";
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
                textBox6.Text = "";
                textBox5.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-FCICC4P;Initial Catalog=Supershop_Management;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM Manager_Table WHERE Manager_ID=@Manager_ID", con);
            cmd.Parameters.AddWithValue("@Manager_ID", (textBox1.Text));
            //cmd.Parameters.AddWithValue("@M_Name", (textBox2.Text));
            //cmd.Parameters.AddWithValue("@MJoining_Date", (textBox3.Text));
            //cmd.Parameters.AddWithValue("@MLeaving_Date", (textBox4.Text));
            //cmd.Parameters.AddWithValue("@M_Salary", int.Parse((textBox6.Text)));
            //cmd.Parameters.AddWithValue("@M_Phone", int.Parse((textBox5.Text)));

            cmd.ExecuteNonQuery();
            con.Close();

            //MessageBox.Show("Manager data has been updated!");

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

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Enter a valid Manager ID!");
            }

            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, null);
            }
        }
    }
}
