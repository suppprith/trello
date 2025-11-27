# Trello Login System - Windows Forms Application

## Overview
A complete login and signup system with task tracking for a Trello-style application built with .NET 8 Windows Forms in C# with modern UI elements.

## Features

### 1. **Login Form (Form1)**
- Beautiful light blue to white gradient background
- **Hardcoded credentials for testing:**
  - **Email:** `suprith@gmail.com`
  - **Password:** `Admin123!`
- **Rounded textboxes** with focus border animation (blue when focused)
- **Rounded buttons** with smooth corners and hover effects
- Email and password input fields with placeholders
- Email validation (proper email format)
- Password validation (minimum 6 characters)
- "Forgot Password?" link
- Social login buttons (Google and Facebook) - clean, no icons
- "Don't have an account? Sign up" link
- All buttons have modern flat design with Trello blue theme

### 2. **Sign Up Form**
- Same gradient background design as login
- **Modern rounded input controls** with border animations
- Input fields for:
  - Full Name
  - Email
  - Password
  - Confirm Password
- **Rounded buttons** throughout
- Terms and Conditions checkbox
- Email validation
- Password matching validation
- Social signup buttons (Google and Facebook) - clean, no icons
- "Already have an account? Log in" link
- Triggers OTP verification after successful validation

### 3. **Forgot Password Dialog**
- Modal dialog with gradient background
- **Rounded textboxes and buttons**
- Fields for:
  - Email address
  - New password
  - Confirm new password
- Full validation for all fields
- Reset Password and Cancel buttons with rounded design

### 4. **OTP Verification Dialog**
- Modal dialog for email verification
- **Rounded input field** for OTP
- Shows the email address where OTP was sent
- 6-digit OTP input field with modern styling
- OTP validation (must be 6 digits)
- "Resend OTP code" link
- Verify and Cancel buttons with rounded design

### 5. **Home Page (NEW!)** ?
- **Task tracking dashboard** with modern UI
- **Input Section:**
  - Two input boxes side-by-side: Completed Tasks and Total Tasks
  - "Update Progress" button to calculate statistics
  - Input validation (completed tasks cannot exceed total tasks)
  
- **Progress Section:**
  - Large progress bar showing completion percentage
  - Real-time percentage display
  - Visual feedback of task completion
  
- **Statistics Cards:**
  - **Total Tasks Card** (Blue) - Shows total number of tasks
  - **Completed Tasks Card** (Green) - Shows completed tasks count
  - **Remaining Tasks Card** (Orange) - Shows pending tasks
  - **Progress Card** (Dynamic Color) - Shows percentage with color coding:
    - Red (0-49%) - Low progress
    - Amber (50-99%) - Good progress
    - Green (100%) - Complete!
  
- **Additional Features:**
  - Logout button (returns to login screen)
  - Same beautiful gradient background
  - Automatic calculation and updates
  - Clean, card-based layout

## Design Elements

### Color Scheme
- **Primary Blue**: RGB(0, 121, 191) - Used for buttons and branding
- **Light Blue**: RGB(173, 216, 230) - Gradient start
- **White**: RGB(255, 255, 255) - Gradient end and button backgrounds
- **Gray**: RGB(64, 64, 64) - Text color
- **Light Gray**: RGB(200, 200, 200) - Border colors
- **Border Focus Blue**: RGB(0, 121, 191) - Textbox borders when focused
- **Card Colors:**
  - Blue: RGB(33, 150, 243) - Total Tasks
  - Green: RGB(76, 175, 80) - Completed Tasks
  - Orange: RGB(255, 152, 0) - Remaining Tasks
  - Red/Amber/Green: Dynamic based on progress

### Typography
- **Title**: Segoe UI, 28pt, Bold
- **Subtitle**: Segoe UI, 12pt
- **Labels**: Segoe UI, 10pt, Bold
- **Input Fields**: Segoe UI, 11pt
- **Buttons**: Segoe UI, 11pt, Bold
- **Card Values**: Segoe UI, 36pt, Bold
- **Progress Percentage**: Segoe UI, 16pt, Bold

### UI Components
- **RoundedButton**: Custom button control with 20px border radius
  - Smooth anti-aliased edges
  - Optional border styling
  - Hand cursor on hover
  - 45px height for better touch targets
  
- **RoundedTextBox**: Custom textbox control with 10px border radius
  - 2px border with color change on focus
  - Smooth anti-aliased edges
  - Proper padding for text
  - Supports placeholder text and password mode
  - Border changes to Trello blue when focused

### Visual Improvements
- ? **No icons** on social login buttons - clean text-only design
- ? **Rounded corners** on all buttons (20px radius)
- ? **Rounded corners** on all textboxes (10px radius)
- ? **Border animations** - textboxes highlight in blue when focused
- ? **Smooth anti-aliasing** for polished appearance
- ? **Consistent spacing** and alignment
- ? **Modern flat design** throughout
- ? **Colorful statistics cards** with clear visual hierarchy
- ? **Dynamic color feedback** based on progress

## Validations

### Email Validation
- Checks for proper email format (xxx@xxx.xxx)
- Uses regex pattern matching

### Password Validation
- Minimum length: 6 characters
- Confirm password must match
- Hardcoded check: `suprith@gmail.com` / `Admin123!`

### OTP Validation
- Must be exactly 6 digits
- Numeric characters only

### Task Validation (Home Page)
- Completed tasks must be a valid number (0 or greater)
- Total tasks must be a valid number (greater than 0)
- Completed tasks cannot exceed total tasks
- Input validation with clear error messages

### General Validations
- All required fields must be filled
- Empty string checks on all inputs
- Focus returns to invalid fields with error messages

## Files Created

1. **Form1.cs / Form1.Designer.cs / Form1.resx** - Main login form with hardcoded credentials
2. **SignUpForm.cs / SignUpForm.Designer.cs / SignUpForm.resx** - Sign up form
3. **ForgotPasswordDialog.cs / ForgotPasswordDialog.Designer.cs / ForgotPasswordDialog.resx** - Password reset dialog
4. **OTPDialog.cs / OTPDialog.Designer.cs / OTPDialog.resx** - OTP verification dialog
5. **HomePage.cs / HomePage.Designer.cs / HomePage.resx** - Task tracking dashboard (NEW!)
6. **RoundedControls.cs** - Custom rounded button and textbox controls
7. **Resources.cs** - (Deprecated - no longer needed without icons)

## Navigation Flow

```
Login Form (Form1)
??? Enter: suprith@gmail.com / Admin123! ? Home Page ?
??? Click "Forgot Password?" ? Opens Forgot Password Dialog
??? Click "Sign up" link ? Opens Sign Up Form
??? Click Social Login ? Shows info message

Home Page (NEW!) ?
??? Enter completed tasks and total tasks
??? Click "Update Progress" ? Updates statistics and progress bar
??? View colorful statistics cards
??? Click "Logout" ? Returns to Login Form

Sign Up Form
??? Click "Log in" link ? Returns to Login Form
??? Click Sign Up button ? Opens OTP Dialog
?   ??? Verify OTP ? Returns to Login Form
??? Click Social Signup ? Shows info message

Forgot Password Dialog
??? Click Reset Password ? Shows success message & closes
??? Click Cancel ? Closes dialog

OTP Dialog
??? Click Verify ? Shows success & closes
??? Click Cancel ? Closes dialog
??? Click "Resend OTP" ? Shows resend message
```

## How to Run

1. Open the solution in Visual Studio 2022 or later
2. Ensure you're targeting .NET 8
3. **Stop any running debug session** (if debugging)
4. Build the solution (Ctrl+Shift+B)
5. Run the application (F5)
6. **Login with:** `suprith@gmail.com` / `Admin123!`
7. **Try the home page:**
   - Enter completed tasks (e.g., 7)
   - Enter total tasks (e.g., 10)
   - Click "Update Progress"
   - Watch the progress bar and cards update!

**Note**: If you were debugging when the UI changes were made, you'll need to restart the application to see the new rounded controls.

## Notes

- All functionality is for demonstration purposes
- **Hardcoded login:** suprith@gmail.com / Admin123!
- Social login buttons show info messages (not functional)
- OTP generation is simulated (accepts any 6-digit code)
- Password reset sends simulated confirmation
- No actual backend integration
- All validations work client-side only
- Custom controls use GDI+ for smooth rendering
- All controls support high DPI displays
- **Task tracking is local** - data resets on logout

## Technical Details

### Custom Controls
The application uses custom-built controls for enhanced visuals:

**RoundedButton**
- Inherits from `Button`
- Uses `GraphicsPath` for rounded rectangle rendering
- Properties: `BorderRadius`, `BorderColor`, `BorderSize`
- Smooth anti-aliased rendering

**RoundedTextBox**
- Inherits from `UserControl` containing a borderless `TextBox`
- Dynamic border color based on focus state
- Properties: `BorderColor`, `BorderFocusColor`, `BorderRadius`, `BorderSize`
- Supports `PlaceholderText` and `PasswordChar`

### Home Page Features
**Dynamic Progress Calculation:**
- Calculates percentage: (Completed / Total) × 100
- Updates progress bar in real-time
- Updates all statistics cards simultaneously

**Color Coding:**
- Progress card changes color based on completion:
  - 0-49%: Red (needs attention)
  - 50-99%: Amber (making progress)
  - 100%: Green (completed!)

**Statistics Display:**
- Total Tasks: Shows the overall task count
- Completed Tasks: Shows finished tasks
- Remaining Tasks: Auto-calculated (Total - Completed)
- Progress: Shows percentage with dynamic color

## Future Enhancements

To make this production-ready, you would need to:
1. Integrate with actual authentication APIs
2. Implement real OAuth for Google/Facebook login
3. Connect to email service for OTP delivery
4. Add database integration for user storage
5. Implement secure password hashing
6. Add session management
7. Implement actual password reset via email
8. Add loading animations during async operations
9. Implement proper error handling and logging
10. Add accessibility features (screen reader support, keyboard navigation)
11. **Persist task data** to database or local storage
12. **Add task creation UI** with descriptions and due dates
13. **Implement task lists** with drag-and-drop functionality
14. **Add charts and graphs** for better visualization
15. **User profile management**
