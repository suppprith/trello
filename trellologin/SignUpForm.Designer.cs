namespace trellologin
{
    partial class SignUpForm
    {
  
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
      {
            if (disposing && (components != null))
          {
          components.Dispose();
    }
          base.Dispose(disposing);
    }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblSubtitle = new Label();
            txtFullName = new RoundedTextBox();
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            txtConfirmPassword = new RoundedTextBox();
            btnSignUp = new RoundedButton();
            lblDivider = new Label();
            btnGoogleSignUp = new RoundedButton();
            btnFacebookSignUp = new RoundedButton();
            linkLogin = new LinkLabel();
            lblFullName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            chkTerms = new CheckBox();
            SuspendLayout();
         
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 121, 191);
            lblTitle.Location = new Point(171, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(150, 62);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Trello";
          
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubtitle.Location = new Point(143, 113);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(228, 28);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Sign up for your account";
            
            txtFullName.BackColor = Color.White;
            txtFullName.BorderColor = Color.FromArgb(200, 200, 200);
            txtFullName.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtFullName.BorderRadius = 10;
            txtFullName.BorderSize = 2;
            txtFullName.Location = new Point(80, 213);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(11, 9, 11, 9);
            txtFullName.PasswordChar = '\0';
            txtFullName.PlaceholderText = "Enter your full name";
            txtFullName.Size = new Size(331, 43);
            txtFullName.TabIndex = 2;
           
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.FromArgb(200, 200, 200);
            txtEmail.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtEmail.BorderRadius = 10;
            txtEmail.BorderSize = 2;
            txtEmail.Location = new Point(80, 300);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(11, 9, 11, 9);
            txtEmail.PasswordChar = '\0';
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(331, 43);
            txtEmail.TabIndex = 3;
            
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.FromArgb(200, 200, 200);
            txtPassword.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtPassword.BorderRadius = 10;
            txtPassword.BorderSize = 2;
            txtPassword.Location = new Point(80, 387);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(11, 9, 11, 9);
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(331, 43);
            txtPassword.TabIndex = 4;
            
            txtConfirmPassword.BackColor = Color.White;
            txtConfirmPassword.BorderColor = Color.FromArgb(200, 200, 200);
            txtConfirmPassword.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtConfirmPassword.BorderRadius = 10;
            txtConfirmPassword.BorderSize = 2;
            txtConfirmPassword.Location = new Point(80, 473);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Padding = new Padding(11, 9, 11, 9);
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "Confirm your password";
            txtConfirmPassword.Size = new Size(331, 43);
            txtConfirmPassword.TabIndex = 5;
            txtConfirmPassword.Load += txtConfirmPassword_Load;
            
            btnSignUp.BackColor = Color.FromArgb(0, 121, 191);
            btnSignUp.BorderColor = Color.Transparent;
            btnSignUp.BorderRadius = 20;
            btnSignUp.BorderSize = 0;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatAppearance.BorderSize = 0;
            btnSignUp.FlatStyle = FlatStyle.Flat;
            btnSignUp.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(80, 573);
            btnSignUp.Margin = new Padding(3, 4, 3, 4);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(331, 60);
            btnSignUp.TabIndex = 6;
            btnSignUp.Text = "Sign up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
           
            lblDivider.AutoSize = true;
            lblDivider.BackColor = Color.Transparent;
            lblDivider.Font = new Font("Segoe UI", 9F);
            lblDivider.ForeColor = Color.Gray;
            lblDivider.Location = new Point(217, 653);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(23, 20);
            lblDivider.TabIndex = 7;
            lblDivider.Text = "or";
            
            btnGoogleSignUp.BackColor = Color.White;
            btnGoogleSignUp.BorderColor = Color.FromArgb(200, 200, 200);
            btnGoogleSignUp.BorderRadius = 20;
            btnGoogleSignUp.BorderSize = 2;
            btnGoogleSignUp.Cursor = Cursors.Hand;
            btnGoogleSignUp.FlatAppearance.BorderSize = 0;
            btnGoogleSignUp.FlatStyle = FlatStyle.Flat;
            btnGoogleSignUp.Font = new Font("Segoe UI", 10F);
            btnGoogleSignUp.ForeColor = Color.FromArgb(64, 64, 64);
            btnGoogleSignUp.Location = new Point(80, 700);
            btnGoogleSignUp.Margin = new Padding(3, 4, 3, 4);
            btnGoogleSignUp.Name = "btnGoogleSignUp";
            btnGoogleSignUp.Size = new Size(331, 60);
            btnGoogleSignUp.TabIndex = 8;
            btnGoogleSignUp.Text = "Sign up with Google";
            btnGoogleSignUp.UseVisualStyleBackColor = false;
            btnGoogleSignUp.Click += btnGoogleSignUp_Click;
          
            btnFacebookSignUp.BackColor = Color.White;
            btnFacebookSignUp.BorderColor = Color.FromArgb(200, 200, 200);
            btnFacebookSignUp.BorderRadius = 20;
            btnFacebookSignUp.BorderSize = 2;
            btnFacebookSignUp.Cursor = Cursors.Hand;
            btnFacebookSignUp.FlatAppearance.BorderSize = 0;
            btnFacebookSignUp.FlatStyle = FlatStyle.Flat;
            btnFacebookSignUp.Font = new Font("Segoe UI", 10F);
            btnFacebookSignUp.ForeColor = Color.FromArgb(64, 64, 64);
            btnFacebookSignUp.Location = new Point(80, 773);
            btnFacebookSignUp.Margin = new Padding(3, 4, 3, 4);
            btnFacebookSignUp.Name = "btnFacebookSignUp";
            btnFacebookSignUp.Size = new Size(331, 60);
            btnFacebookSignUp.TabIndex = 9;
            btnFacebookSignUp.Text = "Sign up with Facebook";
            btnFacebookSignUp.UseVisualStyleBackColor = false;
            btnFacebookSignUp.Click += btnFacebookSignUp_Click;
         
            linkLogin.ActiveLinkColor = Color.FromArgb(0, 121, 191);
            linkLogin.AutoSize = true;
            linkLogin.BackColor = Color.Transparent;
            linkLogin.Font = new Font("Segoe UI", 9F);
            linkLogin.LinkColor = Color.FromArgb(0, 121, 191);
            linkLogin.Location = new Point(114, 860);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(223, 20);
            linkLogin.TabIndex = 10;
            linkLogin.TabStop = true;
            linkLogin.Text = "Already have an account? Log in";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
   
            lblFullName.AutoSize = true;
            lblFullName.BackColor = Color.Transparent;
            lblFullName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblFullName.ForeColor = Color.FromArgb(64, 64, 64);
            lblFullName.Location = new Point(80, 180);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 23);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Full Name";
           
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(80, 267);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(54, 23);
            lblEmail.TabIndex = 12;
            lblEmail.Text = "Email";
          
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(80, 353);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 23);
            lblPassword.TabIndex = 13;
            lblPassword.Text = "Password";
            
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblConfirmPassword.Location = new Point(80, 440);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(156, 23);
            lblConfirmPassword.TabIndex = 14;
            lblConfirmPassword.Text = "Confirm Password";
         
            chkTerms.AutoSize = true;
            chkTerms.BackColor = Color.Transparent;
            chkTerms.Font = new Font("Segoe UI", 9F);
            chkTerms.ForeColor = Color.FromArgb(64, 64, 64);
            chkTerms.Location = new Point(80, 533);
            chkTerms.Margin = new Padding(3, 4, 3, 4);
            chkTerms.Name = "chkTerms";
            chkTerms.Size = new Size(267, 24);
            chkTerms.TabIndex = 15;
            chkTerms.Text = "I agree to the Terms and Conditions";
            chkTerms.UseVisualStyleBackColor = false;
           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 933);
            Controls.Add(chkTerms);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblFullName);
            Controls.Add(linkLogin);
            Controls.Add(btnFacebookSignUp);
            Controls.Add(btnGoogleSignUp);
            Controls.Add(lblDivider);
            Controls.Add(btnSignUp);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "SignUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trello - Sign Up";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
      private Label lblSubtitle;
   private RoundedTextBox txtFullName;
  private RoundedTextBox txtEmail;
   private RoundedTextBox txtPassword;
      private RoundedTextBox txtConfirmPassword;
        private RoundedButton btnSignUp;
     private Label lblDivider;
 private RoundedButton btnGoogleSignUp;
        private RoundedButton btnFacebookSignUp;
    private LinkLabel linkLogin;
        private Label lblFullName;
    private Label lblEmail;
        private Label lblPassword;
 private Label lblConfirmPassword;
        private CheckBox chkTerms;
    }
}
