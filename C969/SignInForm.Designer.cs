namespace C969
{
    partial class SignInForm
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
            this.usernameTxt = new System.Windows.Forms.RichTextBox();
            this.passwordTxt = new System.Windows.Forms.RichTextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(370, 181);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(441, 66);
            this.usernameTxt.TabIndex = 0;
            this.usernameTxt.Text = "";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(370, 318);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(441, 66);
            this.passwordTxt.TabIndex = 1;
            this.passwordTxt.Text = "";
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(634, 480);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(177, 56);
            this.signInButton.TabIndex = 2;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(165, 221);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(110, 25);
            this.usernameLabel.TabIndex = 3;
            this.usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(165, 359);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(106, 25);
            this.passwordLabel.TabIndex = 4;
            this.passwordLabel.Text = "Password";
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 736);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Name = "SignInForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox usernameTxt;
        private System.Windows.Forms.RichTextBox passwordTxt;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
    }
}

