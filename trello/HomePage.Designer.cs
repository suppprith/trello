namespace trellologin
{
    partial class HomePage
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
  lblWelcome = new Label();
   panelInputs = new Panel();
    txtCompletedTasks = new RoundedTextBox();
    txtTotalTasks = new RoundedTextBox();
  lblCompletedTasks = new Label();
    lblTotalTasks = new Label();
       btnUpdate = new RoundedButton();
      panelProgress = new Panel();
   progressBar = new ProgressBar();
lblPercentage = new Label();
   lblProgressLabel = new Label();
       panelCards = new Panel();
    cardTotal = new Panel();
      lblTotalTasksTitle = new Label();
 lblTotalTasksValue = new Label();
     cardCompleted = new Panel();
 lblCompletedTasksTitle = new Label();
  lblCompletedTasksValue = new Label();
       cardRemaining = new Panel();
      lblRemainingTasksTitle = new Label();
 lblRemainingTasksValue = new Label();
   cardProgress = new Panel();
    lblProgressTitle = new Label();
     lblProgressValue = new Label();
 btnLogout = new RoundedButton();
     panelInputs.SuspendLayout();
       panelProgress.SuspendLayout();
       panelCards.SuspendLayout();
cardTotal.SuspendLayout();
      cardCompleted.SuspendLayout();
     cardRemaining.SuspendLayout();
   cardProgress.SuspendLayout();
   SuspendLayout();
// 
// lblTitle
     // 
   lblTitle.AutoSize = true;
     lblTitle.BackColor = Color.Transparent;
     lblTitle.Font = new Font("Segoe UI", 32F, FontStyle.Bold);
  lblTitle.ForeColor = Color.FromArgb(0, 121, 191);
    lblTitle.Location = new Point(40, 30);
       lblTitle.Name = "lblTitle";
  lblTitle.Size = new Size(151, 59);
  lblTitle.TabIndex = 0;
  lblTitle.Text = "Trello";
    // 
    // lblWelcome
  // 
  lblWelcome.AutoSize = true;
       lblWelcome.BackColor = Color.Transparent;
     lblWelcome.Font = new Font("Segoe UI", 13F);
 lblWelcome.ForeColor = Color.FromArgb(80, 80, 80);
  lblWelcome.Location = new Point(45, 95);
   lblWelcome.Name = "lblWelcome";
       lblWelcome.Size = new Size(239, 25);
  lblWelcome.TabIndex = 1;
   lblWelcome.Text = "Track your tasks with ease";
  // 
  // panelInputs
       // 
      panelInputs.BackColor = Color.Transparent;
 panelInputs.Controls.Add(btnUpdate);
     panelInputs.Controls.Add(lblTotalTasks);
  panelInputs.Controls.Add(lblCompletedTasks);
      panelInputs.Controls.Add(txtTotalTasks);
 panelInputs.Controls.Add(txtCompletedTasks);
         panelInputs.Location = new Point(40, 150);
   panelInputs.Name = "panelInputs";
       panelInputs.Size = new Size(920, 100);
    panelInputs.TabIndex = 2;
 // 
        // txtCompletedTasks
     // 
 txtCompletedTasks.BackColor = Color.White;
    txtCompletedTasks.BorderColor = Color.FromArgb(220, 220, 220);
  txtCompletedTasks.BorderFocusColor = Color.FromArgb(0, 121, 191);
      txtCompletedTasks.BorderRadius = 12;
txtCompletedTasks.BorderSize = 2;
       txtCompletedTasks.Font = new Font("Segoe UI", 12F);
    txtCompletedTasks.Location = new Point(0, 40);
  txtCompletedTasks.Name = "txtCompletedTasks";
  txtCompletedTasks.Padding = new Padding(15, 8, 15, 8);
     txtCompletedTasks.PlaceholderText = "0";
     txtCompletedTasks.Size = new Size(200, 42);
    txtCompletedTasks.TabIndex = 0;
            txtCompletedTasks.Text = "0";
   // 
  // txtTotalTasks
   // 
         txtTotalTasks.BackColor = Color.White;
     txtTotalTasks.BorderColor = Color.FromArgb(220, 220, 220);
     txtTotalTasks.BorderFocusColor = Color.FromArgb(0, 121, 191);
   txtTotalTasks.BorderRadius = 12;
   txtTotalTasks.BorderSize = 2;
        txtTotalTasks.Font = new Font("Segoe UI", 12F);
 txtTotalTasks.Location = new Point(240, 40);
       txtTotalTasks.Name = "txtTotalTasks";
     txtTotalTasks.Padding = new Padding(15, 8, 15, 8);
  txtTotalTasks.PlaceholderText = "0";
  txtTotalTasks.Size = new Size(200, 42);
     txtTotalTasks.TabIndex = 1;
      txtTotalTasks.Text = "0";
// 
  // lblCompletedTasks
 // 
lblCompletedTasks.AutoSize = true;
 lblCompletedTasks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
lblCompletedTasks.ForeColor = Color.FromArgb(60, 60, 60);
  lblCompletedTasks.Location = new Point(0, 12);
    lblCompletedTasks.Name = "lblCompletedTasks";
 lblCompletedTasks.Size = new Size(138, 20);
 lblCompletedTasks.TabIndex = 2;
         lblCompletedTasks.Text = "Completed Tasks";
// 
    // lblTotalTasks
    // 
   lblTotalTasks.AutoSize = true;
  lblTotalTasks.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
    lblTotalTasks.ForeColor = Color.FromArgb(60, 60, 60);
     lblTotalTasks.Location = new Point(240, 12);
 lblTotalTasks.Name = "lblTotalTasks";
 lblTotalTasks.Size = new Size(88, 20);
 lblTotalTasks.TabIndex = 3;
   lblTotalTasks.Text = "Total Tasks";
  // 
// btnUpdate
     // 
       btnUpdate.BackColor = Color.FromArgb(0, 121, 191);
  btnUpdate.BorderColor = Color.Transparent;
btnUpdate.BorderRadius = 22;
     btnUpdate.BorderSize = 0;
     btnUpdate.Cursor = Cursors.Hand;
       btnUpdate.FlatAppearance.BorderSize = 0;
  btnUpdate.FlatStyle = FlatStyle.Flat;
         btnUpdate.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
  btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(480, 40);
    btnUpdate.Name = "btnUpdate";
    btnUpdate.Size = new Size(180, 42);
    btnUpdate.TabIndex = 4;
 btnUpdate.Text = "Update Progress";
  btnUpdate.UseVisualStyleBackColor = false;
       btnUpdate.Click += btnUpdate_Click;
    // 
        // panelProgress
   // 
     panelProgress.BackColor = Color.Transparent;
   panelProgress.Controls.Add(lblPercentage);
  panelProgress.Controls.Add(progressBar);
 panelProgress.Controls.Add(lblProgressLabel);
     panelProgress.Location = new Point(40, 280);
      panelProgress.Name = "panelProgress";
       panelProgress.Size = new Size(920, 110);
     panelProgress.TabIndex = 3;
            // 
  // progressBar
     // 
  progressBar.Location = new Point(0, 50);
  progressBar.Name = "progressBar";
      progressBar.Size = new Size(800, 35);
     progressBar.Style = ProgressBarStyle.Continuous;
     progressBar.TabIndex = 0;
        // 
     // lblPercentage
    // 
        lblPercentage.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
  lblPercentage.ForeColor = Color.FromArgb(0, 121, 191);
  lblPercentage.Location = new Point(810, 45);
     lblPercentage.Name = "lblPercentage";
  lblPercentage.Size = new Size(110, 45);
          lblPercentage.TabIndex = 1;
  lblPercentage.Text = "0.0%";
 lblPercentage.TextAlign = ContentAlignment.MiddleRight;
// 
    // lblProgressLabel
       // 
  lblProgressLabel.AutoSize = true;
  lblProgressLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblProgressLabel.ForeColor = Color.FromArgb(60, 60, 60);
         lblProgressLabel.Location = new Point(0, 15);
  lblProgressLabel.Name = "lblProgressLabel";
     lblProgressLabel.Size = new Size(164, 25);
      lblProgressLabel.TabIndex = 2;
lblProgressLabel.Text = "Overall Progress";
     // 
     // panelCards
 // 
  panelCards.BackColor = Color.Transparent;
         panelCards.Controls.Add(cardProgress);
        panelCards.Controls.Add(cardRemaining);
panelCards.Controls.Add(cardCompleted);
   panelCards.Controls.Add(cardTotal);
panelCards.Location = new Point(40, 420);
      panelCards.Name = "panelCards";
      panelCards.Size = new Size(920, 200);
  panelCards.TabIndex = 4;
  // 
     // cardTotal
 // 
         cardTotal.BackColor = Color.FromArgb(33, 150, 243);
cardTotal.Controls.Add(lblTotalTasksValue);
      cardTotal.Controls.Add(lblTotalTasksTitle);
  cardTotal.Location = new Point(0, 0);
  cardTotal.Name = "cardTotal";
    cardTotal.Size = new Size(215, 180);
     cardTotal.TabIndex = 0;
     // 
   // lblTotalTasksTitle
   // 
    lblTotalTasksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
  lblTotalTasksTitle.ForeColor = Color.White;
    lblTotalTasksTitle.Location = new Point(15, 30);
   lblTotalTasksTitle.Name = "lblTotalTasksTitle";
         lblTotalTasksTitle.Size = new Size(185, 30);
  lblTotalTasksTitle.TabIndex = 0;
       lblTotalTasksTitle.Text = "Total Tasks";
       lblTotalTasksTitle.TextAlign = ContentAlignment.MiddleLeft;
      // 
// lblTotalTasksValue
      // 
 lblTotalTasksValue.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
      lblTotalTasksValue.ForeColor = Color.White;
        lblTotalTasksValue.Location = new Point(15, 90);
   lblTotalTasksValue.Name = "lblTotalTasksValue";
          lblTotalTasksValue.Size = new Size(185, 75);
 lblTotalTasksValue.TabIndex = 1;
   lblTotalTasksValue.Text = "0";
 lblTotalTasksValue.TextAlign = ContentAlignment.MiddleLeft;
 // 
    // cardCompleted
    // 
cardCompleted.BackColor = Color.FromArgb(76, 175, 80);
         cardCompleted.Controls.Add(lblCompletedTasksValue);
    cardCompleted.Controls.Add(lblCompletedTasksTitle);
 cardCompleted.Location = new Point(235, 0);
      cardCompleted.Name = "cardCompleted";
     cardCompleted.Size = new Size(215, 180);
    cardCompleted.TabIndex = 1;
// 
     // lblCompletedTasksTitle
     // 
       lblCompletedTasksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
     lblCompletedTasksTitle.ForeColor = Color.White;
  lblCompletedTasksTitle.Location = new Point(15, 30);
      lblCompletedTasksTitle.Name = "lblCompletedTasksTitle";
      lblCompletedTasksTitle.Size = new Size(185, 30);
    lblCompletedTasksTitle.TabIndex = 0;
   lblCompletedTasksTitle.Text = "Completed";
       lblCompletedTasksTitle.TextAlign = ContentAlignment.MiddleLeft;
  // 
          // lblCompletedTasksValue
        // 
lblCompletedTasksValue.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
      lblCompletedTasksValue.ForeColor = Color.White;
      lblCompletedTasksValue.Location = new Point(15, 90);
     lblCompletedTasksValue.Name = "lblCompletedTasksValue";
      lblCompletedTasksValue.Size = new Size(185, 75);
    lblCompletedTasksValue.TabIndex = 1;
 lblCompletedTasksValue.Text = "0";
 lblCompletedTasksValue.TextAlign = ContentAlignment.MiddleLeft;
      // 
  // cardRemaining
    // 
      cardRemaining.BackColor = Color.FromArgb(255, 152, 0);
        cardRemaining.Controls.Add(lblRemainingTasksValue);
  cardRemaining.Controls.Add(lblRemainingTasksTitle);
   cardRemaining.Location = new Point(470, 0);
      cardRemaining.Name = "cardRemaining";
    cardRemaining.Size = new Size(215, 180);
   cardRemaining.TabIndex = 2;
          // 
  // lblRemainingTasksTitle
        // 
lblRemainingTasksTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
 lblRemainingTasksTitle.ForeColor = Color.White;
lblRemainingTasksTitle.Location = new Point(15, 30);
     lblRemainingTasksTitle.Name = "lblRemainingTasksTitle";
    lblRemainingTasksTitle.Size = new Size(185, 30);
  lblRemainingTasksTitle.TabIndex = 0;
        lblRemainingTasksTitle.Text = "Remaining";
lblRemainingTasksTitle.TextAlign = ContentAlignment.MiddleLeft;
    // 
      // lblRemainingTasksValue
        // 
 lblRemainingTasksValue.Font = new Font("Segoe UI", 42F, FontStyle.Bold);
 lblRemainingTasksValue.ForeColor = Color.White;
  lblRemainingTasksValue.Location = new Point(15, 90);
     lblRemainingTasksValue.Name = "lblRemainingTasksValue";
  lblRemainingTasksValue.Size = new Size(185, 75);
      lblRemainingTasksValue.TabIndex = 1;
      lblRemainingTasksValue.Text = "0";
     lblRemainingTasksValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
     // cardProgress
      // 
  cardProgress.BackColor = Color.FromArgb(244, 67, 54);
     cardProgress.Controls.Add(lblProgressValue);
   cardProgress.Controls.Add(lblProgressTitle);
          cardProgress.Location = new Point(705, 0);
   cardProgress.Name = "cardProgress";
cardProgress.Size = new Size(215, 180);
  cardProgress.TabIndex = 3;
    // 
       // lblProgressTitle
   // 
       lblProgressTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
lblProgressTitle.ForeColor = Color.White;
 lblProgressTitle.Location = new Point(15, 30);
  lblProgressTitle.Name = "lblProgressTitle";
      lblProgressTitle.Size = new Size(185, 30);
 lblProgressTitle.TabIndex = 0;
    lblProgressTitle.Text = "Progress";
      lblProgressTitle.TextAlign = ContentAlignment.MiddleLeft;
      // 
 // lblProgressValue
     // 
       lblProgressValue.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
  lblProgressValue.ForeColor = Color.White;
     lblProgressValue.Location = new Point(15, 90);
      lblProgressValue.Name = "lblProgressValue";
     lblProgressValue.Size = new Size(185, 75);
        lblProgressValue.TabIndex = 1;
    lblProgressValue.Text = "0.0%";
       lblProgressValue.TextAlign = ContentAlignment.MiddleLeft;
// 
       // btnLogout
       // 
   btnLogout.BackColor = Color.White;
     btnLogout.BorderColor = Color.FromArgb(220, 220, 220);
   btnLogout.BorderRadius = 22;
     btnLogout.BorderSize = 2;
 btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
    btnLogout.FlatStyle = FlatStyle.Flat;
      btnLogout.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
      btnLogout.ForeColor = Color.FromArgb(80, 80, 80);
      btnLogout.Location = new Point(830, 40);
       btnLogout.Name = "btnLogout";
  btnLogout.Size = new Size(130, 44);
     btnLogout.TabIndex = 5;
      btnLogout.Text = "Logout";
   btnLogout.UseVisualStyleBackColor = false;
     btnLogout.Click += btnLogout_Click;
            // 
  // HomePage
      // 
   AutoScaleDimensions = new SizeF(7F, 15F);
         AutoScaleMode = AutoScaleMode.Font;
    ClientSize = new Size(1000, 660);
  Controls.Add(btnLogout);
   Controls.Add(panelCards);
    Controls.Add(panelProgress);
     Controls.Add(panelInputs);
   Controls.Add(lblWelcome);
          Controls.Add(lblTitle);
  FormBorderStyle = FormBorderStyle.FixedSingle;
     MaximizeBox = false;
 Name = "HomePage";
    StartPosition = FormStartPosition.CenterScreen;
   Text = "Trello - Dashboard";
      panelInputs.ResumeLayout(false);
     panelInputs.PerformLayout();
    panelProgress.ResumeLayout(false);
panelProgress.PerformLayout();
      panelCards.ResumeLayout(false);
   cardTotal.ResumeLayout(false);
        cardCompleted.ResumeLayout(false);
         cardRemaining.ResumeLayout(false);
 cardProgress.ResumeLayout(false);
  ResumeLayout(false);
     PerformLayout();
        }

  #endregion

  private Label lblTitle;
  private Label lblWelcome;
 private Panel panelInputs;
 private RoundedTextBox txtCompletedTasks;
        private RoundedTextBox txtTotalTasks;
    private Label lblCompletedTasks;
        private Label lblTotalTasks;
        private RoundedButton btnUpdate;
        private Panel panelProgress;
    private ProgressBar progressBar;
    private Label lblPercentage;
   private Label lblProgressLabel;
      private Panel panelCards;
        private Panel cardTotal;
   private Label lblTotalTasksTitle;
  private Label lblTotalTasksValue;
  private Panel cardCompleted;
      private Label lblCompletedTasksTitle;
        private Label lblCompletedTasksValue;
     private Panel cardRemaining;
  private Label lblRemainingTasksTitle;
   private Label lblRemainingTasksValue;
   private Panel cardProgress;
     private Label lblProgressTitle;
    private Label lblProgressValue;
     private RoundedButton btnLogout;
    }
}
