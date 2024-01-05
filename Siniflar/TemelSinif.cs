using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public abstract class TemelSinif
    {
        public Guid Id { get; set; }
        public string Ad { get; set; }
        public abstract void Tanit();
    }
   
}
