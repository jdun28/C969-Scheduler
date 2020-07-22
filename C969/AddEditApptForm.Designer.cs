namespace ScheduleProgram
{
    partial class AddEditApptForm
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
            this.apptStartTxt = new System.Windows.Forms.RichTextBox();
            this.apptEndTxt = new System.Windows.Forms.RichTextBox();
            this.apptCustNameLbl = new System.Windows.Forms.Label();
            this.apptTypeLbl = new System.Windows.Forms.Label();
            this.apptStartLbl = new System.Windows.Forms.Label();
            this.apptEndLbl = new System.Windows.Forms.Label();
            this.cancelApptBtn = new System.Windows.Forms.Button();
            this.saveApptBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.custNameCB = new System.Windows.Forms.ComboBox();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // apptStartTxt
            // 
            this.apptStartTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptStartTxt.Location = new System.Drawing.Point(143, 145);
            this.apptStartTxt.Margin = new System.Windows.Forms.Padding(2);
            this.apptStartTxt.Name = "apptStartTxt";
            this.apptStartTxt.Size = new System.Drawing.Size(197, 36);
            this.apptStartTxt.TabIndex = 5;
            this.apptStartTxt.Text = "";
            // 
            // apptEndTxt
            // 
            this.apptEndTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptEndTxt.Location = new System.Drawing.Point(143, 185);
            this.apptEndTxt.Margin = new System.Windows.Forms.Padding(2);
            this.apptEndTxt.Name = "apptEndTxt";
            this.apptEndTxt.Size = new System.Drawing.Size(197, 36);
            this.apptEndTxt.TabIndex = 6;
            this.apptEndTxt.Text = "";
            // 
            // apptCustNameLbl
            // 
            this.apptCustNameLbl.AutoSize = true;
            this.apptCustNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCustNameLbl.Location = new System.Drawing.Point(15, 90);
            this.apptCustNameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptCustNameLbl.Name = "apptCustNameLbl";
            this.apptCustNameLbl.Size = new System.Drawing.Size(124, 20);
            this.apptCustNameLbl.TabIndex = 12;
            this.apptCustNameLbl.Text = "Customer Name";
            // 
            // apptTypeLbl
            // 
            this.apptTypeLbl.AutoSize = true;
            this.apptTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTypeLbl.Location = new System.Drawing.Point(96, 120);
            this.apptTypeLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptTypeLbl.Name = "apptTypeLbl";
            this.apptTypeLbl.Size = new System.Drawing.Size(43, 20);
            this.apptTypeLbl.TabIndex = 17;
            this.apptTypeLbl.Text = "Type";
            // 
            // apptStartLbl
            // 
            this.apptStartLbl.AutoSize = true;
            this.apptStartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptStartLbl.Location = new System.Drawing.Point(57, 161);
            this.apptStartLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptStartLbl.Name = "apptStartLbl";
            this.apptStartLbl.Size = new System.Drawing.Size(82, 20);
            this.apptStartLbl.TabIndex = 19;
            this.apptStartLbl.Text = "Start Time";
            // 
            // apptEndLbl
            // 
            this.apptEndLbl.AutoSize = true;
            this.apptEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptEndLbl.Location = new System.Drawing.Point(63, 201);
            this.apptEndLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.apptEndLbl.Name = "apptEndLbl";
            this.apptEndLbl.Size = new System.Drawing.Size(76, 20);
            this.apptEndLbl.TabIndex = 20;
            this.apptEndLbl.Text = "End Time";
            // 
            // cancelApptBtn
            // 
            this.cancelApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelApptBtn.Location = new System.Drawing.Point(158, 246);
            this.cancelApptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.cancelApptBtn.Name = "cancelApptBtn";
            this.cancelApptBtn.Size = new System.Drawing.Size(88, 29);
            this.cancelApptBtn.TabIndex = 21;
            this.cancelApptBtn.Text = "Cancel";
            this.cancelApptBtn.UseVisualStyleBackColor = true;
            this.cancelApptBtn.Click += new System.EventHandler(this.cancelApptBtn_Click);
            // 
            // saveApptBtn
            // 
            this.saveApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveApptBtn.Location = new System.Drawing.Point(250, 246);
            this.saveApptBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveApptBtn.Name = "saveApptBtn";
            this.saveApptBtn.Size = new System.Drawing.Size(88, 29);
            this.saveApptBtn.TabIndex = 22;
            this.saveApptBtn.Text = "Save";
            this.saveApptBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 5);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Appointment Details";
            // 
            // custNameCB
            // 
            this.custNameCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNameCB.FormattingEnabled = true;
            this.custNameCB.Location = new System.Drawing.Point(143, 86);
            this.custNameCB.Name = "custNameCB";
            this.custNameCB.Size = new System.Drawing.Size(195, 24);
            this.custNameCB.TabIndex = 24;
            this.custNameCB.SelectedIndexChanged += new System.EventHandler(this.custNameCB_SelectedIndexChanged);
            // 
            // typeCB
            // 
            this.typeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Location = new System.Drawing.Point(144, 116);
            this.typeCB.Name = "typeCB";
            this.typeCB.Size = new System.Drawing.Size(193, 24);
            this.typeCB.TabIndex = 25;
            // 
            // AddEditApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 367);
            this.Controls.Add(this.typeCB);
            this.Controls.Add(this.custNameCB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveApptBtn);
            this.Controls.Add(this.cancelApptBtn);
            this.Controls.Add(this.apptEndLbl);
            this.Controls.Add(this.apptStartLbl);
            this.Controls.Add(this.apptTypeLbl);
            this.Controls.Add(this.apptCustNameLbl);
            this.Controls.Add(this.apptEndTxt);
            this.Controls.Add(this.apptStartTxt);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEditApptForm";
            this.Text = "AppointmentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox apptStartTxt;
        private System.Windows.Forms.RichTextBox apptEndTxt;
        private System.Windows.Forms.Label apptCustNameLbl;
        private System.Windows.Forms.Label apptTypeLbl;
        private System.Windows.Forms.Label apptStartLbl;
        private System.Windows.Forms.Label apptEndLbl;
        private System.Windows.Forms.Button cancelApptBtn;
        private System.Windows.Forms.Button saveApptBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox custNameCB;
        private System.Windows.Forms.ComboBox typeCB;
    }
}