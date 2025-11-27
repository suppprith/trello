using System.Text.RegularExpressions;

namespace trellologin
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
            this.Paint += SignUpForm_Paint;
        }

        private void SignUpForm_Paint(object sender, PaintEventArgs e)
        {
            
            System.Drawing.Drawing2D.LinearGradientBrush gradientBrush =
   new System.Drawing.Drawing2D.LinearGradientBrush(
            this.ClientRectangle,
   Color.FromArgb(173, 216, 230),
    Color.White,
   45f);
            e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Please enter your full name.", "Validation Error",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

        
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

         
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error",
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

        
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

          
            if (!chkTerms.Checked)
            {
                MessageBox.Show("Please accept the Terms and Conditions.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        
            OTPDialog otpDialog = new OTPDialog(txtEmail.Text);
            if (otpDialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Account created successfully!", "Success",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);

          
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Close();
            }
        }

        private void linkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void btnGoogleSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Google sign up would be implemented here.", "Info",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnFacebookSignUp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Facebook sign up would be implemented here.", "Info",
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
            
            if (Application.OpenForms.Count == 1)
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
            }
        }

        private void txtConfirmPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
