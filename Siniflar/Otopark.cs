using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Siniflar
{
    public class Otopark : ParkYeri,IKaydedilebilir
    {
        public readonly object IKaydedilebilir;

        public int park_yeri_sayisi { get; set; }
        public string ad { get; set; }
        public void Kaydet()
        {
            Console.WriteLine("Otopark Kaydedildi.");
        }
        public override void Tanit()
        {
            Console.WriteLine($"Otopark Adı: {ad}, Park Yeri Sayısı: {park_yeri_sayisi}");
        }
        public string Kaydedildi()
        {
            return "Otopark Kaydedildi";
        }
    }   

}
