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
            this.apptTypeTxt = new System.Windows.Forms.RichTextBox();
            this.apptStartTxt = new System.Windows.Forms.RichTextBox();
            this.apptEndTxt = new System.Windows.Forms.RichTextBox();
            this.apptCustIdTxt = new System.Windows.Forms.RichTextBox();
            this.apptCustNameLbl = new System.Windows.Forms.Label();
            this.apptTypeLbl = new System.Windows.Forms.Label();
            this.apptStartLbl = new System.Windows.Forms.Label();
            this.apptEndLbl = new System.Windows.Forms.Label();
            this.cancelApptBtn = new System.Windows.Forms.Button();
            this.saveApptBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // apptTypeTxt
            // 
            this.apptTypeTxt.Location = new System.Drawing.Point(286, 222);
            this.apptTypeTxt.Name = "apptTypeTxt";
            this.apptTypeTxt.Size = new System.Drawing.Size(390, 66);
            this.apptTypeTxt.TabIndex = 2;
            this.apptTypeTxt.Text = "";
            // 
            // apptStartTxt
            // 
            this.apptStartTxt.Location = new System.Drawing.Point(286, 294);
            this.apptStartTxt.Name = "apptStartTxt";
            this.apptStartTxt.Size = new System.Drawing.Size(390, 66);
            this.apptStartTxt.TabIndex = 5;
            this.apptStartTxt.Text = "";
            // 
            // apptEndTxt
            // 
            this.apptEndTxt.Location = new System.Drawing.Point(286, 366);
            this.apptEndTxt.Name = "apptEndTxt";
            this.apptEndTxt.Size = new System.Drawing.Size(390, 66);
            this.apptEndTxt.TabIndex = 6;
            this.apptEndTxt.Text = "";
            // 
            // apptCustIdTxt
            // 
            this.apptCustIdTxt.Location = new System.Drawing.Point(286, 150);
            this.apptCustIdTxt.Name = "apptCustIdTxt";
            this.apptCustIdTxt.ReadOnly = true;
            this.apptCustIdTxt.Size = new System.Drawing.Size(390, 66);
            this.apptCustIdTxt.TabIndex = 10;
            this.apptCustIdTxt.Text = "";
            // 
            // apptCustNameLbl
            // 
            this.apptCustNameLbl.AutoSize = true;
            this.apptCustNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptCustNameLbl.Location = new System.Drawing.Point(29, 179);
            this.apptCustNameLbl.Name = "apptCustNameLbl";
            this.apptCustNameLbl.Size = new System.Drawing.Size(251, 37);
            this.apptCustNameLbl.TabIndex = 12;
            this.apptCustNameLbl.Text = "Customer Name";
            // 
            // apptTypeLbl
            // 
            this.apptTypeLbl.AutoSize = true;
            this.apptTypeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptTypeLbl.Location = new System.Drawing.Point(193, 251);
            this.apptTypeLbl.Name = "apptTypeLbl";
            this.apptTypeLbl.Size = new System.Drawing.Size(87, 37);
            this.apptTypeLbl.TabIndex = 17;
            this.apptTypeLbl.Text = "Type";
            // 
            // apptStartLbl
            // 
            this.apptStartLbl.AutoSize = true;
            this.apptStartLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptStartLbl.Location = new System.Drawing.Point(115, 323);
            this.apptStartLbl.Name = "apptStartLbl";
            this.apptStartLbl.Size = new System.Drawing.Size(165, 37);
            this.apptStartLbl.TabIndex = 19;
            this.apptStartLbl.Text = "Start Time";
            // 
            // apptEndLbl
            // 
            this.apptEndLbl.AutoSize = true;
            this.apptEndLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apptEndLbl.Location = new System.Drawing.Point(126, 396);
            this.apptEndLbl.Name = "apptEndLbl";
            this.apptEndLbl.Size = new System.Drawing.Size(154, 37);
            this.apptEndLbl.TabIndex = 20;
            this.apptEndLbl.Text = "End Time";
            // 
            // cancelApptBtn
            // 
            this.cancelApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelApptBtn.Location = new System.Drawing.Point(316, 474);
            this.cancelApptBtn.Name = "cancelApptBtn";
            this.cancelApptBtn.Size = new System.Drawing.Size(177, 56);
            this.cancelApptBtn.TabIndex = 21;
            this.cancelApptBtn.Text = "Cancel";
            this.cancelApptBtn.UseVisualStyleBackColor = true;
            this.cancelApptBtn.Click += new System.EventHandler(this.cancelApptBtn_Click);
            // 
            // saveApptBtn
            // 
            this.saveApptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveApptBtn.Location = new System.Drawing.Point(499, 474);
            this.saveApptBtn.Name = "saveApptBtn";
            this.saveApptBtn.Size = new System.Drawing.Size(177, 56);
            this.saveApptBtn.TabIndex = 22;
            this.saveApptBtn.Text = "Save";
            this.saveApptBtn.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(351, 42);
            this.label11.TabIndex = 23;
            this.label11.Text = "Appointment Details";
            // 
            // AddEditApptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 706);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveApptBtn);
            this.Controls.Add(this.cancelApptBtn);
            this.Controls.Add(this.apptEndLbl);
            this.Controls.Add(this.apptStartLbl);
            this.Controls.Add(this.apptTypeLbl);
            this.Controls.Add(this.apptCustNameLbl);
            this.Controls.Add(this.apptCustIdTxt);
            this.Controls.Add(this.apptEndTxt);
            this.Controls.Add(this.apptStartTxt);
            this.Controls.Add(this.apptTypeTxt);
            this.Name = "AddEditApptForm";
            this.Text = "AppointmentDetails";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox apptTypeTxt;
        private System.Windows.Forms.RichTextBox apptStartTxt;
        private System.Windows.Forms.RichTextBox apptEndTxt;
        private System.Windows.Forms.RichTextBox apptCustIdTxt;
        private System.Windows.Forms.Label apptCustNameLbl;
        private System.Windows.Forms.Label apptTypeLbl;
        private System.Windows.Forms.Label apptStartLbl;
        private System.Windows.Forms.Label apptEndLbl;
        private System.Windows.Forms.Button cancelApptBtn;
        private System.Windows.Forms.Button saveApptBtn;
        private System.Windows.Forms.Label label11;
    }
}