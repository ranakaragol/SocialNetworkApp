using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Models;

namespace yazlab_2_frontend
{
    public partial class socialNetworkForm : Form
    {



        // geçici node ve edge listesi 
        List<Node> nodes = new List<Node>();
        List<Edge> edges = new List<Edge>();

        // Çizginin başladığı node yi tutar
        Node drawingSourceNode = null;
        // Fare imlecinin konumunu tutar
        Point currentMousePoint;
        // Rastgele id oluşturmak için
        Random random = new Random();
        // Node yer değiştirme modundamı yoksa Edge çizme modundamı onu tutar
        // Sadece tek bir değişken olduğu için (Node modunda yada değil) ondan enum kullanmaya gerek duymadım
        bool nodeMode = false;
        // Konumu değiştirilcek node yi tutar

        Node movingNode = null;

        public socialNetworkForm()
        {
            InitializeComponent();
            // bu ayar formda titremeyi önler
            this.DoubleBuffered = true;
            // burası yazılan canvas event fonksiyonlarını canvas eventlerine eklemek için kullanılır
            CanvasPanel.Paint += CanvasPanel_Paint;
            CanvasPanel.MouseDown += CanvasPanel_MouseDown;
            CanvasPanel.MouseMove += CanvasPanel_MouseMove;
            CanvasPanel.MouseUp += CanvasPanel_MouseUp;


        }

        private void button1_Click(object sender, EventArgs e)
        // yeni node ekleme fonksiyonu
        {
            Node newnode = new Node();
            // random id oluşturma
            int id = random.Next(1, 200000);

            // burada unique oluşmuş id yi node ye ekliyoruz
            newnode.id = id;
            // başlangıçta node içindeki name değerine placeholder olması adına id yi atıyoruz
            newnode.name = id.ToString();

            // node nin lokasyonunu random belirliyoruz
            newnode.location = new Point(
                random.Next(20, CanvasPanel.Width - 20),
                random.Next(20, CanvasPanel.Height - 20)
            );

            // yeni node nodes listesine eklenir
            nodes.Add(newnode);

            // canvas yeniden çizilir
            CanvasPanel.Invalidate();



        }

        private void CanvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Bu metod mouse ye tıklandığında çalışır

            // Nodeler üstünde arama yapar tıklanan yerde bir node varmı varsa hangi node onu alır
            foreach (var node in nodes)
            {
                if (node.IsHit(e.Location)) // Tıklanan yerde bir node var mı?
                {
                    if (nodeMode)
                    {
                        // Node yer değiştirme modu
                        movingNode = node; // Yeri değişecek node u seçtik
                    }
                    else
                    {
                        // Node ler arası edge çizme modu
                        drawingSourceNode = node; // edgenin çizilmeye başlayacağı node yi seçtik
                        currentMousePoint = e.Location;
                    }

                    break; // Node bulundu döngü bitebilir
                }
            }

        }


        private void CanvasPanel_MouseMove(object sender, MouseEventArgs e)
        // mouse basılı iken hareket ederken bu fonksiyon çalışır
        {
            // Node Yer değiştirme modu ve tabi yer değiştirilcek node varmı ona bakar
            if (nodeMode && movingNode != null)
            {
                // Node un yeni konumunu farenin konumu yapar
                movingNode.location = e.Location;
                CanvasPanel.Invalidate(); // Node nin hareket ettiğini göstermek için canvas sürekli yeniden çizilir
            }

            // Edge çizme modu
            else if (!nodeMode && drawingSourceNode != null)
            {
                currentMousePoint = e.Location;
                CanvasPanel.Invalidate();
            }


        }

        private void CanvasPanel_MouseUp(object sender, MouseEventArgs e)
        // tıkladığımız mouse i bırakınca bu fonksiyon çalışır
        {
            if (nodeMode)
            {
                // node taşımayı bitir
                movingNode = null; 
            }
            else
            {
                // edge çizmeyi bitir
                if (drawingSourceNode != null)
                {
                    foreach (var targetNode in nodes)
                    {
                        // Bıraktığımız yerde node varmı ve başlangıçtaki node ile aynımı kontrol eder
                        if (targetNode.IsHit(e.Location) && targetNode != drawingSourceNode)
                        {
                            Edge newEdge = new Edge();
                            newEdge.startNode = drawingSourceNode;
                            newEdge.endNode = targetNode;

                            edges.Add(newEdge);
                            break;
                        }
                    }
                    // başarıyla bir edge yada node oluşturuldu
                    drawingSourceNode = null;
                    CanvasPanel.Invalidate();
                }
            }

        }

        private void CanvasPanel_Paint(object sender, PaintEventArgs e)
        {
            this.Text = "Çizim Yapılıyor: " + DateTime.Now.Ticks.ToString();
            // Daha pürüzsüz çizgiler için ayar
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // A) ÖNCE KALICI BAĞLANTILARI ÇİZ (Siyah)
            foreach (var edge in edges)
            {
                e.Graphics.DrawLine(Pens.Black, edge.startNode.location, edge.endNode.location);
            }

            // B) ŞU AN ÇEKTİĞİMİZ GEÇİCİ ÇİZGİYİ ÇİZ (Gri)
            if (drawingSourceNode != null)
            {
                e.Graphics.DrawLine(Pens.Gray, drawingSourceNode.location, currentMousePoint);
            }

            // C) EN SON NODE'LARI ÇİZ (Üstte dursunlar)
            foreach (var node in nodes)
            {
                // Dairenin alanı
                Rectangle rect = new Rectangle(
                    node.location.X - node.radius,
                    node.location.Y - node.radius,
                    node.radius * 2,
                    node.radius * 2);

                e.Graphics.FillEllipse(Brushes.SteelBlue, rect); // Mavi dolgu
                e.Graphics.DrawEllipse(Pens.Black, rect);        // Siyah çerçeve

                // İçine ismini yaz
                TextRenderer.DrawText(e.Graphics, node.name, this.Font, rect, Color.White,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            }

        }

        private void CanvasPanel_Paint_1(object sender, PaintEventArgs e)
        {
            int gridSize = 20;

            // 1. Hafızada tek bir kare (hücre) oluşturuyoruz
            using (Bitmap bmp = new Bitmap(gridSize, gridSize))
            using (Graphics gTemp = Graphics.FromImage(bmp))
            {
                // Karenin sağ ve alt kenarına çizgi çiziyoruz (L şekli)
                using (Pen p = new Pen(Color.LightGray))
                {
                    gTemp.DrawLine(p, 0, gridSize - 1, gridSize, gridSize - 1); // Alt çizgi
                    gTemp.DrawLine(p, gridSize - 1, 0, gridSize - 1, gridSize); // Sağ çizgi
                }

                // 2. Bu kareyi bir "fayans" gibi tüm zemine döşüyoruz
                using (TextureBrush brush = new TextureBrush(bmp))
                {
                    e.Graphics.FillRectangle(brush, e.ClipRectangle);
                }
            }
        }

        private void CanvasPanel_Resize(object sender, EventArgs e)
        {
            CanvasPanel.Invalidate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            // Bu button click eventi Edge çizme modunu aktif eder yani Node yer değiştirme modunu kapatır
            nodeMode = false;
            // Node yer değiştirme butonunun yeniden çizilmesini sağlar
            customButton1.Invalidate();

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            // Bu button click eventi Node yer değiştirme modunu aktif eder
            nodeMode = true;
            // Edge çizme butonunun yeniden çizilmesini sağlar
            customButton2.Invalidate();


        }

        private void customButton1_Paint(object sender, PaintEventArgs e)
        {
            // Eğer node yer değiştirme modunda ise çerçeve çizer
            if (nodeMode)
            {
                // Kalem ayarları 
                using (Pen kalem = new Pen(Color.DarkGray, 3))
                {
                    // Çerçevenin butonun içinde kalması için biraz pay bırakıyoruz
                    Rectangle rect = new Rectangle(0, 0, customButton1.Width, customButton2.Height);

                    // PenAlignment.Inset, çizgiyi içeri doğru çizer, böylece taşma yapmaz
                    kalem.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    e.Graphics.DrawRectangle(kalem, rect);
                }
            }
        }

        private void customButton2_Paint(object sender, PaintEventArgs e)
        {
            // Eğer node yer değiştirme modunda değil ise ise çerçeve çizer
            if (!nodeMode)
            {
                // Kalem ayarları 
                using (Pen kalem = new Pen(Color.DarkGray, 3))
                {
                    // Çerçevenin butonun içinde kalması için biraz pay bırakıyoruz
                    Rectangle rect = new Rectangle(0, 0, customButton1.Width, customButton2.Height);

                    // PenAlignment.Inset, çizgiyi içeri doğru çizer, böylece taşma yapmaz
                    kalem.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                    e.Graphics.DrawRectangle(kalem, rect);
                }
            }
        }
    }
}
