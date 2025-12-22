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

        //NODE ÖZELLİKLERİ

            // node ismi
            public string name { get; set; }

            public int id { get; set; }
            // bir node nin çapı
            public int radius { get; set; } = 20;

            // node nin rengi bu renk değişken bir değer olucak
            public Color color { get; set; } = Color.AliceBlue;




        // NODE ÇERÇEVESİ ÖZELLİKLERİ

        // node nin çerçeve rengi
        public Color borderColor { get; set; } = Color.Black;

            // node nin çerçeve kalınlığı
            public int borderThickness { get; set; } = 1;

        // EK METODLAR

            // default node stiline ayarlamak için
            public void ResetStyle()
            {
                color = Color.SteelBlue;
                borderColor = Color.Black;
                borderThickness = 1;
            }


            // kullanıcı node yemi tıklıyo yoksa boşluğamı tıklıyo kontrol eden metod
            // pisagor teoremi kullanır
            public bool IsHit(Point p)
            {
                return Math.Sqrt(Math.Pow(p.X - location.X, 2) + Math.Pow(p.Y - location.Y, 2)) <= radius;
            }

            // node için degree hesaplamayı sağlayan fonksiyon
            // kısaca etrafında edge varmı ona bakar varsa degree ye 1 ekler

            public int GetDegree(List<Edge> allEdges)
            {
                return allEdges.Count(e => e.startNode == this || e.endNode == this);
            }

    }
}
