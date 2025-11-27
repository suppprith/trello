using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Windows.Forms.Design;

namespace trellologin
{
    public class RoundedButton : Button
    {
        private int borderRadius = 20;
 private Color borderColor = Color.Transparent;
        private int borderSize = 0;

        [Category("Appearance")]
     [DefaultValue(20)]
    public int BorderRadius
   {
     get => borderRadius;
   set
  {
 borderRadius = value;
       this.Invalidate();
          }
 }

        [Category("Appearance")]
        public Color BorderColor
        {
    get => borderColor;
  set
    {
           borderColor = value;
          this.Invalidate();
}
        }

        [Category("Appearance")]
   [DefaultValue(0)]
    public int BorderSize
      {
     get => borderSize;
set
       {
    borderSize = value;
    this.Invalidate();
  }
        }

    public RoundedButton()
   {
   this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
      this.Size = new Size(150, 40);
      this.BackColor = Color.FromArgb(0, 121, 191);
 this.ForeColor = Color.White;
  this.Cursor = Cursors.Hand;
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
  GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

   path.StartFigure();
      path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
 path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
      path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
  path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
       path.CloseFigure();
      return path;
     }

 protected override void OnPaint(PaintEventArgs pevent)
        {
     base.OnPaint(pevent);

       Rectangle rectSurface = this.ClientRectangle;
 Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
        int smoothSize = 2;
     if (borderSize > 0)
        smoothSize = borderSize;

if (borderRadius > 2)
   {
  using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
     using (Pen penSurface = new Pen(this.Parent?.BackColor ?? this.BackColor, smoothSize))
using (Pen penBorder = new Pen(borderColor, borderSize))
          {
          pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
       this.Region = new Region(pathSurface);
  pevent.Graphics.DrawPath(penSurface, pathSurface);

      if (borderSize >= 1)
  pevent.Graphics.DrawPath(penBorder, pathBorder);
    }
 }
 else
 {
 this.Region = new Region(rectSurface);
      if (borderSize >= 1)
     {
       using (Pen penBorder = new Pen(borderColor, borderSize))
        {
  penBorder.Alignment = PenAlignment.Inset;
       pevent.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
 }
  }
}
    }

    protected override void OnHandleCreated(EventArgs e)
        {
      base.OnHandleCreated(e);
    if (this.Parent != null)
  this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
}

    private void Container_BackColorChanged(object? sender, EventArgs e)
    {
        this.Invalidate();
    }
    }

    [DefaultEvent("TextChanged")]
    [Designer(typeof(ControlDesigner))]
    public class RoundedTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(200, 200, 200);
        private Color borderFocusColor = Color.FromArgb(0, 121, 191);
    private int borderRadius = 10;
        private int borderSize = 2;
      private bool isFocused = false;

     private TextBox textBox;

   public RoundedTextBox()
      {
   textBox = new TextBox();
     textBox.BorderStyle = BorderStyle.None;
   textBox.Font = new Font("Segoe UI", 11F);
   textBox.Location = new Point(10, 8);
  textBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;

   textBox.Enter += TextBox_Enter;
      textBox.Leave += TextBox_Leave;
 textBox.TextChanged += TextBox_TextChanged;
   textBox.KeyPress += TextBox_KeyPress;

   this.Controls.Add(textBox);
     this.Size = new Size(250, 35);
   this.BackColor = Color.White;
        this.Padding = new Padding(10, 7, 10, 7);
          
   // Update textbox size after control is created
            UpdateTextBoxSize();
}

        private void TextBox_Enter(object? sender, EventArgs e)
 {
     isFocused = true;
          this.Invalidate();
      }

        private void TextBox_Leave(object? sender, EventArgs e)
      {
        isFocused = false;
    this.Invalidate();
        }

   private void TextBox_TextChanged(object? sender, EventArgs e)
        {
  this.OnTextChanged(e);
        }

      private void TextBox_KeyPress(object? sender, KeyPressEventArgs e)
        {
   this.OnKeyPress(e);
        }

      [Category("Appearance")]
      [Description("The text content of the control")]
     [Browsable(true)]
[EditorBrowsable(EditorBrowsableState.Always)]
      [Bindable(true)]
[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
  public override string Text
    {
      get => textBox?.Text ?? string.Empty;
          set
    {
if (textBox != null)
       textBox.Text = value;
            }
      }

        [Category("Appearance")]
        [Description("The placeholder text shown when empty")]
      [Browsable(true)]
      [DefaultValue("")]
   public string PlaceholderText
     {
    get => textBox?.PlaceholderText ?? string.Empty;
 set
            {
         if (textBox != null)
      textBox.PlaceholderText = value;
  }
        }

 [Category("Appearance")]
     [Description("The character used for password fields")]
        [Browsable(true)]
        [DefaultValue('\0')]
public char PasswordChar
   {
       get => textBox?.PasswordChar ?? '\0';
   set
     {
        if (textBox != null)
    textBox.PasswordChar = value;
            }
        }

  [Category("Appearance")]
      [Description("The border color when not focused")]
        [Browsable(true)]
     public Color BorderColor
   {
      get => borderColor;
         set { borderColor = value; this.Invalidate(); }
 }

 [Category("Appearance")]
   [Description("The border color when focused")]
    [Browsable(true)]
      public Color BorderFocusColor
     {
          get => borderFocusColor;
            set => borderFocusColor = value;
  }

    [Category("Appearance")]
  [Description("The radius of rounded corners")]
    [Browsable(true)]
        [DefaultValue(10)]
   public int BorderRadius
     {
     get => borderRadius;
  set { borderRadius = value; this.Invalidate(); }
    }

        [Category("Appearance")]
        [Description("The width of the border")]
        [Browsable(true)]
        [DefaultValue(2)]
  public int BorderSize
 {
       get => borderSize;
        set { borderSize = value; this.Invalidate(); }
  }

        public new void Focus()
    {
   textBox?.Focus();
   }

        private void UpdateTextBoxSize()
        {
     if (textBox != null)
            {
   textBox.Location = new Point(Padding.Left, Padding.Top);
          textBox.Size = new Size(
    this.Width - Padding.Left - Padding.Right,
       this.Height - Padding.Top - Padding.Bottom
    );
          }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
  {
      GraphicsPath path = new GraphicsPath();
   float curveSize = radius * 2F;

     path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
 path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
    path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
 path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
     path.CloseFigure();
     return path;
   }

        protected override void OnPaint(PaintEventArgs e)
        {
base.OnPaint(e);
     Rectangle rectSurface = this.ClientRectangle;
      Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
        int smoothSize = borderSize > 0 ? borderSize : 1;

if (borderRadius > 2)
      {
   using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
    using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.White, smoothSize))
    using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
      {
     e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
     this.Region = new Region(pathSurface);
     e.Graphics.DrawPath(penSurface, pathSurface);

    if (borderSize >= 1)
   e.Graphics.DrawPath(penBorder, pathBorder);
  }
            }
      else
  {
    this.Region = new Region(rectSurface);
 if (borderSize >= 1)
   {
 using (Pen penBorder = new Pen(isFocused ? borderFocusColor : borderColor, borderSize))
    {
     penBorder.Alignment = PenAlignment.Inset;
  e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
         }
        }
  }
  }

protected override void OnResize(EventArgs e)
 {
    base.OnResize(e);
    UpdateTextBoxSize();
     }

     protected override void OnLoad(EventArgs e)
        {
      base.OnLoad(e);
        UpdateTextBoxSize();
 }

    protected override void OnHandleCreated(EventArgs e)
     {
   base.OnHandleCreated(e);
          if (this.Parent != null)
      this.Parent.BackColorChanged += Container_BackColorChanged;
      }

        private void Container_BackColorChanged(object? sender, EventArgs e)
        {
 this.Invalidate();
      }

        protected override void Dispose(bool disposing)
      {
  if (disposing)
            {
    if (textBox != null)
                {
    textBox.Enter -= TextBox_Enter;
    textBox.Leave -= TextBox_Leave;
   textBox.TextChanged -= TextBox_TextChanged;
     textBox.KeyPress -= TextBox_KeyPress;
            }
    
         if (this.Parent != null)
          {
     this.Parent.BackColorChanged -= Container_BackColorChanged;
   }
}
            base.Dispose(disposing);
        }
 }
}
