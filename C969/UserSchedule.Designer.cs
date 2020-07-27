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
            this.userDgv.RowHeadersWidth = 82;
            this.userDgv.RowTemplate.Height = 33;
            this.userDgv.Size = new System.Drawing.Size(1008, 340);
            this.userDgv.TabIndex = 0;
            // 
            // userSchedLbl
            // 
            this.userSchedLbl.AutoSize = true;
            this.userSchedLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSchedLbl.Location = new System.Drawing.Point(29, 52);
            this.userSchedLbl.Name = "userSchedLbl";
            this.userSchedLbl.Size = new System.Drawing.Size(248, 37);
            this.userSchedLbl.TabIndex = 1;
            this.userSchedLbl.Text = "User Schedule:";
            // 
            // userCB
            // 
            this.userCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCB.FormattingEnabled = true;
            this.userCB.Location = new System.Drawing.Point(845, 111);
            this.userCB.Name = "userCB";
            this.userCB.Size = new System.Drawing.Size(199, 45);
            this.userCB.TabIndex = 2;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.Location = new System.Drawing.Point(755, 119);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(84, 37);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "User";
            // 
            // UserSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 604);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.userCB);
            this.Controls.Add(this.userSchedLbl);
            this.Controls.Add(this.userDgv);
            this.Name = "UserSchedule";
            this.Text = "Appointments By Month Report";
            ((System.ComponentModel.ISupportInitialize)(this.userDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView userDgv;
        private System.Windows.Forms.Label userSchedLbl;
        private System.Windows.Forms.ComboBox userCB;
        private System.Windows.Forms.Label userLbl;
    }
}