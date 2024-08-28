using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientRoundedPanel : Panel
{
    private int _cornerRadius = 30;
    private float _gradientAngle = 45;
    private Color _gradientStartColor = Color.LightBlue;
    private Color _gradientEndColor = Color.Blue;
    private Color _cornerColor = Color.Transparent;

    [Category("Appearance")]
    public int CornerRadius
    {
        get { return _cornerRadius; }
        set { _cornerRadius = value; Invalidate(); }
    }

    [Category("Appearance")]
    public float GradientAngle
    {
        get { return _gradientAngle; }
        set { _gradientAngle = value; Invalidate(); }
    }

    [Category("Appearance")]
    public Color GradientStartColor
    {
        get { return _gradientStartColor; }
        set { _gradientStartColor = value; Invalidate(); }
    }

    [Category("Appearance")]
    public Color GradientEndColor
    {
        get { return _gradientEndColor; }
        set { _gradientEndColor = value; Invalidate(); }
    }

    [Category("Appearance")]
    public Color CornerColor
    {
        get { return _cornerColor; }
        set { _cornerColor = value; Invalidate(); }
    }

    public GradientRoundedPanel()
    {
        this.SetStyle(ControlStyles.UserPaint |
                      ControlStyles.AllPaintingInWmPaint |
                      ControlStyles.OptimizedDoubleBuffer |
                      ControlStyles.ResizeRedraw, true);
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
        e.Graphics.Clear(Parent.BackColor);

        using (GraphicsPath path = GetRoundRectangle(this.ClientRectangle, _cornerRadius))
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, _gradientStartColor, _gradientEndColor, _gradientAngle))
        {
            e.Graphics.FillPath(brush, path);
        }

        if (_cornerColor != Color.Transparent)
        {
            using (Brush cornerBrush = new SolidBrush(_cornerColor))
            {
                Rectangle rect = this.ClientRectangle;
                int diameter = _cornerRadius * 2;

                // Top left arc
                e.Graphics.FillPie(cornerBrush, rect.Left, rect.Top, diameter, diameter, 180, 90);

                // Top right arc
                e.Graphics.FillPie(cornerBrush, rect.Right - diameter, rect.Top, diameter, diameter, 270, 90);

                // Bottom right arc
                e.Graphics.FillPie(cornerBrush, rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);

                // Bottom left arc
                e.Graphics.FillPie(cornerBrush, rect.Left, rect.Bottom - diameter, diameter, diameter, 90, 90);
            }
        }
    }

    protected override void OnResize(EventArgs eventargs)
    {
        base.OnResize(eventargs);
        this.Invalidate();
    }

    private GraphicsPath GetRoundRectangle(Rectangle rect, int radius)
    {
        int diameter = radius * 2;
        Size size = new Size(diameter, diameter);
        Rectangle arc = new Rectangle(rect.Location, size);

        GraphicsPath path = new GraphicsPath();

        // Top left arc
        path.AddArc(arc, 180, 90);

        // Top right arc
        arc.X = rect.Right - diameter;
        path.AddArc(arc, 270, 90);

        // Bottom right arc
        arc.Y = rect.Bottom - diameter;
        path.AddArc(arc, 0, 90);

        // Bottom left arc
        arc.X = rect.Left;
        path.AddArc(arc, 90, 90);

        path.CloseFigure();
        return path;
    }
}
