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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.custDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apptDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // custDgv
            // 
            this.custDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.custDgv.Location = new System.Drawing.Point(432, 58);
            this.custDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.custDgv.Name = "custDgv";
            this.custDgv.RowHeadersVisible = false;
            this.custDgv.RowHeadersWidth = 82;
            this.custDgv.RowTemplate.Height = 33;
            this.custDgv.Size = new System.Drawing.Size(600, 177);
            this.custDgv.TabIndex = 0;
            // 
            // apptDgv
            // 
            this.apptDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.apptDgv.Location = new System.Drawing.Point(432, 319);
            this.apptDgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.apptDgv.Name = "apptDgv";
            this.apptDgv.RowHeadersVisible = false;
            this.apptDgv.RowHeadersWidth = 82;
            this.apptDgv.RowTemplate.Height = 33;
            this.apptDgv.Size = new System.Drawing.Size(600, 177);
            this.apptDgv.TabIndex = 1;
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustBtn.Location = new System.Drawing.Point(944, 238);
            this.updateCustBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(88, 29);
            this.updateCustBtn.TabIndex = 2;
            this.updateCustBtn.Text = "Update";
            this.updateCustBtn.UseVisualStyleBackColor = true;
            // 
            // addCustBtn
            // 
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustBtn.Location = new System.Drawing.Point(850, 238);
            this.addCustBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.deleteCustBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(88, 29);
            this.deleteCustBtn.TabIndex = 4;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            // 
            // udpateApptBtn
            // 
            this.udpateApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateApptBtn.Location = new System.Drawing.Point(944, 499);
            this.udpateApptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.udpateApptBtn.Name = "udpateApptBtn";
            this.udpateApptBtn.Size = new System.Drawing.Size(88, 29);
            this.udpateApptBtn.TabIndex = 5;
            this.udpateApptBtn.Text = "Update";
            this.udpateApptBtn.UseVisualStyleBackColor = true;
            // 
            // addApptBtn
            // 
            this.addApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptBtn.Location = new System.Drawing.Point(850, 499);
            this.addApptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.deleteApptBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(88, 238);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 21);
            this.radioButton1.TabIndex = 9;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Week";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(154, 238);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(65, 21);
            this.radioButton2.TabIndex = 10;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Month";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.AllowDrop = true;
            this.exitBtn.BackColor = System.Drawing.Color.Red;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(32, 532);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 29);
            this.exitBtn.TabIndex = 11;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F);
            this.radioButton3.Location = new System.Drawing.Point(32, 238);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 21);
            this.radioButton3.TabIndex = 12;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Day";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 608);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.myCal);
            this.Controls.Add(this.deleteApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.udpateApptBtn);
            this.Controls.Add(this.deleteCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.updateCustBtn);
            this.Controls.Add(this.apptDgv);
            this.Controls.Add(this.custDgv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}