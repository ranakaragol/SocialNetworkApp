using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models.JsonModels
{
    public class JsonEdge
    {
        public int id { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public double? weight { get; set; }
    }
}
