namespace ScheduleProgram
{
    partial class ApptByCust
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
            this.apptByCustDgv = new System.Windows.Forms.DataGridView();
            this.custReportLbl = new System.Windows.Forms.Label();
            this.custCB = new System.Windows.Forms.ComboBox();
            this.custLbl = new System.Windows.Forms.Label();
            this.generateReportBtn = new System.Windows.Forms.Button();
            this.returnMainBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.apptByCustDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // apptByCustDgv
            // 
            this.apptByCustDgv.AllowUserToAddRows = false;
            this.apptByCustDgv.AllowUserToDeleteRows = false;
            this.apptByCustDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptByCustDgv.Location = new System.Drawing.Point(36, 172);
            this.apptByCustDgv.Name = "apptByCustDgv";
            this.apptByCustDgv.ReadOnly = true;
            this.apptByCustDgv.RowHeadersVisible = false;
            this.apptByCustDgv.RowHeadersWidth = 82;
            this.apptByCustDgv.RowTemplate.Height = 33;
            this.apptByCustDgv.Size = new System.Drawing.Size(814, 340);
            this.apptByCustDgv.TabIndex = 0;
            // 
            // custReportLbl
            // 
            this.custReportLbl.AutoSize = true;
            this.custReportLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custReportLbl.Location = new System.Drawing.Point(29, 52);
            this.custReportLbl.Name = "custReportLbl";
            this.custReportLbl.Size = new System.Drawing.Size(494, 37);
            this.custReportLbl.TabIndex = 1;
            this.custReportLbl.Text = "All Appointments Per Customer";
            // 
            // custCB
            // 
            this.custCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custCB.FormattingEnabled = true;
            this.custCB.Location = new System.Drawing.Point(523, 107);
            this.custCB.Name = "custCB";
            this.custCB.Size = new System.Drawing.Size(327, 45);
            this.custCB.TabIndex = 2;
            // 
            // custLbl
            // 
            this.custLbl.AutoSize = true;
            this.custLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custLbl.Location = new System.Drawing.Point(341, 107);
            this.custLbl.Name = "custLbl";
            this.custLbl.Size = new System.Drawing.Size(156, 37);
            this.custLbl.TabIndex = 3;
            this.custLbl.Text = "Customer";
            // 
            // generateReportBtn
            // 
            this.generateReportBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateReportBtn.Location = new System.Drawing.Point(148, 543);
            this.generateReportBtn.Name = "generateReportBtn";
            this.generateReportBtn.Size = new System.Drawing.Size(348, 74);
            this.generateReportBtn.TabIndex = 12;
            this.generateReportBtn.Text = "Generate Report";
            this.generateReportBtn.UseVisualStyleBackColor = true;
            this.generateReportBtn.Click += new System.EventHandler(this.generateReportBtn_Click);
            // 
            // returnMainBtn
            // 
            this.returnMainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnMainBtn.Location = new System.Drawing.Point(502, 543);
            this.returnMainBtn.Name = "returnMainBtn";
            this.returnMainBtn.Size = new System.Drawing.Size(348, 74);
            this.returnMainBtn.TabIndex = 13;
            this.returnMainBtn.Text = "Return to Main Screen";
            this.returnMainBtn.UseVisualStyleBackColor = true;
            this.returnMainBtn.Click += new System.EventHandler(this.returnMainBtn_Click);
            // 
            // ApptByCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 760);
            this.Controls.Add(this.returnMainBtn);
            this.Controls.Add(this.generateReportBtn);
            this.Controls.Add(this.custLbl);
            this.Controls.Add(this.custCB);
            this.Controls.Add(this.custReportLbl);
            this.Controls.Add(this.apptByCustDgv);
            this.Name = "ApptByCust";
            this.Text = "Appointments By Customer Report";
            this.Load += new System.EventHandler(this.ApptByCust_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apptByCustDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView apptByCustDgv;
        private System.Windows.Forms.Label custReportLbl;
        private System.Windows.Forms.ComboBox custCB;
        private System.Windows.Forms.Label custLbl;
        private System.Windows.Forms.Button generateReportBtn;
        private System.Windows.Forms.Button returnMainBtn;
    }
}