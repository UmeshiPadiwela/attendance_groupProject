using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Xml.Linq;
using ZXing.OneD;

namespace attendance_groupProject
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }
        private void LoadReport(string query, Dictionary<string, object> parameters = null)
        {
            string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                if (parameters != null)
                {
                    foreach (var param in parameters)
                        cmd.Parameters.AddWithValue(param.Key, param.Value);
                }

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRepos.DataSource = dt; // This fills your gray area
            }
        }
        private void btnDailyRpt_Click(object sender, EventArgs e)
        {
            string query = "SELECT EmployeeID, TimeIn, TimeOut, Status FROM Attendance WHERE Cast(Date as Date) = Cast(GetDate() as Date)";
            LoadReport(query);
        }

        private void btnMonthlySum_Click(object sender, EventArgs e)
        {
            string query = "SELECT EmployeeID, Date, TimeIn, TimeOut FROM Attendance WHERE MONTH(Date) = MONTH(GetDate()) AND YEAR(Date) = YEAR(GetDate())";
            LoadReport(query);
        }

        private void btnIndividualEmpRpt_Click(object sender, EventArgs e)
        {
            if (cmbEmployeeID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an Employee ID first.");
                return;
            }

            string query = "SELECT Date, TimeIn, TimeOut, Status FROM Attendance WHERE EmployeeID = @empID";
            var pars = new Dictionary<string, object> { { "@empID", cmbEmployeeID.SelectedItem.ToString() } };
            LoadReport(query, pars);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            // Ensure the DataGridView has data before exporting
            if (dgvRepos.Rows.Count == 0 || (dgvRepos.Rows.Count == 1 && dgvRepos.Rows[0].IsNewRow))
            {
                MessageBox.Show("No data available to export.", "Empty Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog { Filter = "PDF (*.pdf)|*.pdf", FileName = "Attendance_Report.pdf" };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (PdfWriter writer = new PdfWriter(sfd.FileName))
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        iText.Layout.Document doc = new iText.Layout.Document(pdf);

                        // Fixed ambiguous Paragraph reference
                        doc.Add(new iText.Layout.Element.Paragraph("Attendance Report")
                            .SetFontSize(18)
                            .SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER));

                        doc.Add(new iText.Layout.Element.Paragraph("Generated on: " + DateTime.Now.ToString("f")));

                        // Create Table
                        iText.Layout.Element.Table table = new iText.Layout.Element.Table(dgvRepos.ColumnCount);
                        table.SetWidth(iText.Layout.Properties.UnitValue.CreatePercentValue(100));

                        // Add Headers
                        foreach (DataGridViewColumn col in dgvRepos.Columns)
                        {
                            table.AddHeaderCell(new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph(col.HeaderText)));
                        }

                        // Add Rows
                        foreach (DataGridViewRow row in dgvRepos.Rows)
                        {
                            if (!row.IsNewRow)
                            {
                                foreach (DataGridViewCell cell in row.Cells)
                                {
                                    string cellValue = cell.Value?.ToString() ?? "";
                                    table.AddCell(new iText.Layout.Element.Cell().Add(new iText.Layout.Element.Paragraph(cellValue)));
                                }
                            }
                        }

                        doc.Add(table);
                        doc.Close();
                    }
                    MessageBox.Show("PDF Saved Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
