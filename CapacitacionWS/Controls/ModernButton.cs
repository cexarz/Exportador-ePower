using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class ModernButton : Button
{
    // Propiedades personalizables
    public int CornerRadius { get; set; } = 15;
    public Color HoverColor { get; set; } = Color.FromArgb(70, 130, 180);
    public Color PressColor { get; set; } = Color.FromArgb(30, 90, 140);
    public Color NormalColor { get; set; } = Color.FromArgb(50, 110, 160);
    public int BorderSize { get; set; } = 0;
    public Color BorderColor { get; set; } = Color.Transparent;

    public ModernButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = NormalColor;
        this.ForeColor = Color.White;
        this.Font = new Font("Segoe UI", 10f, FontStyle.Bold);
        this.Cursor = Cursors.Hand;
        this.Size = new Size(150, 40);

        // Eventos para efectos interactivos
        this.MouseEnter += (s, e) => this.BackColor = HoverColor;
        this.MouseLeave += (s, e) => this.BackColor = NormalColor;
        this.MouseDown += (s, e) => this.BackColor = PressColor;
        this.MouseUp += (s, e) => this.BackColor = HoverColor;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Bordes redondeados
        Rectangle rect = new Rectangle(0, 0, Width, Height);
        using (GraphicsPath path = GetRoundPath(rect, CornerRadius))
        {
            this.Region = new Region(path);

            // Borde opcional
            using (Pen pen = new Pen(BorderColor, BorderSize))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.DrawPath(pen, path);
            }
        }
    }

    private GraphicsPath GetRoundPath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
        path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
        path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
        path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
        path.CloseFigure();
        return path;
    }
}