using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class CustomButton : Button
{
    private int borderTop = 0;
    private int borderLeft = 0;
    private int borderRight = 0;
    private int borderBottom = 0;
    private Color borderColor = Color.Black;

    [Category("Custom Border"), Description("Sets the top border thickness.")]
    public int BorderTop
    {
        get { return borderTop; }
        set { borderTop = value; Invalidate(); }
    }

    [Category("Custom Border"), Description("Sets the left border thickness.")]
    public int BorderLeft
    {
        get { return borderLeft; }
        set { borderLeft = value; Invalidate(); }
    }

    [Category("Custom Border"), Description("Sets the right border thickness.")]
    public int BorderRight
    {
        get { return borderRight; }
        set { borderRight = value; Invalidate(); }
    }

    [Category("Custom Border"), Description("Sets the bottom border thickness.")]
    public int BorderBottom
    {
        get { return borderBottom; }
        set { borderBottom = value; Invalidate(); }
    }

    [Category("Custom Border"), Description("Sets the border color.")]
    public Color BorderColor
    {
        get { return borderColor; }
        set { borderColor = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);

        using (Pen pen = new Pen(borderColor))
        {
            // Draw top border
            if (borderTop > 0)
            {
                pen.Width = borderTop;
                pevent.Graphics.DrawLine(pen, 0, 0, this.Width, 0);
            }

            // Draw left border
            if (borderLeft > 0)
            {
                pen.Width = borderLeft;
                pevent.Graphics.DrawLine(pen, 0, 0, 0, this.Height);
            }

            // Draw right border
            if (borderRight > 0)
            {
                pen.Width = borderRight;
                pevent.Graphics.DrawLine(pen, this.Width - 1, 0, this.Width - 1, this.Height);
            }

            // Draw bottom border
            if (borderBottom > 0)
            {
                pen.Width = borderBottom;
                pevent.Graphics.DrawLine(pen, 0, this.Height - 1, this.Width, this.Height - 1);
            }
        }
    }
}
