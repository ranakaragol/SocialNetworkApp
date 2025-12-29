using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace yazlab_2_frontend.CustomControls
{
    public class RoundedPanel : Panel
    {
        // Yarıçap ayarı
        public int BorderRadius { get; set; } = 30;

        // Kenarlık rengi ve kalınlığı
        public Color BorderColor { get; set; } = Color.Gray;
        public float BorderSize { get; set; } = 1;

        public RoundedPanel()
        {
            this.DoubleBuffered = true; // Titremeyi önlemek için
            this.BackColor = Color.White;
            this.Padding = new Padding(BorderRadius / 2); // İçeriğin köşelere taşmasını engeller
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // Dikdörtgen alanını hesaplar
            RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

            // Yuvarlak bir yol oluşturur
            using (GraphicsPath path = GetRoundedPath(rect, BorderRadius))
            {
                // Panelin şeklini bu yuvarlağa göre keser
                this.Region = new Region(path);

                // isteğe bağlı kenarlık çizme kontrolü
                if (BorderSize > 0)
                {
                    using (Pen pen = new Pen(BorderColor, BorderSize))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Invalidate(); // Boyut değişince tekrar çizer
        }

        // Yuvarlak köşe hesaplama fonksiyonu
        private GraphicsPath GetRoundedPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float diameter = radius * 2;

            // Yarıçap
            if (diameter > rect.Width) diameter = rect.Width;
            if (diameter > rect.Height) diameter = rect.Height;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90); // sol üst
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90); // sağ üst
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90); // sağ alt
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90); // sol alt
            path.CloseFigure();

            return path;
        }
    }
}