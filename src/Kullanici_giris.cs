using Siniflar;

namespace otopark
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            int bulundu = 0;
            if (text_ad_giris.Text == "admin" && text_sifre_giris.Text == "1")
            {
                bulundu = 1;
            }
            for (int i = 0; i < kullanici_kayit.Kullanici_list.Count; i++)
            {

                if (text_ad_giris.Text == kullanici_kayit.Kullanici_list[i].Ad && text_sifre_giris.Text == kullanici_kayit.Kullanici_list[i].Sifre)
                {
                    bulundu = 2;
                     MevcutKullanici.mevcutKullanici = kullanici_kayit.Kullanici_list[i];
                    break;
                }
            }
            if (bulundu == 1)
            {
                Admin_paneli admin_paneli = new Admin_paneli();
                admin_paneli.Show();
                this.Hide();
            }
            else if (bulundu == 2)
            {
                MessageBox.Show("Giriþ yapýldý");
                Kullanici_paneli kullanici_paneli = new Kullanici_paneli();
                kullanici_paneli.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanýcý adý veya þifre hatalý");
            }
        }
        private void button_sifremiunuttum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Þifre sýfýrlama baðlantýsý mail adresine gönderildi");
        }
        private void button_Hesapolustur_Click(object sender, EventArgs e)
        {
            kullanici_kayit Kullanici_kayit = new kullanici_kayit();
            Kullanici_kayit.Show();
            this.Hide();
        }
    }
}