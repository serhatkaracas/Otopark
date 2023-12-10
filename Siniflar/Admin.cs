using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    internal class Admin:Kullanici
    {


        public Admin(string ad, string sifre, int telefon, string e_posta)
        {
            this.Ad = ad;
            this.Sifre = sifre;
            this.Telefon = telefon;
            this.EPosta = e_posta;
        }
    }
}
