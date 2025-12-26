using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yazlab_2_frontend.Models.JsonModels
{
    public class JsonNode
    {
        public int id { get; set; }
        public string name { get; set; }
        public double aktiflik { get; set; }
        public int etkilesim { get; set; }
        public int baglantiSayisi { get; set; }
        public float radius { get; set; }
        public string nodeRengi { get; set; }
    }
}
