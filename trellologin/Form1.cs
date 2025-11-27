using System.Text.RegularExpressions;

namespace trellologin
{
    public partial class Form1 : Form
    {
        // Hardcoded credentials
        private const string VALID_EMAIL = "suprith@gmail.com";
     private const string VALID_PASSWORD = "Admin123!";

      public Form1()
      {
     InitializeComponent();
       this.Paint += Form1_Paint;
        }

 private void Form1_Paint(object sender, PaintEventArgs e)
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

        private void btnLogin_Click(object sender, EventArgs e)
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

            // Validate password
     if (string.IsNullOrWhiteSpace(txtPassword.Text))
  {
   MessageBox.Show("Please enter your password.", "Validation Error", 
  MessageBoxButtons.OK, MessageBoxIcon.Warning);
      txtPassword.Focus();
    return;
   }

        if (txtPassword.Text.Length < 6)
  {
     MessageBox.Show("Password must be at least 6 characters long.", "Validation Error", 
     MessageBoxButtons.OK, MessageBoxIcon.Warning);
     txtPassword.Focus();
 return;
  }

      // Check against hardcoded credentials
            if (txtEmail.Text.Trim().ToLower() == VALID_EMAIL.ToLower() && 
          txtPassword.Text == VALID_PASSWORD)
 {
    // Login successful - navigate to home page
            HomePage homePage = new HomePage();
    homePage.Show();
     this.Hide();
  }
            else
 {
    MessageBox.Show("Invalid email or password. Please try again.\n\nHint: Use suprith@gmail.com / Admin123!", 
    "Login Failed", 
          MessageBoxButtons.OK, 
  MessageBoxIcon.Error);
txtPassword.Text = "";
      txtPassword.Focus();
     }
        }

    private void linkForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
    ForgotPasswordDialog forgotPasswordDialog = new ForgotPasswordDialog();
    forgotPasswordDialog.ShowDialog();
     }

      private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
  {
         SignUpForm signUpForm = new SignUpForm();
 signUpForm.Show();
  this.Hide();
        }

    private void btnGoogleLogin_Click(object sender, EventArgs e)
 {
    MessageBox.Show("Google login would be implemented here.", "Info", 
        MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacebookLogin_Click(object sender, EventArgs e)
      {
         MessageBox.Show("Facebook login would be implemented here.", "Info", 
      MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValidEmail(string email)
        {
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
 return Regex.IsMatch(email, pattern);
   }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
  base.OnFormClosing(e);
      // If this is the last form, exit the application
            if (Application.OpenForms.Count == 1)
 {
      Application.Exit();
         }
      }
    }
}
