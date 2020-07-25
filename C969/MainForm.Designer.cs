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
            ((System.ComponentModel.ISupportInitialize)(this.custDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // custDgv
            // 
            this.custDgv.AllowUserToAddRows = false;
            this.custDgv.AllowUserToDeleteRows = false;
            this.custDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDgv.Location = new System.Drawing.Point(432, 58);
            this.custDgv.Margin = new System.Windows.Forms.Padding(2);
            this.custDgv.MultiSelect = false;
            this.custDgv.Name = "custDgv";
            this.custDgv.ReadOnly = true;
            this.custDgv.RowHeadersVisible = false;
            this.custDgv.RowHeadersWidth = 82;
            this.custDgv.RowTemplate.Height = 33;
            this.custDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.custDgv.Size = new System.Drawing.Size(600, 177);
            this.custDgv.TabIndex = 0;
            this.custDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.custDgv_CellClick);
            // 
            // apptDgv
            // 
            this.apptDgv.AllowUserToAddRows = false;
            this.apptDgv.AllowUserToDeleteRows = false;
            this.apptDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDgv.Location = new System.Drawing.Point(432, 319);
            this.apptDgv.Margin = new System.Windows.Forms.Padding(2);
            this.apptDgv.Name = "apptDgv";
            this.apptDgv.ReadOnly = true;
            this.apptDgv.RowHeadersVisible = false;
            this.apptDgv.RowHeadersWidth = 82;
            this.apptDgv.RowTemplate.Height = 33;
            this.apptDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.apptDgv.Size = new System.Drawing.Size(600, 177);
            this.apptDgv.TabIndex = 1;
            this.apptDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.apptDgv_CellClick);
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustBtn.Location = new System.Drawing.Point(944, 238);
            this.updateCustBtn.Margin = new System.Windows.Forms.Padding(2);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(88, 29);
            this.updateCustBtn.TabIndex = 2;
            this.updateCustBtn.Text = "Update";
            this.updateCustBtn.UseVisualStyleBackColor = true;
            this.updateCustBtn.Click += new System.EventHandler(this.updateCustBtn_Click);
            // 
            // addCustBtn
            // 
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustBtn.Location = new System.Drawing.Point(850, 238);
            this.addCustBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(88, 29);
            this.addCustBtn.TabIndex = 3;
            this.addCustBtn.Text = "Add";
            this.addCustBtn.UseVisualStyleBackColor = true;
            this.addCustBtn.Click += new System.EventHandler(this.addCustBtn_Click);
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustBtn.Location = new System.Drawing.Point(757, 238);
            this.deleteCustBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(88, 29);
            this.deleteCustBtn.TabIndex = 4;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            this.deleteCustBtn.Click += new System.EventHandler(this.deleteCustBtn_Click);
            // 
            // udpateApptBtn
            // 
            this.udpateApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateApptBtn.Location = new System.Drawing.Point(944, 499);
            this.udpateApptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.udpateApptBtn.Name = "udpateApptBtn";
            this.udpateApptBtn.Size = new System.Drawing.Size(88, 29);
            this.udpateApptBtn.TabIndex = 5;
            this.udpateApptBtn.Text = "Update";
            this.udpateApptBtn.UseVisualStyleBackColor = true;
            this.udpateApptBtn.Click += new System.EventHandler(this.udpateApptBtn_Click);
            // 
            // addApptBtn
            // 
            this.addApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptBtn.Location = new System.Drawing.Point(850, 499);
            this.addApptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(88, 29);
            this.addApptBtn.TabIndex = 6;
            this.addApptBtn.Text = "Add";
            this.addApptBtn.UseVisualStyleBackColor = true;
            this.addApptBtn.Click += new System.EventHandler(this.addApptBtn_Click);
            // 
            // deleteApptBtn
            // 
            this.deleteApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApptBtn.Location = new System.Drawing.Point(757, 499);
            this.deleteApptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.deleteApptBtn.Name = "deleteApptBtn";
            this.deleteApptBtn.Size = new System.Drawing.Size(88, 29);
            this.deleteApptBtn.TabIndex = 7;
            this.deleteApptBtn.Text = "Delete";
            this.deleteApptBtn.UseVisualStyleBackColor = true;
            // 
            // myCal
            // 
            this.myCal.Location = new System.Drawing.Point(32, 58);
            this.myCal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.myCal.Name = "myCal";
            this.myCal.TabIndex = 8;
            // 
            // weekRb
            // 
            this.weekRb.AutoSize = true;
            this.weekRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekRb.Location = new System.Drawing.Point(88, 238);
            this.weekRb.Margin = new System.Windows.Forms.Padding(2);
            this.weekRb.Name = "weekRb";
            this.weekRb.Size = new System.Drawing.Size(62, 21);
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
            this.monthRb.Location = new System.Drawing.Point(154, 238);
            this.monthRb.Margin = new System.Windows.Forms.Padding(2);
            this.monthRb.Name = "monthRb";
            this.monthRb.Size = new System.Drawing.Size(65, 21);
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
            this.exitBtn.Location = new System.Drawing.Point(32, 532);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 29);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // dayRb
            // 
            this.dayRb.AutoSize = true;
            this.dayRb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.dayRb.Location = new System.Drawing.Point(32, 238);
            this.dayRb.Name = "dayRb";
            this.dayRb.Size = new System.Drawing.Size(51, 21);
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
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Customers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 14;
            this.label2.Text = "Appointments";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 574);
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
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.custDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView custDgv;
        private System.Windows.Forms.DataGridView apptDgv;
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
    }
}