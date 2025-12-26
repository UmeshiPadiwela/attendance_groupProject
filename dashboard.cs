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
    public partial class dashboard : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=EmployeeDB;Integrated Security=True");

        public string userRole;

        public dashboard()
        {
            InitializeComponent();
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd | hh:mm tt");

            if (userRole == "Admin")
            {
                btnQrGenerator.Enabled = true;
                btnReports.Enabled = true;
                btnAttendanceScanner.Enabled = true;
            }
            else if (userRole == "Clerk")
            {
                btnQrGenerator.Enabled = false; // cannot delete/add
                btnReports.Enabled = false;            // no report access
                btnAttendanceScanner.Enabled = true;   // can mark attendance
            }
            else if (userRole == "HR")
            {
                btnQrGenerator.Enabled = true;  // maybe only edit
                btnReports.Enabled = true;             // can view reports
                btnAttendanceScanner.Enabled = false;  // cannot scan QR
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblDateTime.Text = DateTime.Now.ToString("yyyy/MM/dd | hh:mm tt");
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            pnlLoad.Controls.Clear();
            employee_management empForm = new employee_management();
            empForm.TopLevel = false;
            pnlLoad.Controls.Add(empForm);
            empForm.Show();
        }

        private void btnQrGenerator_Click(object sender, EventArgs e)
        {
            pnlLoad.Controls.Clear();
            QRCodeGenerator qrform = new QRCodeGenerator();
            qrform.TopLevel = false;
            pnlLoad.Controls.Add(qrform);
            qrform.Show();
        }

        private void btnAttendanceScanner_Click(object sender, EventArgs e)
        {
            pnlLoad.Controls.Clear();
            AttendanceScanner AttendanceSform = new AttendanceScanner();
            AttendanceSform.TopLevel = false;
            pnlLoad.Controls.Add(AttendanceSform);
            AttendanceSform.Show();
        }

        private void btnAttendanceViewer_Click(object sender, EventArgs e)
        {
            pnlLoad.Controls.Clear();
            AttendanceViewer attendanceViewer = new AttendanceViewer();
            attendanceViewer.TopLevel = false;
            pnlLoad.Controls.Add((AttendanceViewer)attendanceViewer);
            attendanceViewer.Show();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            pnlLoad.Controls.Clear();
            Reports reportform = new Reports();
            reportform.TopLevel = false;
            pnlLoad.Controls.Add(reportform);
            reportform.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login loginform = new Login();
            loginform.Show();

            // Close the current dashboard
            this.Close();
        }
    }
}
