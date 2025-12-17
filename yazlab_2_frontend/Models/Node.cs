using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models
{ 
    // Ana node sınıfı 
    public class Node
    {
        // node koordinatları
        public Point location { get; set; }
        // node ismi
        public string name { get; set; }

        public int id { get; set; }
        // bir node nin çapı
        public int radius { get; set; } = 20;


        // kullanıcı node yemi tıklıyo yoksa boşluğamı tıklıyo kontrol eden metod
        // pisagor teoremi kullanır
        public bool IsHit(Point p)
        {
            return Math.Sqrt(Math.Pow(p.X - location.X, 2) + Math.Pow(p.Y - location.Y, 2)) <= radius;
        }

    }
}
