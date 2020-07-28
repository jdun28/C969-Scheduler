namespace ScheduleProgram
{
    partial class UserSchedule
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
            this.userDgv = new System.Windows.Forms.DataGridView();
            this.userSchedLbl = new System.Windows.Forms.Label();
            this.userCB = new System.Windows.Forms.ComboBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.returnMainBtn = new System.Windows.Forms.Button();
            this.generateReportBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // userDgv
            // 
            this.userDgv.AllowUserToAddRows = false;
            this.userDgv.AllowUserToDeleteRows = false;
            this.userDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDgv.Location = new System.Drawing.Point(36, 172);
            this.userDgv.Name = "userDgv";
            this.userDgv.ReadOnly = true;
            this.userDgv.RowHeadersVisible = false;
            this.userDgv.RowHeadersWidth = 82;
            this.userDgv.RowTemplate.Height = 33;
            this.userDgv.Size = new System.Drawing.Size(1054, 472);
            this.userDgv.TabIndex = 0;
            // 
            // userSchedLbl
            // 
            this.userSchedLbl.AutoSize = true;
            this.userSchedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSchedLbl.Location = new System.Drawing.Point(29, 52);
            this.userSchedLbl.Name = "userSchedLbl";
            this.userSchedLbl.Size = new System.Drawing.Size(238, 37);
            this.userSchedLbl.TabIndex = 1;
            this.userSchedLbl.Text = "User Schedule";
            // 
            // userCB
            // 
            this.userCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCB.FormattingEnabled = true;
            this.userCB.Location = new System.Drawing.Point(819, 117);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(271, 39);
            this.userCB.TabIndex = 2;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(729, 119);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(84, 37);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "User";
            // 
            // returnMainBtn
            // 
            this.returnMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainBtn.Location = new System.Drawing.Point(742, 659);
            this.returnMainBtn.Name = "returnMainBtn";
            this.returnMainBtn.Size = new System.Drawing.Size(348, 74);
            this.returnMainBtn.TabIndex = 15;
            this.returnMainBtn.Text = "Return to Main Screen";
            this.returnMainBtn.UseVisualStyleBackColor = true;
            this.returnMainBtn.Click += new System.EventHandler(this.returnMainBtn_Click);
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.Location = new System.Drawing.Point(388, 659);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(348, 74);
            this.generateReportBtn.TabIndex = 14;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // UserSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 808);
            this.Controls.Add(this.returnMainBtn);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.userSchedLbl);
            this.Controls.Add(this.userDgv);
            this.Name = "UserSchedule";
            this.Text = "Appointments By Month Report";
            this.Load += new System.EventHandler(this.UserSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDgv;
        private System.Windows.Forms.Label userSchedLbl;
        private System.Windows.Forms.ComboBox userCB;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Button returnMainBtn;
        private System.Windows.Forms.Button generateReportBtn;
    }
}