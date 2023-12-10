using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Kullanici : TemelSinif
    {
        public string Sifre { get; set; }
        public string EPosta { get; set; }
        public int Telefon { get; set; }
        public string Plaka { get; set; }
    }

}
