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
    public partial class ConfirmLogout : Form
    {
        LoginPage LoginP;
        AdminPage AdminP;
        public ConfirmLogout()
        {
            InitializeComponent();
        }

        private void LoginYes_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginP = new LoginPage();
            LoginP.Show();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ConfirmExit_Click(object sender, EventArgs e)
        {
            this.Hide();

            AdminP = new AdminPage();
            AdminP.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ConfirmLogout_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            LoginP = new LoginPage();
            LoginP.Show();


        }
    }
}
