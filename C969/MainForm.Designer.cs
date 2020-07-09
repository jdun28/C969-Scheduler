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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.updateCustBtn = new System.Windows.Forms.Button();
            this.addCustBtn = new System.Windows.Forms.Button();
            this.deleteCustBtn = new System.Windows.Forms.Button();
            this.udpateApptBtn = new System.Windows.Forms.Button();
            this.addApptBtn = new System.Windows.Forms.Button();
            this.deleteApptBtn = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(865, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1200, 340);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(865, 614);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 82;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(1200, 340);
            this.dataGridView2.TabIndex = 1;
            // 
            // updateCustBtn
            // 
            this.updateCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateCustBtn.Location = new System.Drawing.Point(1888, 458);
            this.updateCustBtn.Name = "updateCustBtn";
            this.updateCustBtn.Size = new System.Drawing.Size(177, 56);
            this.updateCustBtn.TabIndex = 2;
            this.updateCustBtn.Text = "Update";
            this.updateCustBtn.UseVisualStyleBackColor = true;
            // 
            // addCustBtn
            // 
            this.addCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCustBtn.Location = new System.Drawing.Point(1701, 458);
            this.addCustBtn.Name = "addCustBtn";
            this.addCustBtn.Size = new System.Drawing.Size(177, 56);
            this.addCustBtn.TabIndex = 3;
            this.addCustBtn.Text = "Add";
            this.addCustBtn.UseVisualStyleBackColor = true;
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustBtn.Location = new System.Drawing.Point(1514, 458);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(177, 56);
            this.deleteCustBtn.TabIndex = 4;
            this.deleteCustBtn.Text = "Delete";
            this.deleteCustBtn.UseVisualStyleBackColor = true;
            // 
            // udpateApptBtn
            // 
            this.udpateApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udpateApptBtn.Location = new System.Drawing.Point(1888, 960);
            this.udpateApptBtn.Name = "udpateApptBtn";
            this.udpateApptBtn.Size = new System.Drawing.Size(177, 56);
            this.udpateApptBtn.TabIndex = 5;
            this.udpateApptBtn.Text = "Update";
            this.udpateApptBtn.UseVisualStyleBackColor = true;
            // 
            // addApptBtn
            // 
            this.addApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addApptBtn.Location = new System.Drawing.Point(1701, 960);
            this.addApptBtn.Name = "addApptBtn";
            this.addApptBtn.Size = new System.Drawing.Size(177, 56);
            this.addApptBtn.TabIndex = 6;
            this.addApptBtn.Text = "Add";
            this.addApptBtn.UseVisualStyleBackColor = true;
            // 
            // deleteApptBtn
            // 
            this.deleteApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteApptBtn.Location = new System.Drawing.Point(1514, 960);
            this.deleteApptBtn.Name = "deleteApptBtn";
            this.deleteApptBtn.Size = new System.Drawing.Size(177, 56);
            this.deleteApptBtn.TabIndex = 7;
            this.deleteApptBtn.Text = "Delete";
            this.deleteApptBtn.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(65, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2111, 1123);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.deleteApptBtn);
            this.Controls.Add(this.addApptBtn);
            this.Controls.Add(this.udpateApptBtn);
            this.Controls.Add(this.deleteCustBtn);
            this.Controls.Add(this.addCustBtn);
            this.Controls.Add(this.updateCustBtn);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button updateCustBtn;
        private System.Windows.Forms.Button addCustBtn;
        private System.Windows.Forms.Button deleteCustBtn;
        private System.Windows.Forms.Button udpateApptBtn;
        private System.Windows.Forms.Button addApptBtn;
        private System.Windows.Forms.Button deleteApptBtn;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}