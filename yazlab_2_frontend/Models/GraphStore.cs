using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models
{

    public static class GraphStore

    {

        public static event Action? GraphChanged;

        public static List<Node> Nodes { get; } = new();

        public static List<Edge> Edges { get; } = new();


        public static double ComputeWeight(Node startnode, Node endnode)

        {



            // Dinamik bağl. sayısı: mevcut edge'lere göre

            int degA = startnode.GetDegree(Edges);

            int degB = endnode.GetDegree(Edges);



            double dAkt = startnode.Aktiflik - endnode.Aktiflik;

            double dEtk = startnode.Etkilesim - endnode.Etkilesim;

            double dDeg = degA - degB;



            // İsterdeki gibi: 1 / (1 + Δ^2 + Δ^2 + Δ^2)

            double denom = 1.0 + (dAkt * dAkt) + (dEtk * dEtk) + (dDeg * dDeg);

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

            Nodes.Add(node);

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



        public static void AddEdge(Node a, Node b)

        {

            if (a == b) throw new InvalidOperationException("Self-loop eklenemez.");

            if (HasEdgeUndirected(a, b)) throw new InvalidOperationException("Bu bağlantı zaten var.");



            var w = ComputeWeight(a, b);

            Edges.Add(new Edge { startNode = a, endNode = b, Weight = w });


            // tüm nodeleri teker teker gezip derecesini değiştirmek yerine
            // sadece etkilenen nodelerin derecesi değiştirilir
            a.BaglantiSayisi = a.GetDegree(Edges);
            b.BaglantiSayisi = b.GetDegree(Edges);


            GraphChanged?.Invoke();

        }

        public static void RemoveEdge(Node a, Node b)

        {

            Edges.RemoveAll(e =>

                (e.startNode == a && e.endNode == b) ||

                (e.startNode == b && e.endNode == a));



            // tüm nodeleri teker teker gezip derecesini değiştirmek yerine
            // sadece etkilenen nodelerin derecesi değiştirilir
            a.BaglantiSayisi = a.GetDegree(Edges);
            b.BaglantiSayisi = b.GetDegree(Edges);

            GraphChanged?.Invoke();

        }







    }
}
