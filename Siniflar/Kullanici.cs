namespace Siniflar
{
    public class Kullanici : TemelSinif
    {
        public string Sifre { get; set; }
        public string EPosta { get; set; }
        public int Telefon { get; set; }
        public string Plaka { get; set; }


        virtual public string Mesaj()
        {
            return "Kullanıcı Kaydedildi.";
        }
        public override void Tanit()
        {
            Console.WriteLine($"Ad: {Ad}, E-Posta: {EPosta}, Telefon: {Telefon}");
        }

    }
}
