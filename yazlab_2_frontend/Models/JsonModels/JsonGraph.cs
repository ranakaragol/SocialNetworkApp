using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models.JsonModels
{
    public class JsonGraph
    {
        public List<JsonNode> nodes { get; set; }
        public List<JsonEdge> edges { get; set; }
    }
}
