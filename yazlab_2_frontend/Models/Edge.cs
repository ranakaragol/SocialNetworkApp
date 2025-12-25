using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models
{
    public class Edge
    {
      
    // Edge özellikleri

        // bağlantı id si
        public int Id { get; set; }
        // başlangıç ve bitiş node leri (yön belirtmez)
        public Node startNode { get; set; }
        public Node endNode { get; set; }

        // ağırlık (maliyet)
        public double Weight { get; set; }

        // Ekstra metodlar

        public bool IsHit(Point pt)
        {
            // Çizgi üzerindeki en yakın noktayı bulma algoritma

            // başlangıç ve bitiş node larının sırasıyla x ve y değerleri alınır
            float x1 = startNode.location.X;
            float y1 = startNode.location.Y;
            float x2 = endNode.location.X;
            float y2 = endNode.location.Y;


            float dx = x2 - x1;
            float dy = y2 - y1;

            if (dx == 0 && dy == 0) return false;

            float t = ((pt.X - x1) * dx + (pt.Y - y1) * dy) / (dx * dx + dy * dy);
            t = Math.Max(0, Math.Min(1, t));

            float closestX = x1 + t * dx;
            float closestY = y1 + t * dy;

            float distance = (float)Math.Sqrt(Math.Pow(pt.X - closestX, 2) + Math.Pow(pt.Y - closestY, 2));

            // 5 piksellik bir tolerans tanıyalım (çizgiyi yakalamak zordur)
            return distance < 5;
        }



    }
   
}
