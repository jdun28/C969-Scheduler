namespace ScheduleProgram
{
    partial class ApptByMonth
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
            this.apptByMonDgv = new System.Windows.Forms.DataGridView();
            this.monthReportLbl = new System.Windows.Forms.Label();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.monthLbl = new System.Windows.Forms.Label();
            this.demoLbl = new System.Windows.Forms.Label();
            this.contractRevLbl = new System.Windows.Forms.Label();
            this.presentationLbl = new System.Windows.Forms.Label();
            this.scrumLbl = new System.Windows.Forms.Label();
            this.totalApptsLbl = new System.Windows.Forms.Label();
            this.apptTypeLbl = new System.Windows.Forms.Label();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.contractReviewCount = new System.Windows.Forms.Label();
            this.demoCount = new System.Windows.Forms.Label();
            this.presentationCount = new System.Windows.Forms.Label();
            this.scrumCount = new System.Windows.Forms.Label();
            this.totalCount = new System.Windows.Forms.Label();
            this.mainScreenBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptByMonDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // apptByMonDgv
            // 
            this.apptByMonDgv.AllowUserToAddRows = false;
            this.apptByMonDgv.AllowUserToDeleteRows = false;
            this.apptByMonDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptByMonDgv.Location = new System.Drawing.Point(36, 172);
            this.apptByMonDgv.Name = "apptByMonDgv";
            this.apptByMonDgv.ReadOnly = true;
            this.apptByMonDgv.RowHeadersVisible = false;
            this.apptByMonDgv.RowHeadersWidth = 82;
            this.apptByMonDgv.RowTemplate.Height = 33;
            this.apptByMonDgv.Size = new System.Drawing.Size(612, 340);
            this.apptByMonDgv.TabIndex = 0;
            // 
            // monthReportLbl
            // 
            this.monthReportLbl.AutoSize = true;
            this.monthReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthReportLbl.Location = new System.Drawing.Point(28, 52);
            this.monthReportLbl.Name = "monthReportLbl";
            this.monthReportLbl.Size = new System.Drawing.Size(563, 37);
            this.monthReportLbl.TabIndex = 1;
            this.monthReportLbl.Text = "Appointments Type Count By Month";
            // 
            // monthCB
            // 
            this.monthCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(141, 113);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(199, 45);
            this.monthCB.TabIndex = 2;
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.Location = new System.Drawing.Point(29, 121);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(106, 37);
            this.monthLbl.TabIndex = 3;
            this.monthLbl.Text = "Month";
            // 
            // demoLbl
            // 
            this.demoLbl.AutoSize = true;
            this.demoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoLbl.Location = new System.Drawing.Point(29, 634);
            this.demoLbl.Name = "demoLbl";
            this.demoLbl.Size = new System.Drawing.Size(189, 31);
            this.demoLbl.TabIndex = 5;
            this.demoLbl.Text = "Demo Count =";
            // 
            // contractRevLbl
            // 
            this.contractRevLbl.AutoSize = true;
            this.contractRevLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractRevLbl.Location = new System.Drawing.Point(27, 592);
            this.contractRevLbl.Name = "contractRevLbl";
            this.contractRevLbl.Size = new System.Drawing.Size(325, 31);
            this.contractRevLbl.TabIndex = 6;
            this.contractRevLbl.Text = "Contract Review Count = ";
            // 
            // presentationLbl
            // 
            this.presentationLbl.AutoSize = true;
            this.presentationLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationLbl.Location = new System.Drawing.Point(29, 680);
            this.presentationLbl.Name = "presentationLbl";
            this.presentationLbl.Size = new System.Drawing.Size(270, 31);
            this.presentationLbl.TabIndex = 7;
            this.presentationLbl.Text = "Presentation Count =";
            // 
            // scrumLbl
            // 
            this.scrumLbl.AutoSize = true;
            this.scrumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumLbl.Location = new System.Drawing.Point(29, 726);
            this.scrumLbl.Name = "scrumLbl";
            this.scrumLbl.Size = new System.Drawing.Size(115, 31);
            this.scrumLbl.TabIndex = 8;
            this.scrumLbl.Text = "Scrum =";
            // 
            // totalApptsLbl
            // 
            this.totalApptsLbl.AutoSize = true;
            this.totalApptsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalApptsLbl.Location = new System.Drawing.Point(29, 768);
            this.totalApptsLbl.Name = "totalApptsLbl";
            this.totalApptsLbl.Size = new System.Drawing.Size(278, 31);
            this.totalApptsLbl.TabIndex = 9;
            this.totalApptsLbl.Text = "Total Appointments = ";
            // 
            // apptTypeLbl
            // 
            this.apptTypeLbl.AutoSize = true;
            this.apptTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTypeLbl.Location = new System.Drawing.Point(29, 536);
            this.apptTypeLbl.Name = "apptTypeLbl";
            this.apptTypeLbl.Size = new System.Drawing.Size(283, 33);
            this.apptTypeLbl.TabIndex = 10;
            this.apptTypeLbl.Text = "Appointment Types";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.Location = new System.Drawing.Point(699, 224);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(348, 74);
            this.generateReportBtn.TabIndex = 11;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // contractReviewCount
            // 
            this.contractReviewCount.AutoSize = true;
            this.contractReviewCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractReviewCount.Location = new System.Drawing.Point(358, 590);
            this.contractReviewCount.Name = "contractReviewCount";
            this.contractReviewCount.Size = new System.Drawing.Size(0, 33);
            this.contractReviewCount.TabIndex = 12;
            // 
            // demoCount
            // 
            this.demoCount.AutoSize = true;
            this.demoCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.demoCount.Location = new System.Drawing.Point(224, 632);
            this.demoCount.Name = "demoCount";
            this.demoCount.Size = new System.Drawing.Size(0, 33);
            this.demoCount.TabIndex = 13;
            // 
            // presentationCount
            // 
            this.presentationCount.AutoSize = true;
            this.presentationCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentationCount.Location = new System.Drawing.Point(305, 678);
            this.presentationCount.Name = "presentationCount";
            this.presentationCount.Size = new System.Drawing.Size(0, 33);
            this.presentationCount.TabIndex = 14;
            // 
            // scrumCount
            // 
            this.scrumCount.AutoSize = true;
            this.scrumCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scrumCount.Location = new System.Drawing.Point(150, 724);
            this.scrumCount.Name = "scrumCount";
            this.scrumCount.Size = new System.Drawing.Size(0, 33);
            this.scrumCount.TabIndex = 15;
            // 
            // totalCount
            // 
            this.totalCount.AutoSize = true;
            this.totalCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCount.Location = new System.Drawing.Point(313, 768);
            this.totalCount.Name = "totalCount";
            this.totalCount.Size = new System.Drawing.Size(0, 33);
            this.totalCount.TabIndex = 16;
            // 
            // mainScreenBtn
            // 
            this.mainScreenBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainScreenBtn.Location = new System.Drawing.Point(699, 355);
            this.mainScreenBtn.Name = "mainScreenBtn";
            this.mainScreenBtn.Size = new System.Drawing.Size(348, 74);
            this.mainScreenBtn.TabIndex = 17;
            this.mainScreenBtn.Text = "Return to Main Screen";
            this.mainScreenBtn.UseVisualStyleBackColor = true;
            this.mainScreenBtn.Click += new System.EventHandler(this.mainScreenBtn_Click);
            // 
            // ApptByMonth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 864);
            this.Controls.Add(this.mainScreenBtn);
            this.Controls.Add(this.totalCount);
            this.Controls.Add(this.scrumCount);
            this.Controls.Add(this.presentationCount);
            this.Controls.Add(this.demoCount);
            this.Controls.Add(this.contractReviewCount);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.apptTypeLbl);
            this.Controls.Add(this.totalApptsLbl);
            this.Controls.Add(this.scrumLbl);
            this.Controls.Add(this.presentationLbl);
            this.Controls.Add(this.contractRevLbl);
            this.Controls.Add(this.demoLbl);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.monthReportLbl);
            this.Controls.Add(this.apptByMonDgv);
            this.Name = "ApptByMonth";
            this.Text = "Appointments By Month Report";
            ((System.ComponentModel.ISupportInitialize)(this.apptByMonDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apptByMonDgv;
        private System.Windows.Forms.Label monthReportLbl;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.Label demoLbl;
        private System.Windows.Forms.Label contractRevLbl;
        private System.Windows.Forms.Label presentationLbl;
        private System.Windows.Forms.Label scrumLbl;
        private System.Windows.Forms.Label totalApptsLbl;
        private System.Windows.Forms.Label apptTypeLbl;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.Label contractReviewCount;
        private System.Windows.Forms.Label demoCount;
        private System.Windows.Forms.Label presentationCount;
        private System.Windows.Forms.Label scrumCount;
        private System.Windows.Forms.Label totalCount;
        private System.Windows.Forms.Button mainScreenBtn;
    }
}