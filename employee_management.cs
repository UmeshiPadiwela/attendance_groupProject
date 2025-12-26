using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace attendance_groupProject
{
    public partial class employee_management : Form
    {
        SqlConnection con = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;");

        public employee_management()
        {
            InitializeComponent();
        }
        private void employee_management_Load_1(object sender, EventArgs e)
        {
            LoadEmployeeData();
            GenerateEmployeeID();
        }
        private void LoadEmployeeData()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;"))
            {
                string query = "SELECT * FROM Employees";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt); // Fill the table first

                dgvEmployeeData.DataSource = null; // Clear previous binding
                dgvEmployeeData.AutoGenerateColumns = true; // Ensure this is true
                dgvEmployeeData.DataSource = dt; // Now bind the data
            }
        }

        private void dgvEmployeeData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the selected row
                DataGridViewRow row = dgvEmployeeData.Rows[e.RowIndex];

                // Fill the textboxes and controls using column names from your SSMS table
                txtEmpID.Text = row.Cells["EmployeeID"].Value.ToString();
                txtFName.Text = row.Cells["FullName"].Value.ToString();
                txtNIC.Text = row.Cells["NIC"].Value.ToString();
                txtAddress.Text = row.Cells["Address"].Value.ToString();
                txtContact.Text = row.Cells["ContactNo"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();

                // Match the Job Role in the ComboBox
                cmbJobRole.Text = row.Cells["JobRole"].Value.ToString();

                // Load the Salary
                txtSalary.Text = row.Cells["Salary"].Value.ToString();
            }
        }
        private string GenerateEmployeeID()
        {
            string newID = "EMP001"; // Default for the first employee
            try
            {
                // Use the global connection 'con' you already defined
                if (con.State == ConnectionState.Closed) con.Open();

                // Get the last ID added to the table
                string query = "SELECT TOP 1 EmployeeID FROM Employees ORDER BY EmployeeID DESC";
                SqlCommand cmd = new SqlCommand(query, con);
                object result = cmd.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    string lastID = result.ToString();
                    // Extract the number part (index 3 onwards) and increment it
                    int num = int.Parse(lastID.Substring(3));
                    num++;
                    newID = "EMP" + num.ToString("D3"); // Format back to EMP00X
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ID Generation Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return newID;
        }
        private void ClearFields()
        {
            // Clear all TextBoxes
            txtEmpID.Clear();
            txtFName.Clear();
            txtNIC.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtAddress.Clear();
            txtSalary.Clear();

            // Clear the Search box at the top
            txtSearchID.Clear();

            // Reset the Job Role ComboBox
            cmbJobRole.SelectedIndex = -1;

            // Optional: Reset focus to the first input field
            txtFName.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure required fields are not empty
            if (string.IsNullOrWhiteSpace(txtFName.Text) || string.IsNullOrWhiteSpace(txtNIC.Text))
            {
                MessageBox.Show("Please enter the Full Name and NIC.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Generate the New ID
            string newID = GenerateEmployeeID();

            // 3. Insert into Database
            try
            {
                string query = @"INSERT INTO Employees (EmployeeID, FullName, NIC, Address, ContactNo, Email, JobRole, Salary) 
                         VALUES (@id, @name, @nic, @address, @contact, @email, @role, @salary)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", newID);
                cmd.Parameters.AddWithValue("@name", txtFName.Text.Trim());
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cmbJobRole.Text); // Get text from ComboBox
                cmd.Parameters.AddWithValue("@salary", decimal.Parse(txtSalary.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Employee " + newID + " added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 4. Update the UI
                LoadEmployeeData(); // Refresh your DataGridView
                ClearFields();      // Clear all textboxes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while saving: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // 1. Validation: Ensure an ID is selected and required fields aren't empty
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please select an employee from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Database Update
            try
            {
                // Using the global connection 'con'
                string query = @"UPDATE Employees SET 
                         FullName = @name, 
                         NIC = @nic, 
                         Address = @address, 
                         ContactNo = @contact, 
                         Email = @email, 
                         JobRole = @role, 
                         Salary = @salary 
                         WHERE EmployeeID = @id";

                SqlCommand cmd = new SqlCommand(query, con);

                // Match these parameters exactly to the @ names in the query above
                cmd.Parameters.AddWithValue("@id", txtEmpID.Text);
                cmd.Parameters.AddWithValue("@name", txtFName.Text.Trim());
                cmd.Parameters.AddWithValue("@nic", txtNIC.Text.Trim());
                cmd.Parameters.AddWithValue("@address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@contact", txtContact.Text.Trim());
                cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@role", cmbJobRole.Text);
                cmd.Parameters.AddWithValue("@salary", decimal.Parse(txtSalary.Text));

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery();
                con.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Employee details updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 3. Refresh the DataGridView and Clear fields
                    LoadEmployeeData();
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Update failed. Employee ID not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message);
                if (con.State == ConnectionState.Open) con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // 1. Check if an Employee ID is selected
            if (string.IsNullOrWhiteSpace(txtEmpID.Text))
            {
                MessageBox.Show("Please select an employee from the list to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Ask for Confirmation
            DialogResult result = MessageBox.Show("Are you sure you want to delete employee " + txtEmpID.Text + "? This action cannot be undone.", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // 3. SQL Delete Query
                    string query = "DELETE FROM Employees WHERE EmployeeID = @id";

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", txtEmpID.Text);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // 4. Refresh UI
                        LoadEmployeeData();
                        ClearFields();
                    }
                    else
                    {
                        MessageBox.Show("Delete failed. Employee ID not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error during deletion: " + ex.Message);
                    if (con.State == ConnectionState.Open) con.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the DataTable from the DataGridView's DataSource
                DataTable dt = dgvEmployeeData.DataSource as DataTable;

                if (dt != null)
                {
                    // Filter by EmployeeID or FullName using the 'LIKE' operator
                    // '%{0}%' means it will find the text anywhere in the string
                    dt.DefaultView.RowFilter = string.Format("EmployeeID LIKE '%{0}%' OR FullName LIKE '%{0}%'", txtSearchID.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Search Error: " + ex.Message);
            }
        }
    }
}
