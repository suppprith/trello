using System.Text.RegularExpressions;

namespace trellologin
{
    public partial class ForgotPasswordDialog : Form
    {
     public ForgotPasswordDialog()
        {
    InitializeComponent();
      this.Paint += ForgotPasswordDialog_Paint;
     }

     private void ForgotPasswordDialog_Paint(object sender, PaintEventArgs e)
     {
            // Create gradient background (light blue to white)
  System.Drawing.Drawing2D.LinearGradientBrush gradientBrush =
         new System.Drawing.Drawing2D.LinearGradientBrush(
  this.ClientRectangle,
          Color.FromArgb(173, 216, 230), // Light blue
          Color.White,
     45f);
  e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
 {
 // Validate email
if (string.IsNullOrWhiteSpace(txtEmail.Text))
         {
   MessageBox.Show("Please enter your email address.", "Validation Error",
       MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtEmail.Focus();
   return;
  }

       if (!IsValidEmail(txtEmail.Text))
            {
       MessageBox.Show("Please enter a valid email address.", "Validation Error",
        MessageBoxButtons.OK, MessageBoxIcon.Warning);
     txtEmail.Focus();
       return;
  }

            // Validate new password
if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
      {
MessageBox.Show("Please enter a new password.", "Validation Error",
      MessageBoxButtons.OK, MessageBoxIcon.Warning);
  txtNewPassword.Focus();
      return;
        }

   if (txtNewPassword.Text.Length < 6)
        {
      MessageBox.Show("Password must be at least 6 characters long.", "Validation Error",
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
     txtNewPassword.Focus();
  return;
  }

            // Validate confirm password
      if (txtNewPassword.Text != txtConfirmPassword.Text)
            {
     MessageBox.Show("Passwords do not match.", "Validation Error",
   MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtConfirmPassword.Focus();
     return;
    }

  MessageBox.Show("Password reset link has been sent to your email!", "Success",
   MessageBoxButtons.OK, MessageBoxIcon.Information);
     this.DialogResult = DialogResult.OK;
   this.Close();
 }

 private void btnCancel_Click(object sender, EventArgs e)
      {
     this.DialogResult = DialogResult.Cancel;
  this.Close();
   }

        private bool IsValidEmail(string email)
        {
   string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
       return Regex.IsMatch(email, pattern);
        }
    }
}
