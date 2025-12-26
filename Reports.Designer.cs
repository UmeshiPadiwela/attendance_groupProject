namespace attendance_groupProject
{
    partial class Reports
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.dgvRepos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmployeeID = new System.Windows.Forms.ComboBox();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnIndividualEmpRpt = new System.Windows.Forms.Button();
            this.btnMonthlySum = new System.Windows.Forms.Button();
            this.btnDailyRpt = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Snow;
            this.pnlHeader.Controls.Add(this.lblWelcome);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlHeader.ForeColor = System.Drawing.Color.White;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1358, 60);
            this.pnlHeader.TabIndex = 17;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblWelcome.Location = new System.Drawing.Point(627, 16);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(105, 29);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Reports";
            // 
            // dgvRepos
            // 
            this.dgvRepos.AllowUserToAddRows = false;
            this.dgvRepos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRepos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRepos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRepos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRepos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRepos.Location = new System.Drawing.Point(0, 60);
            this.dgvRepos.Name = "dgvRepos";
            this.dgvRepos.ReadOnly = true;
            this.dgvRepos.RowHeadersWidth = 51;
            this.dgvRepos.RowTemplate.Height = 24;
            this.dgvRepos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRepos.Size = new System.Drawing.Size(1358, 634);
            this.dgvRepos.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbEmployeeID);
            this.panel1.Controls.Add(this.btnExport);
            this.panel1.Controls.Add(this.btnGenerate);
            this.panel1.Controls.Add(this.btnIndividualEmpRpt);
            this.panel1.Controls.Add(this.btnMonthlySum);
            this.panel1.Controls.Add(this.btnDailyRpt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 291);
            this.panel1.TabIndex = 21;
            // 
            // cmbEmployeeID
            // 
            this.cmbEmployeeID.FormattingEnabled = true;
            this.cmbEmployeeID.Location = new System.Drawing.Point(691, 163);
            this.cmbEmployeeID.Name = "cmbEmployeeID";
            this.cmbEmployeeID.Size = new System.Drawing.Size(121, 24);
            this.cmbEmployeeID.TabIndex = 26;
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(712, 211);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(310, 54);
            this.btnExport.TabIndex = 21;
            this.btnExport.Text = "Export PDF";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(336, 211);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(310, 54);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            // 
            // btnIndividualEmpRpt
            // 
            this.btnIndividualEmpRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIndividualEmpRpt.Location = new System.Drawing.Point(336, 151);
            this.btnIndividualEmpRpt.Name = "btnIndividualEmpRpt";
            this.btnIndividualEmpRpt.Size = new System.Drawing.Size(310, 54);
            this.btnIndividualEmpRpt.TabIndex = 23;
            this.btnIndividualEmpRpt.Text = "Individual Employee Report";
            this.btnIndividualEmpRpt.UseVisualStyleBackColor = true;
            // 
            // btnMonthlySum
            // 
            this.btnMonthlySum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonthlySum.Location = new System.Drawing.Point(336, 91);
            this.btnMonthlySum.Name = "btnMonthlySum";
            this.btnMonthlySum.Size = new System.Drawing.Size(310, 54);
            this.btnMonthlySum.TabIndex = 24;
            this.btnMonthlySum.Text = "Monthly Summary";
            this.btnMonthlySum.UseVisualStyleBackColor = true;
            // 
            // btnDailyRpt
            // 
            this.btnDailyRpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDailyRpt.Location = new System.Drawing.Point(336, 26);
            this.btnDailyRpt.Name = "btnDailyRpt";
            this.btnDailyRpt.Size = new System.Drawing.Size(310, 54);
            this.btnDailyRpt.TabIndex = 25;
            this.btnDailyRpt.Text = "Daily Report";
            this.btnDailyRpt.UseVisualStyleBackColor = true;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 694);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvRepos);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "Reports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRepos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.DataGridView dgvRepos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbEmployeeID;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnIndividualEmpRpt;
        private System.Windows.Forms.Button btnMonthlySum;
        private System.Windows.Forms.Button btnDailyRpt;
    }
}