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
        public static List<Node> BFS_algorithm(Node firstnode, List<Edge> alledges, List<Node> allnodes)
        {
            Queue<Node> nodequeue = new Queue<Node>();
            List<Node> visitednodes = new List<Node>();
            HashSet<int> visited_ids = new HashSet<int>();

            if (firstnode == null)
            {
                return null;
            }

            // Başlangıcı ayarla
            nodequeue.Enqueue(firstnode);
            visited_ids.Add(firstnode.Id);

            while (nodequeue.Count > 0)
            {
                Node current = nodequeue.Dequeue();
                visitednodes.Add(current); // İşlem sırasına ekle

                foreach (Edge edge in alledges)
                {
                    Node neighbor = null;

                    // kenarın bir ucu current node ise diğer ucu komşu node dir bu sebeple edgenin hem startına hemde endine bakılır
                    if (edge.startNode == current)
                    {
                        
                        neighbor = edge.endNode;
                    }
                    else if (edge.endNode == current)
                    {
                        
                        neighbor = edge.startNode;
                    }

                    // eğer bir komşu bulunduysa ve daha önce ziyaret edilmediyse
                    if (neighbor != null && !visited_ids.Contains(neighbor.Id))
                    {
                        visited_ids.Add(neighbor.Id); // tekrar eklenmesin diye hemen işaretlenir
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
        public static List<Node> RunDFS(Node startNode, List<Edge> allEdges , List<Node> allNodes)
        {
            List<Node> visitedOrder = new List<Node>();
            HashSet<int> visitedIds = new HashSet<int>();
            if (startNode == null)
            {
                return null;
            }
            // Yardımcı fonksiyonu (Recursive) çağırıyoruz
            DFS_algorithm(startNode, allEdges, visitedIds, visitedOrder , allNodes);

            return visitedOrder;
        }
        public static List<Node> DFS_algorithm(Node current , List<Edge> alledges , HashSet<int> visited_nodeids , List<Node> order, List<Node> allNodes)
        {
            visited_nodeids.Add(current.Id);
            order.Add(current);
            List<Node> neighbors = new List<Node>();
           
            // burada komşu ziyareti syntax ı BFS algoritmasına göre farklı alternatif

           neighbors = alledges
        .Where(e => e.startNode == current || e.endNode == current)
        .Select(e => e.startNode == current ?
        allNodes.Find(n => n == e.endNode)
        :
        allNodes.Find(n => n == e.startNode))
        .ToList();


            foreach (Node neighbor in neighbors) {

                if (!visited_nodeids.Contains(neighbor.Id))
                {
                    DFS_algorithm(neighbor, alledges, visited_nodeids, order, allNodes);
                }


            }

            





            return null;
        }

        // Dijkstra Algoritması
        // Girdi: Başlangıç Node, Bitiş Node, Tüm Kenarlar, Tüm Düğümler
        // Çıktı: En kısa yolu oluşturan düğümlerin listesi (Sıralı)
        public static List<Node> Dijkstra_algorithm(Node startNode, Node endNode, List<Edge> allEdges, List<Node> allNodes)
        {
            // Mesafe ve önceki düğüm tabloları
            Dictionary<Node, double> distances = new Dictionary<Node, double>();
            Dictionary<Node, Node> previous = new Dictionary<Node, Node>();
            List<Node> unvisited = new List<Node>();

            // Başlangıçta tüm mesafeler sonsuz alınır
            foreach (var node in allNodes)
            {
                distances[node] = double.MaxValue;
                previous[node] = null;
                unvisited.Add(node);
            }
            distances[startNode] = 0;

            while (unvisited.Count > 0)
            {
                // Ziyaret edilmemişler arasından mesafesi en küçük olanı seçilir
                Node current = unvisited.OrderBy(n => distances[n]).First();

                // Eğer en küçük mesafeli düğüm sonsuzsa, geri kalanlara ulaşılamıyordur
                if (distances[current] == double.MaxValue) break;

                // Hedefe varınca döngü kırılır
                if (current == endNode) break;

                unvisited.Remove(current);

                // Komşuları bul bfs deki komşu bulma mantığı ile aynı
                var neighborEdges = allEdges.Where(e => e.startNode == current || e.endNode == current).ToList();

                foreach (var edge in neighborEdges)
                {
                    Node neighbor = (edge.startNode == current) ? edge.endNode : edge.startNode;

                    // Sadece ziyaret edilmemiş komşulara bakar
                    if (unvisited.Contains(neighbor))
                    {
                        // Yeni maliyet = Şu ana kadarki maliyet + Kenar ağırlığı
                        double newDist = distances[current] + edge.Weight;

                        if (newDist < distances[neighbor])
                        {
                            distances[neighbor] = newDist; // Daha kısa yol bulundu güncelle
                            previous[neighbor] = current;  // Geldiğimiz yeri kaydet
                        }
                    }
                }
            }

            // Şimdide yol geriye doğru oluşturulur
            // EndNode'dan başlayıp StartNode'a kadar 'previous' üzerinden geri gidiyoruz
            List<Node> path = new List<Node>();
            Node pathNode = endNode;

            // Eğer hedefe hiç ulaşılamadıysa (mesafe hala sonsuzsa) null dön
            if (distances[endNode] == double.MaxValue) return null;

            while (pathNode != null)
            {
                path.Add(pathNode);
                pathNode = previous[pathNode];
            }

            path.Reverse(); // Tersten eklediğimiz için listeyi düzeltiyoruz
            return path;
        }

        // Bağlı Bileşenler Algoritması
        // Girdi: tüm nodeler ve tüm edgeler
        // Çıktı: Her bir grup için ayrı bir liste içeren ana liste
        public static List<List<Node>> ConnectedComponents_Algorithm(List<Node> allNodes, List<Edge> allEdges)
        {
            List<List<Node>> components = new List<List<Node>>();
            HashSet<int> visitedIds = new HashSet<int>();

            // Tüm düğümleri tek tek gezer
            foreach (var node in allNodes)
            {
                // Eğer bu düğüme daha önce hiç uğramadıysak bu yeni bir adanın başlangıcıdır
                if (!visitedIds.Contains(node.Id))
                {
                    // Bu düğümden başlayıp gidilebilecek HER YERİ bul (BFS kullanarak)
                    // Yukarıdaki BFS kodunu kullanmak yerine sıfırdan lokal bir bfs mantığı kurmak daha mantıklı gibi geldi

                    List<Node> newComponent = new List<Node>();
                    Queue<Node> queue = new Queue<Node>();

                    queue.Enqueue(node);
                    visitedIds.Add(node.Id);

                    while (queue.Count > 0)
                    {
                        Node current = queue.Dequeue();
                        newComponent.Add(current);

                        // Komşuları bul
                        foreach (var edge in allEdges)
                        {
                            Node neighbor = null;
                            if (edge.startNode == current) neighbor = edge.endNode;
                            else if (edge.endNode == current) neighbor = edge.startNode;

                            if (neighbor != null && !visitedIds.Contains(neighbor.Id))
                            {
                                visitedIds.Add(neighbor.Id);
                                queue.Enqueue(neighbor);
                            }
                        }
                    }
                    // Bulunan adayı ana listeye ekle
                    components.Add(newComponent);
                }
            }
            return components;
        }

        // A* Algoritması
        // Dijkstra nın aksine körü körüne en ucuz yolu aramak yerine hedefin yerini bildiği için o tarafa öncelik verir
        // Girdi: başlangıç ve bitiş nodesi tüm nodeler ve tüm edgeler
        // Çıktı: bulunan en kısa yolu içeren düğümler
        public static List<Node> AStar_Algorithm(Node startNode, Node endNode, List<Edge> allEdges, List<Node> allNodes)
        {
            // işlenecek düğümler
            List<Node> openSet = new List<Node> { startNode };

            // gelinen yolun kaydı
            Dictionary<Node, Node> cameFrom = new Dictionary<Node, Node>();

            // gScore: başlangıçtan şu ana kadar olan gerçek maliyet
            Dictionary<Node, double> gScore = new Dictionary<Node, double>();
            foreach (var n in allNodes) gScore[n] = double.MaxValue;
            gScore[startNode] = 0;

            // fScore: gScore + Heuristic yani Tahmini toplam maliyet
            Dictionary<Node, double> fScore = new Dictionary<Node, double>();
            foreach (var n in allNodes) fScore[n] = double.MaxValue;
            fScore[startNode] = Heuristic(startNode, endNode);

            while (openSet.Count > 0)
            {
                // fScore u en düşük olan düğüm seçilir yani En umut verici olan
                Node current = openSet.OrderBy(n => fScore[n]).First();

                if (current == endNode)
                    return ReconstructPath(cameFrom, current); // Hedefe ulaştık!

                openSet.Remove(current);

                // Komşular bulunur
                var neighborEdges = allEdges.Where(e => e.startNode == current || e.endNode == current).ToList();

                foreach (var edge in neighborEdges)
                {
                    Node neighbor = (edge.startNode == current) ? edge.endNode : edge.startNode;

                    // Yeni gScore hesaplanır
                    double tentative_gScore = gScore[current] + edge.Weight;

                    if (tentative_gScore < gScore[neighbor])
                    {
                        // Daha iyi bir yol bulundu
                        cameFrom[neighbor] = current;
                        gScore[neighbor] = tentative_gScore;
                        fScore[neighbor] = gScore[neighbor] + Heuristic(neighbor, endNode);

                        if (!openSet.Contains(neighbor))
                            openSet.Add(neighbor);
                    }
                }
            }

            return null; // Yol yok
        }
        private static double Heuristic(Node a, Node b)
        {
            // Pisagor ile koordinatlar arası düz çizgi mesafesi hesaplanır
            return Math.Sqrt(Math.Pow(a.location.X - b.location.X, 2) + Math.Pow(a.location.Y - b.location.Y, 2));
        }
        private static List<Node> ReconstructPath(Dictionary<Node, Node> cameFrom, Node current)
        {
            // Yol geriye doğru oluşturulur
            List<Node> totalPath = new List<Node> { current };
            while (cameFrom.ContainsKey(current))
            {
                current = cameFrom[current];
                totalPath.Add(current);
            }
            totalPath.Reverse();
            return totalPath;
        }

        // Derece Merkeziliği
        // Kısaca her node için dereceyi bulup bunu bir dictionary ile Düğüm -> Skor şeklinde kaydeder böylelikle 
        // en merkezi düğümler bulunur
        // Girdi: Tüm nodeler ve Tüm edgeler
        // Çıktı: Düğüm -> Skor (Derece) eşleşmesi içeren bir dictionary
        public static Dictionary<Node, int> DegreeCentrality_Algorithm(List<Node> allNodes, List<Edge> allEdges)
        {
            Dictionary<Node, int> scores = new Dictionary<Node, int>();

            foreach (var node in allNodes)
            {
               // hali hazırda degree hesaplayan method node sınıfının içine gömülü olduğu için direk o kullanıldı
               int degree = node.GetDegree(allEdges);
                scores.Add(node, degree);
            }

            return scores;
        }

        // Welsh-Powell Algoritması
        // Amacı komşu olan iki düğümün asla aynı renk olmamasını sağlamaktır
        // Girdi: Tüm nodeler ve tüm edgeler
        // Çıktı: Her renk grubu için bir liste (Örn: Grup 0: Kırmızılar, Grup 1: Maviler...)
        public static Dictionary<int, List<Node>> WelshPowell_Algorithm(List<Node> allNodes, List<Edge> allEdges)
        {
            // Düğümler derecelerine göre sıralanır
            var sortedNodes = allNodes.OrderByDescending(n =>
                allEdges.Count(e => e.startNode == n || e.endNode == n)
            ).ToList();

            Dictionary<int, List<Node>> colorGroups = new Dictionary<int, List<Node>>();
            HashSet<int> coloredNodeIds = new HashSet<int>();

            int colorIndex = 0;

            // Tüm düğümler boyanana kadar devam eder
            while (coloredNodeIds.Count < allNodes.Count)
            {
                List<Node> currentGroup = new List<Node>();

                // Sıralı listeyi gezer
                foreach (var node in sortedNodes)
                {
                    // Bu düğüm zaten boyandıysa geçelim
                    if (coloredNodeIds.Contains(node.Id)) continue;

                    // Bu düğüm şuanki renk grubundaki düğümlerden herhangi biriyle komşumu ona bakılır
                    bool isAdjacentToCurrentColor = false;
                    foreach (var coloredNode in currentGroup)
                    {
                        bool connected = allEdges.Any(e =>
                            (e.startNode == node && e.endNode == coloredNode) ||
                            (e.startNode == coloredNode && e.endNode == node));
                        // Komşu düğüm bulundu
                        if (connected)
                        {
                            isAdjacentToCurrentColor = true;
                            break;
                        }
                    }

                    // Komşu değilse bu rengi verir
                    if (!isAdjacentToCurrentColor)
                    {
                        currentGroup.Add(node);
                        coloredNodeIds.Add(node.Id);
                    }
                }

                // Grup kaydedilir ve sonraki renge geçilir
                colorGroups.Add(colorIndex, currentGroup);
                colorIndex++;
            }

            return colorGroups;
        }


    }
}
