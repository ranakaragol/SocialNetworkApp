using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models
{

    public static class GraphStore

    {
        public static void NotifyGraphChanged()
        {
            GraphChanged?.Invoke();
        }
        public static event Action? GraphChanged;

        public static List<Node> Nodes { get; } = new();

        public static List<Edge> Edges { get; } = new();

        // Artan unique edge id si tutan değişken
        private static int _lastNodeId = 0;
        private static int _lastEdgeId = 0;


        public static double ComputeWeight(Node startnode, Node endnode)

        {
            // Özellik farkları
            double dAkt = startnode.Aktiflik - endnode.Aktiflik;
            double dEtk = startnode.Etkilesim -endnode.Etkilesim;
            double dDeg = startnode.GetDegree(Edges) - endnode.GetDegree(Edges);

            double featureDistance =
                (dAkt * dAkt) +
                (dEtk * dEtk) +
                (dDeg * dDeg);

            // --- GEOMETRİK MESAFE ---
            double dx = startnode.location.X - endnode.location.X;
            double dy = startnode.location.Y - endnode.location.Y;
            double spatialDistance = Math.Sqrt(dx * dx + dy * dy);

            // normalize etmek iyi olur
            spatialDistance = spatialDistance / 100.0;

            // Toplam maliyet
            double denom = 1.0 + featureDistance + spatialDistance;

            return 1.0 / denom;
        }

        public static bool HasEdgeUndirected(Node a, Node b)

        {

            return Edges.Any(e =>

                (e.startNode == a && e.endNode == b) ||

                (e.startNode == b && e.endNode == a));

        }

        public static void AddNode(Node node)

        {

            var komsular = Edges
                .Where(e => e.startNode == node || e.endNode == node)
                .Select(e => e.startNode == node ? e.endNode : e.startNode)
                .Distinct() // Aynı komşuyla birden fazla bağ varsa tek bir kez alınır
                .ToList();

            // Düğüm eklenir
                Nodes.Add(node);

            // Sadece komşuların derecesi değiştirilir tüm node ler tek tek gezilmez
            foreach (var komsu in komsular)
            {
                komsu.BaglantiSayisi = komsu.GetDegree(Edges);
            }

            GraphChanged?.Invoke();


            


        }



        public static void RemoveNode(Node node)

        {

            if (node == null) return;

            // komşular bulunur
            var komsular = Edges
                .Where(e => e.startNode == node || e.endNode == node)
                .Select(e => e.startNode == node ? e.endNode : e.startNode)
                .Distinct() // Aynı komşuyla birden fazla bağ varsa tek bir kez alınır
                .ToList();

            // Düğüm ve ona bağlı tüm kenarlar silinir
            Nodes.Remove(node);
            Edges.RemoveAll(e => e.startNode == node || e.endNode == node);

            // Sadece komşuların derecesi değiştirilir tüm node ler tek tek gezilmez
            foreach (var komsu in komsular)
            {
                komsu.BaglantiSayisi = komsu.GetDegree(Edges);
            }

            GraphChanged?.Invoke();

        }



        public static int GenerateNodeId()
        {
            if (Nodes.Count == 0) _lastNodeId = 0;
            _lastNodeId++;
            return _lastNodeId;
        }

        public static int GenerateEdgeId()
        {
            if (Edges.Count == 0) _lastEdgeId = 0;
            _lastEdgeId++;
            return _lastEdgeId;
        }

        public static void AddEdge(Node a, Node b)

        {

            if (a == b) throw new InvalidOperationException("Self-loop eklenemez.");

            if (HasEdgeUndirected(a, b)) throw new InvalidOperationException("Bu bağlantı zaten var.");



            var w = ComputeWeight(a, b);
            // Random edge id belirleme
            int id = GenerateEdgeId();
            Edges.Add(new Edge { Id = id, startNode = a, endNode = b, Weight = w });



            // tüm nodeleri teker teker gezip derecesini değiştirmek yerine
            // sadece etkilenen nodelerin derecesi değiştirilir
            a.BaglantiSayisi = a.GetDegree(Edges);
            b.BaglantiSayisi = b.GetDegree(Edges);


            GraphChanged?.Invoke();

        }

        // Başlangıç ve Bitiş nodelerinin id sine göre edge yi siler
        public static void RemoveEdge(Node a, Node b)

        {
            if (a == null || b == null)
            {
                MessageBox.Show("Edgeye ait başlangıç yada bitiş Node'sinin Id'si hatalı.");
                return;
            }
            
            Edges.RemoveAll(e =>

                (e.startNode == a && e.endNode == b) ||

                (e.startNode == b && e.endNode == a));



            // tüm nodeleri teker teker gezip derecesini değiştirmek yerine
            // sadece etkilenen nodelerin derecesi değiştirilir
            a.BaglantiSayisi = a.GetDegree(Edges);
            b.BaglantiSayisi = b.GetDegree(Edges);

            GraphChanged?.Invoke();

        }

        public static void SyncIdCountersFromData()
        {
            // Node sayaç
            _lastNodeId = Nodes.Count == 0 ? 0 : Nodes.Max(n => n.Id);

            // Edge sayaç (Edge Id’ye göre)
            _lastEdgeId = Edges.Count == 0 ? 0 : Edges.Max(e => e.Id);
        }
    }
}
