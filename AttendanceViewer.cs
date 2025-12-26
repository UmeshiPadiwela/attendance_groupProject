using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace attendance_groupProject
{
    public partial class AttendanceViewer : Form
    {
        string connectionString = @"Data Source=YOUR_SERVER;Initial Catalog=EmployeeDB;Integrated Security=True";
        public AttendanceViewer()
        {
            InitializeComponent();
        }

        private void AttendanceViewer_Load(object sender, EventArgs e)
        {
            // Fill the Employee ID dropdown from the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT EmployeeID FROM Employees";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmbEmpID.Items.Add(reader["EmployeeID"].ToString());
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Base SQL Query
                    string query = "SELECT EmployeeID, ScanDate, TimeIn, TimeOut, Status FROM AttendanceRecords WHERE 1=1";

                    // Add Filter for Date if selected
                    if (!string.IsNullOrEmpty(dtpFilterDate.Text))
                    {
                        query += " AND ScanDate = @date";
                    }

                    // Add Filter for Employee ID if selected
                    if (cmbEmpID.SelectedIndex != -1)
                    {
                        query += " AND EmployeeID = @empID";
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                    // Add parameters to prevent SQL Injection
                    adapter.SelectCommand.Parameters.AddWithValue("@date", dtpFilterDate.Value.ToShortDateString());
                    adapter.SelectCommand.Parameters.AddWithValue("@empID", cmbEmpID.SelectedItem.ToString());

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Bind the results to your DataGridView
                    dgvAteendanveViewer.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }
    }
}
