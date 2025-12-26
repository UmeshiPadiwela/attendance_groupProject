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
using ZXing;
using AForge.Video;
using AForge.Video.DirectShow;
using QRCoder;

namespace attendance_groupProject
{
    public partial class AttendanceScanner : Form
    {
        // --- Variables ---
        private FilterInfoCollection captureDevices;
        private VideoCaptureDevice videoSource;

        public AttendanceScanner()
        {
            InitializeComponent();
        }
        private DataTable attendanceTable = new DataTable();
        // --- Form Setup ---
        private void AttendanceScanner_Load(object sender, EventArgs e)
        {
            // Detect all available cameras (Webcam or Mobile via DroidCam)
            captureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            // Setup the columns for your DataGridView
            attendanceTable.Columns.Add("Employee ID");
            attendanceTable.Columns.Add("Date");
            attendanceTable.Columns.Add("Time In");
            attendanceTable.Columns.Add("Time Out");
            attendanceTable.Columns.Add("Status");

            // Bind the Table to the DataGridView
            dgvScanner.DataSource = attendanceTable;
        }

        // --- Camera Logic ---
        private void btnStartScan_Click(object sender, EventArgs e)
        {
            if (captureDevices.Count > 0)
            {
                // Start the first available camera
                videoSource = new VideoCaptureDevice(captureDevices[0].MonikerString);
                videoSource.NewFrame += VideoSource_NewFrame;
                videoSource.Start();
                txtStatus.Text = "Scanner Active...";
            }
            else
            {
                MessageBox.Show("No camera detected. Please check your connection.");
            }
        }

        private void btnStopScan_Click(object sender, EventArgs e)
        {
            StopCamera();
            txtStatus.Text = "Scanner Stopped.";
        }

        private void VideoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                // 1. Capture the current frame
                Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

                // 2. Scan for QR code
                BarcodeReader reader = new BarcodeReader();
                var result = reader.Decode(bitmap);

                // 3. Update PictureBox (using Invoke to avoid Cross-Thread errors)
                this.Invoke(new MethodInvoker(delegate
                {
                    if (pictureBox1.Image != null) pictureBox1.Image.Dispose();
                    pictureBox1.Image = bitmap;
                }));

                // 4. If QR is found, process the data
                if (result != null)
                {
                    this.Invoke(new MethodInvoker(delegate
                    {
                        ProcessAttendance(result.Text);
                    }));
                }
            }
            catch (Exception ex)
            {
                // Log errors without crashing the camera thread
                Console.WriteLine("Frame Error: " + ex.Message);
            }
        }

        // --- Attendance Logic ---
        private void ProcessAttendance(string qrData)
        {
            // 1. Fill the TextBoxes (as we did before)
            txtEmpID.Text = qrData;
            string timeIn = DateTime.Now.ToShortTimeString();
            txtTimeIn.Text = timeIn;
            txtStatus.Text = "Success";

            // 2. Add the data to the DataGridView (The DataTable)
            attendanceTable.Rows.Add(qrData, timeIn, "Present");

            Console.Beep();
            StopCamera();

            MessageBox.Show("Attendance recorded for " + qrData);
        }

        // --- Cleanup Logic ---
        private void StopCamera()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
                videoSource = null;

                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            StopCamera();
            base.OnFormClosing(e);
        }
    }
}
