namespace trellologin
{
    partial class Form1
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
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            btnLogin = new RoundedButton();
            linkForgotPassword = new LinkLabel();
            lblDivider = new Label();
            btnGoogleLogin = new RoundedButton();
            btnFacebookLogin = new RoundedButton();
            linkSignUp = new LinkLabel();
            lblEmail = new Label();
            lblPassword = new Label();
            SuspendLayout();
            
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(0, 121, 191);
            lblTitle.Location = new Point(150, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(132, 51);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Trello";
        
            lblSubtitle.AutoSize = true;
            lblSubtitle.BackColor = Color.Transparent;
            lblSubtitle.Font = new Font("Segoe UI", 12F);
            lblSubtitle.ForeColor = Color.FromArgb(64, 64, 64);
            lblSubtitle.Location = new Point(110, 95);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(210, 21);
            lblSubtitle.TabIndex = 1;
            lblSubtitle.Text = "Log in to continue to Trello";
           
            txtEmail.BackColor = Color.White;
            txtEmail.BorderColor = Color.FromArgb(200, 200, 200);
            txtEmail.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtEmail.BorderRadius = 10;
            txtEmail.BorderSize = 2;
            txtEmail.Location = new Point(70, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 7, 10, 7);
            txtEmail.PlaceholderText = "Enter your email";
            txtEmail.Size = new Size(290, 35);
            txtEmail.TabIndex = 2;
          
            txtPassword.BackColor = Color.White;
            txtPassword.BorderColor = Color.FromArgb(200, 200, 200);
            txtPassword.BorderFocusColor = Color.FromArgb(0, 121, 191);
            txtPassword.BorderRadius = 10;
            txtPassword.BorderSize = 2;
            txtPassword.Location = new Point(70, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(10, 7, 10, 7);
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(290, 35);
            txtPassword.TabIndex = 3;
            
            btnLogin.BackColor = Color.FromArgb(0, 121, 191);
            btnLogin.BorderColor = Color.Transparent;
            btnLogin.BorderRadius = 20;
            btnLogin.BorderSize = 0;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(70, 300);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(290, 45);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
           
            linkForgotPassword.ActiveLinkColor = Color.FromArgb(0, 121, 191);
            linkForgotPassword.AutoSize = true;
            linkForgotPassword.BackColor = Color.Transparent;
            linkForgotPassword.Font = new Font("Segoe UI", 9F);
            linkForgotPassword.LinkColor = Color.FromArgb(0, 121, 191);
            linkForgotPassword.Location = new Point(160, 355);
            linkForgotPassword.Name = "linkForgotPassword";
            linkForgotPassword.Size = new Size(100, 15);
            linkForgotPassword.TabIndex = 5;
            linkForgotPassword.TabStop = true;
            linkForgotPassword.Text = "Forgot password?";
            linkForgotPassword.LinkClicked += linkForgotPassword_LinkClicked;
            
            lblDivider.AutoSize = true;
            lblDivider.BackColor = Color.Transparent;
            lblDivider.Font = new Font("Segoe UI", 9F);
            lblDivider.ForeColor = Color.Gray;
            lblDivider.Location = new Point(190, 390);
            lblDivider.Name = "lblDivider";
            lblDivider.Size = new Size(20, 15);
            lblDivider.TabIndex = 6;
            lblDivider.Text = "or";
           
            btnGoogleLogin.BackColor = Color.White;
            btnGoogleLogin.BorderColor = Color.FromArgb(200, 200, 200);
            btnGoogleLogin.BorderRadius = 20;
            btnGoogleLogin.BorderSize = 2;
            btnGoogleLogin.Cursor = Cursors.Hand;
            btnGoogleLogin.FlatAppearance.BorderSize = 0;
            btnGoogleLogin.FlatStyle = FlatStyle.Flat;
            btnGoogleLogin.Font = new Font("Segoe UI", 10F);
            btnGoogleLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnGoogleLogin.Location = new Point(70, 425);
            btnGoogleLogin.Name = "btnGoogleLogin";
            btnGoogleLogin.Size = new Size(290, 45);
            btnGoogleLogin.TabIndex = 7;
            btnGoogleLogin.Text = "Continue with Google";
            btnGoogleLogin.UseVisualStyleBackColor = false;
            btnGoogleLogin.Click += btnGoogleLogin_Click;
            
            btnFacebookLogin.BackColor = Color.White;
            btnFacebookLogin.BorderColor = Color.FromArgb(200, 200, 200);
            btnFacebookLogin.BorderRadius = 20;
            btnFacebookLogin.BorderSize = 2;
            btnFacebookLogin.Cursor = Cursors.Hand;
            btnFacebookLogin.FlatAppearance.BorderSize = 0;
            btnFacebookLogin.FlatStyle = FlatStyle.Flat;
            btnFacebookLogin.Font = new Font("Segoe UI", 10F);
            btnFacebookLogin.ForeColor = Color.FromArgb(64, 64, 64);
            btnFacebookLogin.Location = new Point(70, 480);
            btnFacebookLogin.Name = "btnFacebookLogin";
            btnFacebookLogin.Size = new Size(290, 45);
            btnFacebookLogin.TabIndex = 8;
            btnFacebookLogin.Text = "Continue with Facebook";
            btnFacebookLogin.UseVisualStyleBackColor = false;
            btnFacebookLogin.Click += btnFacebookLogin_Click;
          
            linkSignUp.ActiveLinkColor = Color.FromArgb(0, 121, 191);
            linkSignUp.AutoSize = true;
            linkSignUp.BackColor = Color.Transparent;
            linkSignUp.Font = new Font("Segoe UI", 9F);
            linkSignUp.LinkColor = Color.FromArgb(0, 121, 191);
            linkSignUp.Location = new Point(110, 545);
            linkSignUp.Name = "linkSignUp";
            linkSignUp.Size = new Size(210, 15);
            linkSignUp.TabIndex = 9;
            linkSignUp.TabStop = true;
            linkSignUp.Text = "Don't have an account? Sign up";
            linkSignUp.LinkClicked += linkSignUp_LinkClicked;
           
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(70, 145);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 19);
            lblEmail.TabIndex = 10;
            lblEmail.Text = "Email";
           
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPassword.ForeColor = Color.FromArgb(64, 64, 64);
            lblPassword.Location = new Point(70, 215);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(73, 19);
            lblPassword.TabIndex = 11;
            lblPassword.Text = "Password";
           
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 600);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(linkSignUp);
            Controls.Add(btnFacebookLogin);
            Controls.Add(btnGoogleLogin);
            Controls.Add(lblDivider);
            Controls.Add(linkForgotPassword);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trello - Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnLogin;
        private LinkLabel linkForgotPassword;
        private Label lblDivider;
        private RoundedButton btnGoogleLogin;
        private RoundedButton btnFacebookLogin;
        private LinkLabel linkSignUp;
        private Label lblEmail;
        private Label lblPassword;
    }
}
