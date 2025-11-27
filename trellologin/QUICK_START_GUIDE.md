# Quick Start Guide - Trello Task Tracker

## Login Credentials
```
Email: suprith@gmail.com
Password: Admin123!
```

## Getting Started

### Step 1: Login
1. Run the application
2. Enter the credentials above
3. Click "Log in" button
4. You'll be taken to the Home Page

### Step 2: Track Your Tasks

#### Example 1: Starting a New Project
```
Completed Tasks: 0
Total Tasks: 10
Click "Update Progress"
```
**Result:** Progress bar shows 0%, all cards update, progress card is red

#### Example 2: Making Progress
```
Completed Tasks: 5
Total Tasks: 10
Click "Update Progress"
```
**Result:** Progress bar shows 50%, progress card turns amber

#### Example 3: Project Complete
```
Completed Tasks: 10
Total Tasks: 10
Click "Update Progress"
```
**Result:** Progress bar shows 100%, progress card turns green! ??

### Step 3: Understanding the Cards

**Card Layout (Left to Right):**
1. **Total Tasks (Blue)** - Your overall task count
2. **Completed Tasks (Green)** - How many you've finished
3. **Remaining Tasks (Orange)** - What's left to do
4. **Progress (Dynamic)** - Your completion percentage
   - Red: 0-49% (needs work!)
   - Amber: 50-99% (getting there!)
   - Green: 100% (complete!)

### Tips

? **Valid Inputs:**
- Completed Tasks: 0 or any positive number
- Total Tasks: Must be greater than 0
- Completed cannot exceed Total

? **Invalid Inputs:**
```
Completed: 15
Total: 10
```
This will show an error message!

? **Real-World Example:**
```
Working on a web project with 25 tasks:
- Total Tasks: 25
- Completed Tasks: 18
- Click Update
- Progress shows: 72.0%
- Remaining: 7 tasks
```

### Logging Out
1. Click the "Logout" button (top right)
2. Confirm logout
3. Return to login screen

## Visual Guide

```
????????????????????????????????????????????????????????????
?  Trello      [Logout]    ?
?  Welcome back! Track your tasks           ?
?          ?
?  Completed Tasks       Total Tasks    ?
?  [    7     ]  [    10    ]  [Update Progress]    ?
?        ?
?  Overall Progress             ?
?  [??????????????????????]         70.0%?
?  ?
?  ????????  ????????  ????????  ????????        ?
?  ? 10   ?  ?  7   ?  ?  3   ?  ?70.0% ? ?
?  ?Total ?  ?Comp  ?  ?Remain?  ?Prog  ?        ?
?  ????????  ????????  ????????  ????????      ?
????????????????????????????????????????????????????????????
```

## Features to Try

### 1. Watch the Progress Bar Fill
- Start with 0/10
- Update to 2/10 - watch it fill
- Update to 5/10 - see the percentage grow
- Update to 10/10 - watch it complete!

### 2. See Dynamic Colors
- Try 3/10 (30%) - Progress card is RED
- Try 7/10 (70%) - Progress card is AMBER
- Try 10/10 (100%) - Progress card is GREEN

### 3. Real-Time Calculations
- The "Remaining Tasks" card updates automatically
- Just enter completed and total, click update
- All four cards refresh instantly

## Common Use Cases

### Sprint Planning
```
Total Tasks: 20 (sprint backlog)
Completed Tasks: 0 (start of sprint)
Update daily as you complete tasks
Watch your progress grow!
```

### Personal Goals
```
Total Tasks: 30 (monthly goals)
Completed Tasks: Update each day
Track your progress throughout the month
```

### Project Management
```
Total Tasks: 50 (project milestones)
Completed Tasks: Update weekly
Monitor overall project health
```

## Keyboard Shortcuts
- **Tab**: Move between input fields
- **Enter**: Submit (when focused on Update button)
- **Escape**: Clear focus

## Troubleshooting

**Can't login?**
- Make sure you use: `suprith@gmail.com`
- Password is case-sensitive: `Admin123!`

**Cards not updating?**
- Make sure to click "Update Progress" button
- Check that your inputs are valid numbers

**Progress shows wrong percentage?**
- Verify completed tasks ? total tasks
- Make sure total tasks > 0

## Next Steps

This is a demo application. In a production version, you could:
- Add individual task lists
- Set due dates and priorities
- Track multiple projects
- Generate reports
- Sync across devices
- Collaborate with team members

Enjoy tracking your tasks! ???
