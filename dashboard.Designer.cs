namespace attendance_groupProject
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnAttendanceViewer = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEmployeeManagement = new System.Windows.Forms.Button();
            this.btnQrGenerator = new System.Windows.Forms.Button();
            this.btnAttendanceScanner = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlLoad = new System.Windows.Forms.Panel();
            this.pnlMenu.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Snow;
            this.pnlMenu.Controls.Add(this.btnAttendanceViewer);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.btnEmployeeManagement);
            this.pnlMenu.Controls.Add(this.btnQrGenerator);
            this.pnlMenu.Controls.Add(this.btnAttendanceScanner);
            this.pnlMenu.Controls.Add(this.btnReports);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 60);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(548, 741);
            this.pnlMenu.TabIndex = 13;
            // 
            // btnAttendanceViewer
            // 
            this.btnAttendanceViewer.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAttendanceViewer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceViewer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceViewer.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceViewer.Location = new System.Drawing.Point(60, 477);
            this.btnAttendanceViewer.Name = "btnAttendanceViewer";
            this.btnAttendanceViewer.Size = new System.Drawing.Size(429, 50);
            this.btnAttendanceViewer.TabIndex = 7;
            this.btnAttendanceViewer.Text = "Attendance Viewer";
            this.btnAttendanceViewer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceViewer.UseVisualStyleBackColor = false;
            this.btnAttendanceViewer.Click += new System.EventHandler(this.btnAttendanceViewer_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Location = new System.Drawing.Point(60, 647);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(429, 50);
            this.btnLogOut.TabIndex = 6;
            this.btnLogOut.Text = "  Log Out";
            this.btnLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEmployeeManagement
            // 
            this.btnEmployeeManagement.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEmployeeManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployeeManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployeeManagement.ForeColor = System.Drawing.Color.White;
            this.btnEmployeeManagement.Location = new System.Drawing.Point(60, 222);
            this.btnEmployeeManagement.Name = "btnEmployeeManagement";
            this.btnEmployeeManagement.Size = new System.Drawing.Size(429, 50);
            this.btnEmployeeManagement.TabIndex = 5;
            this.btnEmployeeManagement.Text = "Employee Management";
            this.btnEmployeeManagement.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmployeeManagement.UseVisualStyleBackColor = false;
            this.btnEmployeeManagement.Click += new System.EventHandler(this.btnEmployeeManagement_Click);
            // 
            // btnQrGenerator
            // 
            this.btnQrGenerator.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnQrGenerator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQrGenerator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQrGenerator.ForeColor = System.Drawing.Color.White;
            this.btnQrGenerator.Location = new System.Drawing.Point(60, 307);
            this.btnQrGenerator.Name = "btnQrGenerator";
            this.btnQrGenerator.Size = new System.Drawing.Size(429, 50);
            this.btnQrGenerator.TabIndex = 5;
            this.btnQrGenerator.Text = "QR Generator";
            this.btnQrGenerator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQrGenerator.UseVisualStyleBackColor = false;
            this.btnQrGenerator.Click += new System.EventHandler(this.btnQrGenerator_Click);
            // 
            // btnAttendanceScanner
            // 
            this.btnAttendanceScanner.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAttendanceScanner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendanceScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttendanceScanner.ForeColor = System.Drawing.Color.White;
            this.btnAttendanceScanner.Location = new System.Drawing.Point(60, 392);
            this.btnAttendanceScanner.Name = "btnAttendanceScanner";
            this.btnAttendanceScanner.Size = new System.Drawing.Size(429, 50);
            this.btnAttendanceScanner.TabIndex = 5;
            this.btnAttendanceScanner.Text = "Attendance Scanner";
            this.btnAttendanceScanner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAttendanceScanner.UseVisualStyleBackColor = false;
            this.btnAttendanceScanner.Click += new System.EventHandler(this.btnAttendanceScanner_Click);
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Location = new System.Drawing.Point(60, 562);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(429, 50);
            this.btnReports.TabIndex = 3;
            this.btnReports.Text = "Reports";
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Snow;
            this.pnlHeader.Controls.Add(this.lblDateTime);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1924, 60);
            this.pnlHeader.TabIndex = 14;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblDateTime.Location = new System.Drawing.Point(1489, 24);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(0, 17);
            this.lblDateTime.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1376, 119);
            this.panel2.TabIndex = 83;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(537, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(386, 37);
            this.label6.TabIndex = 11;
            this.label6.Text = "Employee Attendance Maker";
            // 
            // pnlLoad
            // 
            this.pnlLoad.BackColor = System.Drawing.Color.Snow;
            this.pnlLoad.Controls.Add(this.panel2);
            this.pnlLoad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLoad.Location = new System.Drawing.Point(548, 60);
            this.pnlLoad.Name = "pnlLoad";
            this.pnlLoad.Size = new System.Drawing.Size(1376, 741);
            this.pnlLoad.TabIndex = 15;
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 801);
            this.Controls.Add(this.pnlLoad);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlHeader);
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlLoad.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnAttendanceViewer;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnQrGenerator;
        private System.Windows.Forms.Button btnAttendanceScanner;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlLoad;
        private System.Windows.Forms.Button btnEmployeeManagement;
    }
}