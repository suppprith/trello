namespace trellologin
{
    public partial class OTPDialog : Form
    {
        private string userEmail;
        private string generatedOTP;

        public OTPDialog(string email)
{
    InitializeComponent();
        userEmail = email;
   generatedOTP = GenerateOTP();
         this.Paint += OTPDialog_Paint;
  lblEmailDisplay.Text = $"We've sent a verification code to {email}";
        }

 private void OTPDialog_Paint(object sender, PaintEventArgs e)
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

        private string GenerateOTP()
        {
       Random random = new Random();
     return random.Next(100000, 999999).ToString();
 }

        private void btnVerify_Click(object sender, EventArgs e)
        {
          // Validate OTP
   string enteredOTP = txtOTP.Text.Trim();

    if (string.IsNullOrWhiteSpace(enteredOTP))
{
       MessageBox.Show("Please enter the OTP code.", "Validation Error",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtOTP.Focus();
       return;
      }

       if (enteredOTP.Length != 6)
  {
 MessageBox.Show("OTP must be 6 digits.", "Validation Error",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
txtOTP.Focus();
       return;
   }

    // In a real application, you would verify against the server
    // For demo purposes, we'll just accept any 6-digit code
  if (enteredOTP.All(char.IsDigit))
       {
     MessageBox.Show("OTP verified successfully!", "Success",
      MessageBoxButtons.OK, MessageBoxIcon.Information);
  this.DialogResult = DialogResult.OK;
     this.Close();
   }
     else
        {
     MessageBox.Show("Invalid OTP. Please enter only digits.", "Validation Error",
    MessageBoxButtons.OK, MessageBoxIcon.Warning);
         txtOTP.Focus();
}
 }

   private void btnCancel_Click(object sender, EventArgs e)
 {
     this.DialogResult = DialogResult.Cancel;
   this.Close();
 }

        private void linkResendOTP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
   generatedOTP = GenerateOTP();
     MessageBox.Show($"A new OTP has been sent to {userEmail}.", "OTP Resent",
   MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
