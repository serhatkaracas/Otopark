using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class ParkYeri:TemelSinif
    {
        public int park_yeri_no { get; set; }
        public int otopark_no { get; set; }
        public string Doluluk { get; set; }
    }
}
