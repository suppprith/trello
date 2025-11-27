namespace trellologin
{
  partial class OTPDialog
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
       lblEmailDisplay = new Label();
   lblDescription = new Label();
   txtOTP = new RoundedTextBox();
  btnVerify = new RoundedButton();
     btnCancel = new RoundedButton();
    linkResendOTP = new LinkLabel();
     lblOTP = new Label();
       SuspendLayout();

      lblTitle.AutoSize = true;
   lblTitle.BackColor = Color.Transparent;
       lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
       lblTitle.ForeColor = Color.FromArgb(0, 121, 191);
        lblTitle.Location = new Point(80, 30);
    lblTitle.Name = "lblTitle";
   lblTitle.Size = new Size(185, 30);
 lblTitle.TabIndex = 0;
   lblTitle.Text = "Verify Your Email";

       lblEmailDisplay.BackColor = Color.Transparent;
  lblEmailDisplay.Font = new Font("Segoe UI", 9F);
   lblEmailDisplay.ForeColor = Color.FromArgb(64, 64, 64);
  lblEmailDisplay.Location = new Point(30, 70);
     lblEmailDisplay.Name = "lblEmailDisplay";
lblEmailDisplay.Size = new Size(300, 40);
   lblEmailDisplay.TabIndex = 1;
            lblEmailDisplay.Text = "We've sent a verification code to your email";
 lblEmailDisplay.TextAlign = ContentAlignment.TopCenter;

       lblDescription.BackColor = Color.Transparent;
 lblDescription.Font = new Font("Segoe UI", 9F);
 lblDescription.ForeColor = Color.FromArgb(64, 64, 64);
      lblDescription.Location = new Point(30, 115);
      lblDescription.Name = "lblDescription";
  lblDescription.Size = new Size(300, 20);
     lblDescription.TabIndex = 2;
     lblDescription.Text = "Enter the 6-digit code below";
       lblDescription.TextAlign = ContentAlignment.TopCenter;

   txtOTP.BackColor = Color.White;
  txtOTP.BorderColor = Color.FromArgb(200, 200, 200);
txtOTP.BorderFocusColor = Color.FromArgb(0, 121, 191);
       txtOTP.BorderRadius = 10;
   txtOTP.BorderSize = 2;
        txtOTP.Location = new Point(90, 175);
        txtOTP.Name = "txtOTP";
   txtOTP.Padding = new Padding(10, 7, 10, 7);
   txtOTP.PlaceholderText = "000000";
  txtOTP.Size = new Size(180, 35);
txtOTP.TabIndex = 3;

      btnVerify.BackColor = Color.FromArgb(0, 121, 191);
  btnVerify.BorderColor = Color.Transparent;
       btnVerify.BorderRadius = 20;
  btnVerify.BorderSize = 0;
       btnVerify.Cursor = Cursors.Hand;
btnVerify.FlatAppearance.BorderSize = 0;
  btnVerify.FlatStyle = FlatStyle.Flat;
      btnVerify.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
 btnVerify.ForeColor = Color.White;
  btnVerify.Location = new Point(40, 235);
       btnVerify.Name = "btnVerify";
      btnVerify.Size = new Size(130, 40);
      btnVerify.TabIndex = 4;
     btnVerify.Text = "Verify";
        btnVerify.UseVisualStyleBackColor = false;
     btnVerify.Click += btnVerify_Click;

    btnCancel.BackColor = Color.White;
       btnCancel.BorderColor = Color.FromArgb(200, 200, 200);
    btnCancel.BorderRadius = 20;
  btnCancel.BorderSize = 2;
            btnCancel.Cursor = Cursors.Hand;
     btnCancel.FlatAppearance.BorderSize = 0;
       btnCancel.FlatStyle = FlatStyle.Flat;
     btnCancel.Font = new Font("Segoe UI", 10F);
       btnCancel.ForeColor = Color.FromArgb(64, 64, 64);
       btnCancel.Location = new Point(190, 235);
  btnCancel.Name = "btnCancel";
       btnCancel.Size = new Size(130, 40);
      btnCancel.TabIndex = 5;
     btnCancel.Text = "Cancel";
       btnCancel.UseVisualStyleBackColor = false;
       btnCancel.Click += btnCancel_Click;

  linkResendOTP.ActiveLinkColor = Color.FromArgb(0, 121, 191);
       linkResendOTP.AutoSize = true;
 linkResendOTP.BackColor = Color.Transparent;
     linkResendOTP.Font = new Font("Segoe UI", 9F);
   linkResendOTP.LinkColor = Color.FromArgb(0, 121, 191);
      linkResendOTP.Location = new Point(125, 290);
         linkResendOTP.Name = "linkResendOTP";
     linkResendOTP.Size = new Size(110, 15);
      linkResendOTP.TabIndex = 6;
 linkResendOTP.TabStop = true;
 linkResendOTP.Text = "Resend OTP code";
          linkResendOTP.LinkClicked += linkResendOTP_LinkClicked;

      lblOTP.AutoSize = true;
  lblOTP.BackColor = Color.Transparent;
  lblOTP.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
       lblOTP.ForeColor = Color.FromArgb(64, 64, 64);
lblOTP.Location = new Point(130, 155);
          lblOTP.Name = "lblOTP";
    lblOTP.Size = new Size(100, 15);
 lblOTP.TabIndex = 7;
   lblOTP.Text = "Enter OTP Code";

   AutoScaleDimensions = new SizeF(7F, 15F);
 AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(360, 330);
       Controls.Add(lblOTP);
     Controls.Add(linkResendOTP);
     Controls.Add(btnCancel);
        Controls.Add(btnVerify);
    Controls.Add(txtOTP);
    Controls.Add(lblDescription);
   Controls.Add(lblEmailDisplay);
     Controls.Add(lblTitle);
      FormBorderStyle = FormBorderStyle.FixedDialog;
     MaximizeBox = false;
       MinimizeBox = false;
     Name = "OTPDialog";
     StartPosition = FormStartPosition.CenterParent;
            Text = "Email Verification";
    ResumeLayout(false);
          PerformLayout();
        }

#endregion

        private Label lblTitle;
   private Label lblEmailDisplay;
  private Label lblDescription;
    private RoundedTextBox txtOTP;
  private RoundedButton btnVerify;
        private RoundedButton btnCancel;
        private LinkLabel linkResendOTP;
      private Label lblOTP;
    }
}
