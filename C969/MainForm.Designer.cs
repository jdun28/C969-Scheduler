namespace ScheduleProgram
{
    partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.custDgv = new System.Windows.Forms.DataGridView();
            this.apptDgv = new System.Windows.Forms.DataGridView();
            this.updateCustBtn = new System.Windows.Forms.Button();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.deleteCustBtn = new System.Windows.Forms.Button();
            this.udpateApptBtn = new System.Windows.Forms.Button();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.deleteApptBtn = new System.Windows.Forms.Button();
            this.myCal = new System.Windows.Forms.MonthCalendar();
            this.weekRb = new System.Windows.Forms.RadioButton();
            this.monthRb = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.dayRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.apptByMonBtn = new System.Windows.Forms.Button();
            this.userSchedBtn = new System.Windows.Forms.Button();
            this.apptByCustBtn = new System.Windows.Forms.Button();
            this.reportsLbl = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.RichTextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.custDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // custDgv
            // 
            this.custDgv.AllowUserToAddRows = false;
            this.custDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.custDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.custDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDgv.EnableHeadersVisualStyles = false;
            this.custDgv.Location = new System.Drawing.Point(620, 198);
            this.custDgv.Margin = new System.Windows.Forms.Padding(4);
            this.custDgv.MultiSelect = false;
            this.custDgv.Name = "custDgv";
            this.custDgv.ReadOnly = true;
            this.custDgv.RowHeadersVisible = false;
            this.custDgv.RowHeadersWidth = 82;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow;
            this.custDgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.custDgv.RowTemplate.Height = 33;
            this.custDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custDgv.Size = new System.Drawing.Size(1008, 340);
            this.custDgv.TabIndex = 0;
            this.custDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDgv_CellClick);
            // 
            // apptDgv
            // 
            this.apptDgv.AllowUserToAddRows = false;
            this.apptDgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.apptDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.apptDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDgv.EnableHeadersVisualStyles = false;
            this.apptDgv.Location = new System.Drawing.Point(620, 699);
            this.apptDgv.Margin = new System.Windows.Forms.Padding(4);
            this.apptDgv.MultiSelect = false;
            this.apptDgv.Name = "apptDgv";
            this.apptDgv.ReadOnly = true;
            this.apptDgv.RowHeadersVisible = false;
            this.apptDgv.RowHeadersWidth = 82;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow;
            this.apptDgv.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.apptDgv.RowTemplate.Height = 33;
            this.apptDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptDgv.Size = new System.Drawing.Size(1008, 340);
            this.apptDgv.TabIndex = 1;
            this.apptDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apptDgv_CellClick);
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustBtn.Location = new System.Drawing.Point(1452, 546);
            this.updateCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(176, 56);
            this.updateCustBtn.TabIndex = 2;
            this.updateCustBtn.Text = "Update";
            this.updateCustBtn.UseVisualStyleBackColor = true;
            this.updateCustBtn.Click += new System.EventHandler(this.updateCustBtn_Click);
            // 
            // addCustBtn
            // 
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustBtn.Location = new System.Drawing.Point(1264, 546);
            this.addCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(176, 56);
            this.addCustBtn.TabIndex = 3;
            this.addCustBtn.Text = "Add";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustBtn.Location = new System.Drawing.Point(1078, 546);
            this.deleteCustBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(176, 56);
            this.deleteCustBtn.TabIndex = 4;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            this.deleteCustBtn.Click += new System.EventHandler(this.deleteCustBtn_Click);
            // 
            // udpateApptBtn
            // 
            this.udpateApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateApptBtn.Location = new System.Drawing.Point(1452, 1047);
            this.udpateApptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.udpateApptBtn.Name = "udpateApptBtn";
            this.udpateApptBtn.Size = new System.Drawing.Size(176, 56);
            this.udpateApptBtn.TabIndex = 5;
            this.udpateApptBtn.Text = "Update";
            this.udpateApptBtn.UseVisualStyleBackColor = true;
            this.udpateApptBtn.Click += new System.EventHandler(this.udpateApptBtn_Click);
            // 
            // addApptBtn
            // 
            this.addApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptBtn.Location = new System.Drawing.Point(1264, 1047);
            this.addApptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(176, 56);
            this.addApptBtn.TabIndex = 6;
            this.addApptBtn.Text = "Add";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // deleteApptBtn
            // 
            this.deleteApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApptBtn.Location = new System.Drawing.Point(1078, 1047);
            this.deleteApptBtn.Margin = new System.Windows.Forms.Padding(4);
            this.deleteApptBtn.Name = "deleteApptBtn";
            this.deleteApptBtn.Size = new System.Drawing.Size(176, 56);
            this.deleteApptBtn.TabIndex = 7;
            this.deleteApptBtn.Text = "Delete";
            this.deleteApptBtn.UseVisualStyleBackColor = true;
            this.deleteApptBtn.Click += new System.EventHandler(this.deleteApptBtn_Click);
            // 
            // myCal
            // 
            this.myCal.Location = new System.Drawing.Point(68, 198);
            this.myCal.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.myCal.Name = "myCal";
            this.myCal.TabIndex = 8;
            this.myCal.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.myCal_DateSelected);
            // 
            // weekRb
            // 
            this.weekRb.AutoSize = true;
            this.weekRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRb.Location = new System.Drawing.Point(180, 544);
            this.weekRb.Margin = new System.Windows.Forms.Padding(4);
            this.weekRb.Name = "weekRb";
            this.weekRb.Size = new System.Drawing.Size(114, 35);
            this.weekRb.TabIndex = 9;
            this.weekRb.TabStop = true;
            this.weekRb.Text = "Week";
            this.weekRb.UseVisualStyleBackColor = true;
            this.weekRb.CheckedChanged += new System.EventHandler(this.weekRb_CheckedChanged);
            // 
            // monthRb
            // 
            this.monthRb.AutoSize = true;
            this.monthRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRb.Location = new System.Drawing.Point(312, 544);
            this.monthRb.Margin = new System.Windows.Forms.Padding(4);
            this.monthRb.Name = "monthRb";
            this.monthRb.Size = new System.Drawing.Size(120, 35);
            this.monthRb.TabIndex = 10;
            this.monthRb.TabStop = true;
            this.monthRb.Text = "Month";
            this.monthRb.UseVisualStyleBackColor = true;
            this.monthRb.CheckedChanged += new System.EventHandler(this.monthRb_CheckedChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.AllowDrop = true;
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(68, 1047);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(176, 56);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dayRb
            // 
            this.dayRb.AutoSize = true;
            this.dayRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.dayRb.Location = new System.Drawing.Point(68, 544);
            this.dayRb.Margin = new System.Windows.Forms.Padding(6);
            this.dayRb.Name = "dayRb";
            this.dayRb.Size = new System.Drawing.Size(94, 35);
            this.dayRb.TabIndex = 12;
            this.dayRb.TabStop = true;
            this.dayRb.Text = "Day";
            this.dayRb.UseVisualStyleBackColor = true;
            this.dayRb.CheckedChanged += new System.EventHandler(this.dayRb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 44);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(612, 651);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(266, 44);
            this.label2.TabIndex = 14;
            this.label2.Text = "Appointments";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(350, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "View Appointment By:";
            // 
            // apptByMonBtn
            // 
            this.apptByMonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptByMonBtn.Location = new System.Drawing.Point(68, 699);
            this.apptByMonBtn.Name = "apptByMonBtn";
            this.apptByMonBtn.Size = new System.Drawing.Size(404, 80);
            this.apptByMonBtn.TabIndex = 16;
            this.apptByMonBtn.Text = "Appointments \r\nBy Month";
            this.apptByMonBtn.UseVisualStyleBackColor = true;
            this.apptByMonBtn.Click += new System.EventHandler(this.apptByMonBtn_Click);
            // 
            // userSchedBtn
            // 
            this.userSchedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSchedBtn.Location = new System.Drawing.Point(68, 799);
            this.userSchedBtn.Name = "userSchedBtn";
            this.userSchedBtn.Size = new System.Drawing.Size(404, 80);
            this.userSchedBtn.TabIndex = 17;
            this.userSchedBtn.Text = "User Schedule";
            this.userSchedBtn.UseVisualStyleBackColor = true;
            this.userSchedBtn.Click += new System.EventHandler(this.userSchedBtn_Click);
            // 
            // apptByCustBtn
            // 
            this.apptByCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptByCustBtn.Location = new System.Drawing.Point(68, 903);
            this.apptByCustBtn.Name = "apptByCustBtn";
            this.apptByCustBtn.Size = new System.Drawing.Size(404, 80);
            this.apptByCustBtn.TabIndex = 18;
            this.apptByCustBtn.Text = "Appointments \r\nBy Customer";
            this.apptByCustBtn.UseVisualStyleBackColor = true;
            this.apptByCustBtn.Click += new System.EventHandler(this.apptByCustBtn_Click);
            // 
            // reportsLbl
            // 
            this.reportsLbl.AutoSize = true;
            this.reportsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsLbl.Location = new System.Drawing.Point(61, 658);
            this.reportsLbl.Name = "reportsLbl";
            this.reportsLbl.Size = new System.Drawing.Size(155, 37);
            this.reportsLbl.TabIndex = 19;
            this.reportsLbl.Text = "Reports: ";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(1027, 138);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(418, 52);
            this.searchTextBox.TabIndex = 20;
            this.searchTextBox.Text = "";
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.Location = new System.Drawing.Point(1452, 134);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(176, 56);
            this.searchBtn.TabIndex = 21;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 1220);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.reportsLbl);
            this.Controls.Add(this.apptByCustBtn);
            this.Controls.Add(this.userSchedBtn);
            this.Controls.Add(this.apptByMonBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dayRb);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.monthRb);
            this.Controls.Add(this.weekRb);
            this.Controls.Add(this.myCal);
            this.Controls.Add(this.deleteApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.udpateApptBtn);
            this.Controls.Add(this.deleteCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.updateCustBtn);
            this.Controls.Add(this.apptDgv);
            this.Controls.Add(this.custDgv);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.custDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView custDgv;
        private System.Windows.Forms.Button updateCustBtn;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button deleteCustBtn;
        private System.Windows.Forms.Button udpateApptBtn;
        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button deleteApptBtn;
        private System.Windows.Forms.MonthCalendar myCal;
        private System.Windows.Forms.RadioButton weekRb;
        private System.Windows.Forms.RadioButton monthRb;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RadioButton dayRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button apptByMonBtn;
        private System.Windows.Forms.Button userSchedBtn;
        private System.Windows.Forms.Button apptByCustBtn;
        private System.Windows.Forms.Label reportsLbl;
        internal System.Windows.Forms.DataGridView apptDgv;
        private System.Windows.Forms.RichTextBox searchTextBox;
        private System.Windows.Forms.Button searchBtn;
    }
}