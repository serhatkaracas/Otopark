namespace Siniflar
{
    public class Kullanici : TemelSinif
    {
        public static object kullanici_kayit;

        public string Sifre { get; set; }
        public string EPosta { get; set; }
        public int Telefon { get; set; }
        public string Plaka { get; set; }

        public int park_yeri_no { get; set; }
        public string otopark_no { get; set; }

        public Kullanici() 
        {
            park_yeri_no = -1;    
        }


        virtual public string Mesaj()
        {
            return "Kaydınız başarıyla oluşturulmuştur.";
        }
        public override void Tanit()
        {
            Console.WriteLine($"Ad: {Ad}, E-Posta: {EPosta}, Telefon: {Telefon}");
        }

    }
}
