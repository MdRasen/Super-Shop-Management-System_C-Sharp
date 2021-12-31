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
    public partial class LoginPage : Form
    {
        AdminPage AdminP;
        ManagerPage ManagerPg;
        SalesmanPage SalesmanP;

        private string aPass = "admin";
        private string mPass = "manager";
        private string sPass = "salesman";

        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void logIn_Click(object sender, EventArgs e)
        {
            if(username.Text=="" && password.Text == "")
            {
                MessageBox.Show("Enter username and password!");
            }

            else if(comboBox1.Text == "SELECT A ROLE")
            {
                MessageBox.Show("Please select a specific role.");
            }

            else
            {
                //FOR ADMIN LOGIN
                if(comboBox1.Text == "ADMIN")
                {
                    if (username.Text == "admin" && password.Text == aPass)
                    {
                        this.Hide();
                        AdminP = new AdminPage();
                        AdminP.Show();
                    }


                    else
                    {
                        MessageBox.Show("The username or password is incorrect. Try again!");
                        
                        username.Text = "";
                        password.Text = "";
                    }
                }

                //FOR MANAGER LOGIN
                if (comboBox1.Text == "MANAGER")
                {
                    if (username.Text == "manager" && password.Text == mPass)
                    {
                        this.Hide();
                        ManagerPg = new ManagerPage();
                        ManagerPg.Show();
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect. Try again!");
                        
                        username.Text = "";
                        password.Text = "";
                    }
                }

                //FOR SALESMAN LOGIN
                if (comboBox1.Text == "SALESMAN")
                {
                    if (username.Text == "salesman" && password.Text == sPass)
                    {
                        this.Hide();
                        SalesmanP = new SalesmanPage();
                        SalesmanP.Show();
                    }
                    else
                    {
                        MessageBox.Show("The username or password is incorrect. Try again!");

                        username.Text = "";
                        password.Text = "";
                    }
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
