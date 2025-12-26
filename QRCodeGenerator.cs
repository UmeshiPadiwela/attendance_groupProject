using QRCoder;
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
    public partial class QRCodeGenerator : Form
    {
        public QRCodeGenerator()
        {
            InitializeComponent();
        }

        private void QRCodeGenerator_Load(object sender, EventArgs e)
        {
            LoadEmployeeIDs();
        }
        private void LoadEmployeeIDs()
        {
            string connectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;";
            string query = "SELECT EmployeeID FROM Employees"; // Adjust table & column names

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbEmpID.Items.Clear();
                    while (reader.Read())
                    {
                        cmbEmpID.Items.Add(reader["EmployeeID"].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Employee IDs: " + ex.Message);
            }
        }

        private void btnGenerateQR_Click(object sender, EventArgs e)
        {
            if (cmbEmpID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Employee ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string empID = cmbEmpID.SelectedItem.ToString(); // Get selected Employee ID

            try
            {
                // Generate QR code using the selected EmpID
                QRCoder.QRCodeGenerator qrGenerator = new QRCoder.QRCodeGenerator();
                QRCodeData qrCodeData = qrGenerator.CreateQrCode(empID, QRCoder.QRCodeGenerator.ECCLevel.Q);
                QRCode qrCode = new QRCode(qrCodeData);
                Bitmap qrCodeImage = qrCode.GetGraphic(20); // Pixel size
                picQR.Image = qrCodeImage;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating QR code: " + ex.Message);
            }
        }
        }
}
      