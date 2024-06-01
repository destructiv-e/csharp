using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundButton : Control
{
    public Color BackColor2 { get; set; }
    public Color ButtonBorderColor { get; set; }
    public int ButtonRoundRadius { get; set; }

    public Color ButtonHighlightColor { get; set; }
    public Color ButtonHighlightColor2 { get; set; }
    public Color ButtonHighlightForeColor { get; set; }

    public Color ButtonPressedColor { get; set; }
    public Color ButtonPressedColor2 { get; set; }
    public Color ButtonPressedForeColor { get; set; }

    private bool _isHighlighted;
    private bool _isPressed;

    public RoundButton()
    {
        Size = new Size(100, 40);
        ButtonRoundRadius = 30;
        BackColor = Color.Gainsboro;
        BackColor2 = Color.Silver;
        ButtonBorderColor = Color.Black;
        ButtonHighlightColor = Color.Orange;
        ButtonHighlightColor2 = Color.OrangeRed;
        ButtonHighlightForeColor = Color.Black;

        ButtonPressedColor = Color.Red;
        ButtonPressedColor2 = Color.Maroon;
        ButtonPressedForeColor = Color.White;
    }

    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams createParams = base.CreateParams;
            createParams.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
            return createParams;
        }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

        var foreColor = _isPressed ? ButtonPressedForeColor : _isHighlighted ? ButtonHighlightForeColor : ForeColor;
        var backColor = _isPressed ? ButtonPressedColor : _isHighlighted ? ButtonHighlightColor : BackColor;
        var backColor2 = _isPressed ? ButtonPressedColor2 : _isHighlighted ? ButtonHighlightColor2 : BackColor2;


        using (var pen = new Pen(ButtonBorderColor, 1))
            e.Graphics.DrawPath(pen, Path);

        using (var brush = new LinearGradientBrush(ClientRectangle, backColor, backColor2, LinearGradientMode.Vertical))
            e.Graphics.FillPath(brush, Path);

        using (var brush = new SolidBrush(foreColor))
        {
            var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var rect = ClientRectangle;
            rect.Inflate(-4, -4);
            e.Graphics.DrawString(Text, Font, brush, rect, sf);
        }

        base.OnPaint(e);
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
    }

    protected override void OnMouseEnter(EventArgs e)
    {
        base.OnMouseEnter(e);
        _isHighlighted = true;
        Parent.Invalidate(Bounds, false);
        Invalidate();
    }

    protected override void OnMouseLeave(EventArgs e)
    {
        base.OnMouseLeave(e);
        _isHighlighted = false;
        _isPressed = false;
        Parent.Invalidate(Bounds, false);
        Invalidate();
    }

    protected override void OnMouseDown(MouseEventArgs e)
    {
        base.OnMouseDown(e);
        Parent.Invalidate(Bounds, false);
        Invalidate();
        _isPressed = true;
    }

    protected override void OnMouseUp(MouseEventArgs e)
    {
        base.OnMouseUp(e);
        Parent.Invalidate(Bounds, false);
        Invalidate();
        _isPressed = false;
    }

    protected GraphicsPath Path 
    {
        get
        {
            var rect = ClientRectangle;
            rect.Inflate(-1, -1);
            return GetRoundedRectangle(rect, ButtonRoundRadius);
        }
    }

    public static GraphicsPath GetRoundedRectangle(Rectangle rect, int d)
    {
        var gp = new GraphicsPath();

        gp.AddArc(rect.X, rect.Y, d, d, 180, 90);
        gp.AddArc(rect.X + rect.Width - d, rect.Y, d, d, 270, 90);
        gp.AddArc(rect.X + rect.Width - d, rect.Y + rect.Height - d, d, d, 0, 90);
        gp.AddArc(rect.X, rect.Y + rect.Height - d, d, d, 90, 90);
        gp.CloseFigure();

        return gp;
    }
}