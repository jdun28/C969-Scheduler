namespace ScheduleProgram
{
    partial class AddEditCustForm
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
            this.nameTxt = new System.Windows.Forms.RichTextBox();
            this.addressTxt = new System.Windows.Forms.RichTextBox();
            this.zipTxt = new System.Windows.Forms.RichTextBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.addressLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cancelCustBtn = new System.Windows.Forms.Button();
            this.saveCustBtn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.RichTextBox();
            this.phoneLbl = new System.Windows.Forms.Label();
            this.cityCB = new System.Windows.Forms.ComboBox();
            this.errorLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.Location = new System.Drawing.Point(286, 173);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(390, 66);
            this.nameTxt.TabIndex = 0;
            this.nameTxt.Text = "";
            this.nameTxt.TextChanged += new System.EventHandler(this.nameTxt_TextChanged);
            // 
            // addressTxt
            // 
            this.addressTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTxt.Location = new System.Drawing.Point(286, 246);
            this.addressTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addressTxt.Name = "addressTxt";
            this.addressTxt.Size = new System.Drawing.Size(390, 66);
            this.addressTxt.TabIndex = 2;
            this.addressTxt.Text = "";
            this.addressTxt.TextChanged += new System.EventHandler(this.addressTxt_TextChanged);
            // 
            // zipTxt
            // 
            this.zipTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipTxt.Location = new System.Drawing.Point(286, 381);
            this.zipTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zipTxt.Name = "zipTxt";
            this.zipTxt.Size = new System.Drawing.Size(390, 66);
            this.zipTxt.TabIndex = 6;
            this.zipTxt.Text = "";
            this.zipTxt.TextChanged += new System.EventHandler(this.zipTxt_TextChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(176, 204);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(103, 37);
            this.nameLbl.TabIndex = 9;
            this.nameLbl.Text = "Name";
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLbl.Location = new System.Drawing.Point(144, 275);
            this.addressLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(135, 37);
            this.addressLbl.TabIndex = 11;
            this.addressLbl.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 333);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 37);
            this.label6.TabIndex = 13;
            this.label6.Text = "City";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(88, 410);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 37);
            this.label8.TabIndex = 15;
            this.label8.Text = "Postal Code";
            // 
            // cancelCustBtn
            // 
            this.cancelCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelCustBtn.Location = new System.Drawing.Point(316, 633);
            this.cancelCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelCustBtn.Name = "cancelCustBtn";
            this.cancelCustBtn.Size = new System.Drawing.Size(176, 56);
            this.cancelCustBtn.TabIndex = 16;
            this.cancelCustBtn.Text = "Cancel";
            this.cancelCustBtn.UseVisualStyleBackColor = true;
            this.cancelCustBtn.Click += new System.EventHandler(this.cancelCustBtn_Click);
            // 
            // saveCustBtn
            // 
            this.saveCustBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveCustBtn.Location = new System.Drawing.Point(500, 633);
            this.saveCustBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.saveCustBtn.Name = "saveCustBtn";
            this.saveCustBtn.Size = new System.Drawing.Size(176, 56);
            this.saveCustBtn.TabIndex = 17;
            this.saveCustBtn.Text = "Save";
            this.saveCustBtn.UseVisualStyleBackColor = true;
            this.saveCustBtn.Click += new System.EventHandler(this.saveCustBtn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 29);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 42);
            this.label11.TabIndex = 24;
            this.label11.Text = "Customer Details";
            // 
            // phoneTxt
            // 
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.Location = new System.Drawing.Point(286, 454);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(390, 66);
            this.phoneTxt.TabIndex = 25;
            this.phoneTxt.Text = "";
            this.phoneTxt.TextChanged += new System.EventHandler(this.phoneTxt_TextChanged);
            // 
            // phoneLbl
            // 
            this.phoneLbl.AutoSize = true;
            this.phoneLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneLbl.Location = new System.Drawing.Point(172, 483);
            this.phoneLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLbl.Name = "phoneLbl";
            this.phoneLbl.Size = new System.Drawing.Size(109, 37);
            this.phoneLbl.TabIndex = 26;
            this.phoneLbl.Text = "Phone";
            // 
            // cityCB
            // 
            this.cityCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityCB.FormattingEnabled = true;
            this.cityCB.Location = new System.Drawing.Point(286, 325);
            this.cityCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cityCB.Name = "cityCB";
            this.cityCB.Size = new System.Drawing.Size(390, 38);
            this.cityCB.TabIndex = 27;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLbl.ForeColor = System.Drawing.Color.Red;
            this.errorLbl.Location = new System.Drawing.Point(210, 575);
            this.errorLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 30);
            this.errorLbl.TabIndex = 28;
            // 
            // AddEditCustForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 773);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.cityCB);
            this.Controls.Add(this.phoneLbl);
            this.Controls.Add(this.phoneTxt);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.saveCustBtn);
            this.Controls.Add(this.cancelCustBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameLbl);
            this.Controls.Add(this.zipTxt);
            this.Controls.Add(this.addressTxt);
            this.Controls.Add(this.nameTxt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddEditCustForm";
            this.Text = "CustomerDetails";
            this.Load += new System.EventHandler(this.AddEditCustForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cancelCustBtn;
        private System.Windows.Forms.Button saveCustBtn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label phoneLbl;
        private System.Windows.Forms.Label errorLbl;
        public System.Windows.Forms.RichTextBox addressTxt;
        public System.Windows.Forms.RichTextBox zipTxt;
        public System.Windows.Forms.RichTextBox phoneTxt;
        public System.Windows.Forms.ComboBox cityCB;
        public System.Windows.Forms.RichTextBox nameTxt;
    }
}