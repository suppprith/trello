namespace trellologin
{
    partial class ForgotPasswordDialog
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
     lblTitle = new Label();
     lblDescription = new Label();
     txtEmail = new RoundedTextBox();
        txtNewPassword = new RoundedTextBox();
 txtConfirmPassword = new RoundedTextBox();
      btnResetPassword = new RoundedButton();
   btnCancel = new RoundedButton();
      lblEmail = new Label();
      lblNewPassword = new Label();
      lblConfirmPassword = new Label();
     SuspendLayout();
   // 
  // lblTitle
     // 
    lblTitle.AutoSize = true;
   lblTitle.BackColor = Color.Transparent;
  lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
     lblTitle.ForeColor = Color.FromArgb(0, 121, 191);
        lblTitle.Location = new Point(80, 30);
  lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(200, 30);
    lblTitle.TabIndex = 0;
  lblTitle.Text = "Reset Password";
   // 
     // lblDescription
        // 
        lblDescription.BackColor = Color.Transparent;
lblDescription.Font = new Font("Segoe UI", 9F);
            lblDescription.ForeColor = Color.FromArgb(64, 64, 64);
      lblDescription.Location = new Point(40, 70);
    lblDescription.Name = "lblDescription";
       lblDescription.Size = new Size(280, 40);
     lblDescription.TabIndex = 1;
     lblDescription.Text = "Enter your email and new password to reset your account password.";
       lblDescription.TextAlign = ContentAlignment.TopCenter;
    // 
// txtEmail
// 
 txtEmail.BackColor = Color.White;
      txtEmail.BorderColor = Color.FromArgb(200, 200, 200);
  txtEmail.BorderFocusColor = Color.FromArgb(0, 121, 191);
     txtEmail.BorderRadius = 10;
       txtEmail.BorderSize = 2;
    txtEmail.Location = new Point(40, 145);
      txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(10, 7, 10, 7);
       txtEmail.PlaceholderText = "Enter your email";
       txtEmail.Size = new Size(280, 35);
        txtEmail.TabIndex = 2;
     // 
   // txtNewPassword
       // 
     txtNewPassword.BackColor = Color.White;
    txtNewPassword.BorderColor = Color.FromArgb(200, 200, 200);
       txtNewPassword.BorderFocusColor = Color.FromArgb(0, 121, 191);
      txtNewPassword.BorderRadius = 10;
  txtNewPassword.BorderSize = 2;
     txtNewPassword.Location = new Point(40, 210);
    txtNewPassword.Name = "txtNewPassword";
       txtNewPassword.Padding = new Padding(10, 7, 10, 7);
  txtNewPassword.PasswordChar = '?';
txtNewPassword.PlaceholderText = "Enter new password";
 txtNewPassword.Size = new Size(280, 35);
      txtNewPassword.TabIndex = 3;
   // 
  // txtConfirmPassword
        // 
txtConfirmPassword.BackColor = Color.White;
    txtConfirmPassword.BorderColor = Color.FromArgb(200, 200, 200);
        txtConfirmPassword.BorderFocusColor = Color.FromArgb(0, 121, 191);
      txtConfirmPassword.BorderRadius = 10;
txtConfirmPassword.BorderSize = 2;
    txtConfirmPassword.Location = new Point(40, 275);
        txtConfirmPassword.Name = "txtConfirmPassword";
      txtConfirmPassword.Padding = new Padding(10, 7, 10, 7);
      txtConfirmPassword.PasswordChar = '?';
 txtConfirmPassword.PlaceholderText = "Confirm new password";
  txtConfirmPassword.Size = new Size(280, 35);
txtConfirmPassword.TabIndex = 4;
    // 
     // btnResetPassword
      // 
     btnResetPassword.BackColor = Color.FromArgb(0, 121, 191);
       btnResetPassword.BorderColor = Color.Transparent;
            btnResetPassword.BorderRadius = 20;
        btnResetPassword.BorderSize = 0;
       btnResetPassword.Cursor = Cursors.Hand;
    btnResetPassword.FlatAppearance.BorderSize = 0;
       btnResetPassword.FlatStyle = FlatStyle.Flat;
      btnResetPassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
  btnResetPassword.ForeColor = Color.White;
  btnResetPassword.Location = new Point(40, 330);
    btnResetPassword.Name = "btnResetPassword";
      btnResetPassword.Size = new Size(130, 40);
      btnResetPassword.TabIndex = 5;
   btnResetPassword.Text = "Reset Password";
btnResetPassword.UseVisualStyleBackColor = false;
  btnResetPassword.Click += btnResetPassword_Click;
     // 
       // btnCancel
   // 
   btnCancel.BackColor = Color.White;
       btnCancel.BorderColor = Color.FromArgb(200, 200, 200);
 btnCancel.BorderRadius = 20;
 btnCancel.BorderSize = 2;
            btnCancel.Cursor = Cursors.Hand;
btnCancel.FlatAppearance.BorderSize = 0;
      btnCancel.FlatStyle = FlatStyle.Flat;
btnCancel.Font = new Font("Segoe UI", 10F);
       btnCancel.ForeColor = Color.FromArgb(64, 64, 64);
  btnCancel.Location = new Point(190, 330);
     btnCancel.Name = "btnCancel";
 btnCancel.Size = new Size(130, 40);
 btnCancel.TabIndex = 6;
   btnCancel.Text = "Cancel";
       btnCancel.UseVisualStyleBackColor = false;
         btnCancel.Click += btnCancel_Click;
     // 
// lblEmail
        // 
      lblEmail.AutoSize = true;
        lblEmail.BackColor = Color.Transparent;
       lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
 lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
      lblEmail.Location = new Point(40, 125);
  lblEmail.Name = "lblEmail";
       lblEmail.Size = new Size(36, 15);
 lblEmail.TabIndex = 7;
    lblEmail.Text = "Email";
    // 
       // lblNewPassword
       // 
 lblNewPassword.AutoSize = true;
 lblNewPassword.BackColor = Color.Transparent;
lblNewPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
    lblNewPassword.ForeColor = Color.FromArgb(64, 64, 64);
  lblNewPassword.Location = new Point(40, 190);
 lblNewPassword.Name = "lblNewPassword";
     lblNewPassword.Size = new Size(88, 15);
 lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "New Password";
       // 
  // lblConfirmPassword
     // 
       lblConfirmPassword.AutoSize = true;
   lblConfirmPassword.BackColor = Color.Transparent;
     lblConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblConfirmPassword.ForeColor = Color.FromArgb(64, 64, 64);
    lblConfirmPassword.Location = new Point(40, 255);
       lblConfirmPassword.Name = "lblConfirmPassword";
       lblConfirmPassword.Size = new Size(107, 15);
   lblConfirmPassword.TabIndex = 9;
  lblConfirmPassword.Text = "Confirm Password";
            // 
// ForgotPasswordDialog
   // 
          AutoScaleDimensions = new SizeF(7F, 15F);
   AutoScaleMode = AutoScaleMode.Font;
 ClientSize = new Size(360, 400);
       Controls.Add(lblConfirmPassword);
       Controls.Add(lblNewPassword);
   Controls.Add(lblEmail);
      Controls.Add(btnCancel);
      Controls.Add(btnResetPassword);
      Controls.Add(txtConfirmPassword);
    Controls.Add(txtNewPassword);
Controls.Add(txtEmail);
     Controls.Add(lblDescription);
      Controls.Add(lblTitle);
  FormBorderStyle = FormBorderStyle.FixedDialog;
     MaximizeBox = false;
  MinimizeBox = false;
   Name = "ForgotPasswordDialog";
 StartPosition = FormStartPosition.CenterParent;
 Text = "Forgot Password";
    ResumeLayout(false);
 PerformLayout();
    }

      #endregion

        private Label lblTitle;
        private Label lblDescription;
 private RoundedTextBox txtEmail;
    private RoundedTextBox txtNewPassword;
   private RoundedTextBox txtConfirmPassword;
   private RoundedButton btnResetPassword;
        private RoundedButton btnCancel;
        private Label lblEmail;
        private Label lblNewPassword;
        private Label lblConfirmPassword;
    }
}
