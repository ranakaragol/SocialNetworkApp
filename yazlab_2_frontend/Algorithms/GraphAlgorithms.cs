using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using yazlab_2_frontend.Models;

namespace yazlab_2_frontend.Algorithms
{
    public class GraphAlgorithms
    {

        public GraphAlgorithms() { }



        // BFS algoritması
        // Ana mantığı bir queue kullanılarak yapıldı
        // Girdi : başlangıç node si , tüm nodeler ve tüm edgeler
        // Çıktı : sırasıyla ziyaret edilen nodelerin listesi
        public List<Node> BFS_algorithm(Node firstnode, List<Edge> alledges, List<Node> allnodes)
        {
            Queue<Node> nodequeue = new Queue<Node>();
            List<Node> visitednodes = new List<Node>();
            HashSet<int> visited_ids = new HashSet<int>();
            if(firstnode == null)
            {
                return null;
            }
            // Başlangıcı ayarla
            nodequeue.Enqueue(firstnode);
            visited_ids.Add(firstnode.id);

            while (nodequeue.Count > 0)
            {
                Node current = nodequeue.Dequeue();
                visitednodes.Add(current); // İşlem sırasına ekle

                foreach (Edge edge in alledges)
                {
                    Node neighbor = null;

                    // kenarın bir ucu current node ise diğer ucu komşu node dir bu sebeple edgenin hem startına hemde endine bakılır
                    if (edge.startNode.id == current.id)
                    {
                        neighbor = edge.endNode;
                    }
                    else if (edge.endNode.id == current.id)
                    {
                        neighbor = edge.startNode;
                    }

                    // eğer bir komşu bulunduysa ve daha önce ziyaret edilmediyse
                    if (neighbor != null && !visited_ids.Contains(neighbor.id))
                    {
                        visited_ids.Add(neighbor.id); // hemen işaretle ki tekrar eklenmesin
                        nodequeue.Enqueue(neighbor);
                    }
                }
            }
            return visitednodes;
        }

        // DFS algoritması 
        // Stack kullanmak yerine özyinelemeli DFS_algorithm fonksiyonu kullanmayı tercih ettik
        // Girdi : Başlangıç node si ve tüm edgeleri içeren liste
        // Çıktı : Tek Tek ziyaret edilen nodelerin listesi
        public List<Node> RunDFS(Node startNode, List<Edge> allEdges)
        {
            List<Node> visitedOrder = new List<Node>();
            HashSet<int> visitedIds = new HashSet<int>();
            if (startNode == null)
            {
                return null;
            }
            // Yardımcı fonksiyonu (Recursive) çağırıyoruz
            DFS_algorithm(startNode, allEdges, visitedIds, visitedOrder);

            return visitedOrder;
        }
        public List<Node> DFS_algorithm(Node current , List<Edge> alledges , HashSet<int> visited_nodeids , List<Node> order)
        {
            visited_nodeids.Add(current.id);
            order.Add(current);
            List<Node> neighbors = new List<Node>();
           
            // burada komşu ziyareti syntax ı BFS algoritmasına göre farklı alternatif

           neighbors = alledges
        .Where(e => e.startNode.id == current.id || e.endNode.id == current.id)
        .Select(e => e.startNode.id == current.id ? e.endNode : e.startNode)
        .ToList();


            foreach (Node neighbor in neighbors) {

                if (!visited_nodeids.Contains(neighbor.id))
                {
                    DFS_algorithm(neighbor, alledges, visited_nodeids, order);
                }


            }

            





            return null;
        }


    }
}
