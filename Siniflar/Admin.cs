namespace Siniflar
{
    public class Admin : Kullanici
    {
        public Admin(string ad, string sifre, int telefon, string e_posta)
        {
            this.Ad = ad;
            this.Sifre = sifre;
            this.Telefon = telefon;
            this.EPosta = e_posta;
        }
        public override string Mesaj()
        {
            return "Sayın yönetici hoş geldiniz";
        }
    }
}
