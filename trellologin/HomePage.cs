namespace trellologin
{
    public partial class HomePage : Form
    {
   private int completedTasks = 0;
        private int totalTasks = 0;
        private double progressPercentage = 0;

        public HomePage()
        {
    InitializeComponent();
            this.Paint += HomePage_Paint;
            UpdateStatistics();
    
    // Apply rounded corners to cards
          ApplyRoundedCorners();
        }

        private void HomePage_Paint(object sender, PaintEventArgs e)
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

        private void ApplyRoundedCorners()
   {
         // Apply rounded corners to all cards
  ApplyRoundedCornersToPanel(cardTotal, 15);
     ApplyRoundedCornersToPanel(cardCompleted, 15);
            ApplyRoundedCornersToPanel(cardRemaining, 15);
            ApplyRoundedCornersToPanel(cardProgress, 15);
  }

        private void ApplyRoundedCornersToPanel(Panel panel, int radius)
        {
       System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            float curveSize = radius * 2F;

         path.StartFigure();
            path.AddArc(0, 0, curveSize, curveSize, 180, 90);
        path.AddArc(panel.Width - curveSize, 0, curveSize, curveSize, 270, 90);
     path.AddArc(panel.Width - curveSize, panel.Height - curveSize, curveSize, curveSize, 0, 90);
      path.AddArc(0, panel.Height - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();

         panel.Region = new Region(path);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
   // Validate completed tasks
        if (!int.TryParse(txtCompletedTasks.Text, out completedTasks) || completedTasks < 0)
            {
     MessageBox.Show("Please enter a valid number for completed tasks.", "Validation Error",
 MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtCompletedTasks.Focus();
return;
            }

   // Validate total tasks
            if (!int.TryParse(txtTotalTasks.Text, out totalTasks) || totalTasks <= 0)
          {
    MessageBox.Show("Please enter a valid number for total tasks (greater than 0).", "Validation Error",
         MessageBoxButtons.OK, MessageBoxIcon.Warning);
       txtTotalTasks.Focus();
           return;
       }

     // Check if completed tasks exceeds total tasks
            if (completedTasks > totalTasks)
        {
       MessageBox.Show("Completed tasks cannot exceed total tasks.", "Validation Error",
       MessageBoxButtons.OK, MessageBoxIcon.Warning);
    txtCompletedTasks.Focus();
      return;
       }

      // Calculate and update statistics
  UpdateStatistics();
            
 // Show success feedback
            AnimateUpdate();
        }

      private void AnimateUpdate()
        {
       // Simple visual feedback
       btnUpdate.BackColor = Color.FromArgb(76, 175, 80); // Green
     btnUpdate.Text = "Updated!";
          
     // Reset after 1 second
    System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
    timer.Interval = 1000;
       timer.Tick += (s, e) =>
       {
        btnUpdate.BackColor = Color.FromArgb(0, 121, 191);
       btnUpdate.Text = "Update Progress";
        timer.Stop();
          timer.Dispose();
       };
  timer.Start();
}

        private void UpdateStatistics()
     {
          // Calculate progress percentage
            if (totalTasks > 0)
   {
                progressPercentage = (double)completedTasks / totalTasks * 100;
   }
  else
            {
            progressPercentage = 0;
 }

            // Update progress bar
      progressBar.Value = (int)Math.Min(progressPercentage, 100);

    // Update percentage label
            lblPercentage.Text = $"{progressPercentage:F1}%";

         // Update card values
          lblTotalTasksValue.Text = totalTasks.ToString();
      lblCompletedTasksValue.Text = completedTasks.ToString();
     lblRemainingTasksValue.Text = (totalTasks - completedTasks).ToString();
            lblProgressValue.Text = $"{progressPercentage:F1}%";

            // Update card colors based on progress
            UpdateCardColors();
    }

        private void UpdateCardColors()
        {
         // Update progress card color based on percentage
            if (progressPercentage >= 100)
  {
                cardProgress.BackColor = Color.FromArgb(76, 175, 80); // Green
     }
            else if (progressPercentage >= 50)
     {
                cardProgress.BackColor = Color.FromArgb(255, 193, 7); // Amber
}
        else
  {
     cardProgress.BackColor = Color.FromArgb(244, 67, 54); // Red
            }
   }

        private void btnLogout_Click(object sender, EventArgs e)
        {
     DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
Form1 loginForm = new Form1();
         loginForm.Show();
       this.Close();
    }
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
