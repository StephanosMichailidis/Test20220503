using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test03052022Michailidis
{
    public class Faktura2
    {
        public int id { get; set; }
        public DateTime datum { get; set;  }
        public int cislo { get; set; }
        public string odberatel { get; set; }
        public string nazev { get; set; }
        public int pocet { get; set; }
        public float cenajednoho { get; set; }
        public float cenacelkem { get; set; }
        public float  DPH { get; set; }
        public float cenaDPH { get; set; }

    }
}
