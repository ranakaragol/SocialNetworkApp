using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models
{ 
    public class Node
    {   
    // Node özellikleri
       public int Id { get; set; }
       public string Name { get; set; } = "";
       public double Aktiflik { get; set; }
       public int Etkilesim { get; set; }
       public int BaglantiSayisi { get; set; }
        // node çapı
        public int radius { get; set; } = 20;

        // node koordinatları
        public Point location { get; set; }

        // Ekstra metodlar

        // kullanıcı node yemi tıklıyo yoksa boşluğamı tıklıyo kontrol eden metod
        // pisagor teoremi kullanır
        public bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - location.X, 2) + Math.Pow(p.Y - location.Y, 2)) <= radius;
        }

        // node için degree hesaplamayı sağlayan fonksiyon
        public int GetDegree(List<Edge> allEdges)
        {
            return allEdges.Count(e => e.startNode == this || e.endNode == this);
        }
    }
}
