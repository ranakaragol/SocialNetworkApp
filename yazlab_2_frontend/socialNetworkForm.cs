using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using yazlab_2_frontend.Algorithms;
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

        // Şuanki seçilmiş node yi tutar
        Node selected_node = null;

        // Şuanki seçilmiş edge yi tutar
        Edge selected_edge = null;

        // Graph algoritmaları sınıfı
        GraphAlgorithms algorithms = new GraphAlgorithms();

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
                Node clickedNode = null;
                Edge clickedEdge = null;

                // Önce düğümler kontrol edilir
                foreach (var node in nodes)
                {
                    if (node.IsHit(e.Location))
                    {
                        clickedNode = node;
                        break;
                    }
                }

                if (clickedNode != null)
                {
                    // demekki bir nodeye tıklandı
                    selected_node = clickedNode;
                    selected_edge = null; // node seçildiği için seçilen edge yi temizler kod karmaşasını önlemek için

                    if (nodeMode)
                    {
                        movingNode = clickedNode;
                    }
                    else
                    {
                        drawingSourceNode = clickedNode;
                        currentMousePoint = e.Location;
                    }

                    CanvasPanel.Invalidate();
                    return; // node bulunduysa edge kontrolüne gerek yoktur
                }

                // eğer node ye tıklanmadıysa edge kontrolü yap
                foreach (var edge in edges)
                {
                    if (edge.IsHit(e.Location))
                    {
                        clickedEdge = edge;
                        break;
                    }
                }

                if (clickedEdge != null)
                {
                    selected_edge = clickedEdge;
                    selected_node = null;

                    // edge bilgileri yazdırılır
                    startNodeValue.Text = clickedEdge.startNode.id.ToString();
                    
                }
                else
                {
                    // boşluğa tıklandı demektir her şey temizlenir
                    selected_node = null;
                    selected_edge = null;
                }

                CanvasPanel.Invalidate();
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
                    // başarıyla bir edge oluşturuldu yada node taşındı
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

            // önce kalıcı bağlantıları çizer
            foreach (var edge in edges)
            {
                e.Graphics.DrawLine(Pens.Black, edge.startNode.location, edge.endNode.location);
            }

            // geçiçi gri silik çizgiyi çizer
            if (drawingSourceNode != null)
            {
                e.Graphics.DrawLine(Pens.Gray, drawingSourceNode.location, currentMousePoint);
            }

            // C) node leri çizer
            foreach (var node in nodes)
            {
                // dairenin alanı
                Rectangle rect = new Rectangle(
                    node.location.X - node.radius,
                    node.location.Y - node.radius,
                    node.radius * 2,
                    node.radius * 2);
                // node nin colorundan yeni brush nesnesi oluşturulup o renkle node çizilir 
                using (SolidBrush firca = new SolidBrush(node.color))
                {
                    e.Graphics.FillEllipse(firca, rect);
                }
                e.Graphics.DrawEllipse(Pens.Black, rect);

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

        private void CanvasPanel_MouseClick(object sender, MouseEventArgs e)
        {
            foreach (var node in nodes)
            {
                if (node.IsHit(e.Location))
                {
                    selected_node = node;
                    idLabel.Text = node.id.ToString();
                    nameLabel.Text = node.name.ToString();
                    degreeLabel.Text = node.GetDegree(edges).ToString();

                }
                else
                {

                }
            }
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void curvedPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        // BFS algoritması tetikleyici buton
        private void bfs_trigger_Click(object sender, EventArgs e)
        {



            List<Node> result = algorithms.BFS_algorithm(selected_node, edges, nodes);

            foreach (var n in result)
            {
                Color oldcolor = n.color;
                n.color = Color.Yellow; // O anki katmanı renklendir
                CanvasPanel.Refresh();  // Hemen çizdir
                System.Threading.Thread.Sleep(500); // Yarım saniye bekle
                n.color = oldcolor;

            }
            CanvasPanel.Refresh();



        }

        private void dfs_trigger_click(object sender, EventArgs e)
        {

            List<Node> result = algorithms.RunDFS(selected_node, edges);

            foreach (var n in result)
            {
                Color oldcolor = n.color;
                n.color = Color.Yellow; // O anki katmanı renklendir
                CanvasPanel.Refresh();  // Hemen çizdir
                System.Threading.Thread.Sleep(500); // Yarım saniye bekle
                n.color = oldcolor;

            }
            CanvasPanel.Refresh();

        }


        

        private void delete_Click(object sender, EventArgs e)
        {
            // Eğer node seçilmişse o node ve ona bağlı tüm edgeler silinip
            // aynı zamanda silinen edgelerin diğer tarafındaki nodelerin derecesi azaltılır
            if (selected_node != null)
            {

                var bagliKenarlar = edges.Where(ed => ed.startNode == selected_node || ed.endNode == selected_node).ToList();

                foreach (var kenar in bagliKenarlar)
                {

                    edges.Remove(kenar); // Kenarı sil
                }

                nodes.Remove(selected_node); // Düğümü sil
                selected_node = null; // Seçimi temizle
                CanvasPanel.Invalidate();
            }

            if (selected_edge != null)
            {

                edges.Remove(selected_edge);
                selected_edge = null;
                CanvasPanel.Invalidate();
            }

        }
    }
}
