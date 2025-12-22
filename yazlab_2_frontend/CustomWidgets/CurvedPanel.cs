using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.CustomWidgets
{
    using System;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    namespace yazlab_2_frontend.Models // Senin proje namespace'inle aynı olsun
    {
        public class CurvedPanel : Panel
        {
            // ÖZELLİKLER (Properties Panelinde Görünecekler)

            // Ovallik derecesi
            private int _borderRadius = 30;
            public int BorderRadius
            {
                get { return _borderRadius; }
                set { _borderRadius = value; this.Invalidate(); } // Değer değişince yeniden çiz
            }

            // Kenarlık Rengi
            private Color _borderColor = Color.SteelBlue;
            public Color BorderColor
            {
                get { return _borderColor; }
                set { _borderColor = value; this.Invalidate(); }
            }

            // Kenarlık Kalınlığı
            private float _borderSize = 2.5f;
            public float BorderSize
            {
                get { return _borderSize; }
                set { _borderSize = value; this.Invalidate(); }
            }

            // YAPICI METOT
            public CurvedPanel()
            {
                // Panel titremesini engeller
                this.DoubleBuffered = true;

                // Varsayılan Arkaplan Rengi
                this.BackColor = Color.White;

                // Boyut değiştiğinde yeniden çizilmesi için
                this.ResizeRedraw = true;
            }

            // ÇİZİM İŞLEMİ (Sihir Burada)
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                // Çizim alanı (Kenarlık kesilmesin diye biraz içeriden alıyoruz)
                RectangleF rect = new RectangleF(0, 0, this.Width, this.Height);

                // Eğer kenarlık varsa, alanı kenarlık kadar içeri daralt
                if (_borderSize > 0)
                {
                    rect.Inflate(-1, -1); // 1 piksel pay bırak
                }

                using (GraphicsPath path = GetPath(rect, _borderRadius))
                using (Pen pen = new Pen(_borderColor, _borderSize))
                {
                    // 1. Panelin sınırlarını (Region) oval yap
                    // Bu sayede köşelerdeki fazlalıklar tamamen şeffaf olur, tıklanmaz.
                    this.Region = new Region(path);

                    // 2. Kenarlık çizgisini çiz
                    if (_borderSize > 0)
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }

            // Oval şekli hesaplayan matematik fonksiyonu
            private GraphicsPath GetPath(RectangleF rect, float radius)
            {
                GraphicsPath path = new GraphicsPath();
                path.StartFigure();
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Width - radius - 1, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Width - radius - 1, rect.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Height - radius - 1, radius, radius, 90, 90);
                path.CloseFigure();
                return path;
            }
        }
    }
}
