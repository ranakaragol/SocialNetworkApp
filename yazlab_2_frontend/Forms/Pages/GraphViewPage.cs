using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yazlab_2_frontend.Models;


namespace yazlab_2_frontend.Forms.Pages
{
    public partial class GraphViewPage : UserControl

    {
        // Seçilen node nin id si
        private Node selected_node = null;
        // Sürüklenen node nin id si
        private Node dragging_node = null;
        // Seçilen edge nin id si
        private Edge selected_edge = null;





        // Flicker olmaması için double buffered panel

        private sealed class DoubleBufferedPanel : Panel

        {

            public DoubleBufferedPanel()

            {

                DoubleBuffered = true;

                ResizeRedraw = true;

            }

        }



        private readonly DoubleBufferedPanel _canvas;


        private const float NodeRadius = 18f;
        public GraphViewPage()

        {

            InitializeComponent();

            // pnlCanvasHost (Designer’dan eklediğin) içine canvas koyuyoruz

            _canvas = new DoubleBufferedPanel

            {

                Dock = DockStyle.Fill,

            };

            panelCanvas.Controls.Add(_canvas);



            _canvas.Paint += Canvas_Paint;



            GraphStore.GraphChanged += () => _canvas.Invalidate();



            // Kod karmaşasını önlemek amacıyla buton tıklama eventleri fonksiyonlara yazıldı 

            //btnRandomLayout.Click += (_, __) => { RandomLayout(); _canvas.Invalidate(); };

            //btnResetSelection.Click += (_, __) => { ClearSelection(); _canvas.Invalidate(); };





            RandomLayout();

        }





        private void RandomLayout()

        {

            var rnd = new Random();

            var w = Math.Max(300, _canvas.ClientSize.Width);
            var h = Math.Max(300, _canvas.ClientSize.Height);

            foreach (var node in GraphStore.Nodes)
            {

                float x = rnd.Next(40, w - 40);
                float y = rnd.Next(40, h - 40);
                node.location = new Point((int)x, (int)y);
            }

        }



        private void Canvas_Paint(object? sender, PaintEventArgs e)
        {
            // Arka plana grid çizimi
            int gridSize = 20;
            using (Bitmap bmp = new Bitmap(gridSize, gridSize))
            using (Graphics gTemp = Graphics.FromImage(bmp))
            {
                using (Pen p = new Pen(Color.FromArgb(240, 240, 240))) // hafif bir gri renktir
                {
                    gTemp.DrawLine(p, 0, gridSize - 1, gridSize, gridSize - 1);
                    gTemp.DrawLine(p, gridSize - 1, 0, gridSize - 1, gridSize);
                }

                using (TextureBrush brush = new TextureBrush(bmp))
                {
                    e.Graphics.FillRectangle(brush, _canvas.ClientRectangle);
                }
            }


            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;



            // edge çizimi
            using var edgePen = new Pen(Color.Gray, 2);
            foreach (var edge in GraphStore.Edges)
            {
                // idler üzerinden düğüm bulunur
                var nodeA = edge.startNode;
                var nodeB = edge.endNode;

                if (nodeA != null && nodeB != null)
                {
                    e.Graphics.DrawLine(edgePen, nodeA.location, nodeB.location);
                }
            }

            // --- NODE (DÜĞÜM) ÇİZİMİ ---
            foreach (var n in GraphStore.Nodes)
            {
                Point p = n.location; // Doğrudan node'un içindeki koordinatı alıyoruz
                bool selected = selected_node?.Id == n.Id;

                using var brush = new SolidBrush(selected ? Color.LightSkyBlue : Color.WhiteSmoke);
                using var borderPen = new Pen(selected ? Color.DodgerBlue : Color.DimGray, selected ? 3 : 2);

                var rect = new RectangleF(p.X - NodeRadius, p.Y - NodeRadius, NodeRadius * 2, NodeRadius * 2);
                e.Graphics.FillEllipse(brush, rect);
                e.Graphics.DrawEllipse(borderPen, rect);

                var text = $"{n.Id}\n{n.Name}";
                var size = e.Graphics.MeasureString(text, Font);
                e.Graphics.DrawString(text, Font, Brushes.Black, p.X - size.Width / 2, p.Y - size.Height / 2);
            }

        }




        // Verilen node id sine göre text lerde node bilgilerini gösterir
        private void ShowNodeInfo(int nodeId)

        {

            var node = GraphStore.Nodes.FirstOrDefault(x => x.Id == nodeId);

            if (node == null) return;



            lblSelIdValue.Text = node.Id.ToString();

            lblSelAktValue.Text = node.Aktiflik.ToString("0.##");

            lblSelEtkValue.Text = node.Etkilesim.ToString();



            // Şimdilik derece/komşu Edges listenden

            var neighbors = GetNeighbors(nodeId);

            lblSelDegreeValue.Text = neighbors.Count.ToString();



            lstNeighbors.Items.Clear();

            foreach (var nb in neighbors)

                lstNeighbors.Items.Add(nb);

        }
        // Seçimi silmeyi sağlar
        private void ClearSelection()

        {

            selected_node = null;



            lblSelIdValue.Text = "-";

            lblSelAktValue.Text = "-";

            lblSelEtkValue.Text = "-";

            lblSelDegreeValue.Text = "-";



            lstNeighbors.Items.Clear();

        }

        private List<int> GetNeighbors(int nodeId)

        {

            var neighbors = new List<int>();



            foreach (var e in GraphStore.Edges)

            {

                if (e.startNode.Id == nodeId) neighbors.Add(e.endNode.Id);

                else if (e.endNode.Id == nodeId) neighbors.Add(e.startNode.Id);

            }



            return neighbors;

        }


        // çizimleri yapmayı tetikleyecek buton eventi
        private void btnRandomLayout_Click(object sender, EventArgs e)

        {


            RandomLayout(); _canvas.Invalidate();

        }
        // seçimi temizlemeyi tetikleyecek buton eventi
        private void btnResetSelection_Click(object sender, EventArgs e)
        {
            ClearSelection();
            _canvas.Invalidate();
        }

        private void panelCanvas_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panelCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            // Her tıklamada seçimler sıfırlanır
            dragging_node = null;
            selected_node = null;
            selected_edge = null;

            // Önce nodeler kontrol edilir
            foreach (var node in GraphStore.Nodes)
            {
                if (node.IsHit(e.Location))
                {
                    dragging_node = node;
                    selected_node = node;
                    ShowNodeInfo(node.Id);

                    _canvas.Invalidate();
                    return; // Node bulunmadıysa aramayı bitir
                }
            }

            // Node bulunmadıysa Edgelere bakılır
            foreach (var edge in GraphStore.Edges)
            {
                if (edge.IsHit(e.Location))
                {
                    selected_edge = edge;
                    // Show edge info fonksiyonu yaz
                    _canvas.Invalidate();
                    return;
                }
            }

            // Hiçbirşeye tıklanmadıysa 
            ClearSelection();
            _canvas.Invalidate();
        }

        private void panelCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            // Eğer sürüklenen bir node varsa
            if (dragging_node != null)
            {
                // Nesnenin konumu güncellenir
                dragging_node.location = e.Location;

                // Ekran yenilenir
                _canvas.Invalidate();
            }
        }

        private void panelCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            // Sürükleme durumu biter
            dragging_node = null;
        }
    }

}

