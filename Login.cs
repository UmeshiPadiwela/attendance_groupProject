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

namespace attendance_groupProject
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = cmbUsers.Text.Trim();

            if (username == "" || password == "" || role == "")
            {
                MessageBox.Show("Please fill the all fields!", "Logoin failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (role == "Admin")
            {
                if (username == "admin" && password == "123")
                {
                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard adminform = new dashboard();
                    adminform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (role == "HR Manager")
            {
                if (username == "HRM" && password == "123")
                {
                    MessageBox.Show("Welcome, HR Manager!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard HRMform = new dashboard();
                    HRMform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (role == "Clerk")
            {
                if (username == "Clerk" && password == "123")
                {
                    MessageBox.Show("Welcome, Clerk!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dashboard clerkform = new dashboard();
                    clerkform.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a valid role!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
