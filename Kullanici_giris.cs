namespace otopark
{
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanýcý giriþ ekranýna hoþgeldiniz");
        }
        private void button2_Click(object sender, EventArgs e)
        {

            int bulundu = 0;
            for (int i = 0; i < 3; i++)
            {
                if (text_ad_giris.Text == Program.kullaniciAdlari[0] && text_sifre_giris.Text == Program.sifreler[0])
                {
                    bulundu = 1;
                    break;
                }
                else if (text_ad_giris.Text == Program.kullaniciAdlari[i] && text_sifre_giris.Text == Program.sifreler[i])
                {
                    bulundu = 2;
                    break;
                }
            }
            if (bulundu == 1)
            {
                MessageBox.Show("Giriþ yapýldý");
                Admin_paneli admin_paneli = new Admin_paneli();
                admin_paneli.Show();
                this.Hide();
            }

            else if (bulundu == 2)
            {
                MessageBox.Show("Giriþ yapýldý");
                kullanici_kayit Kullanici_kayit = new kullanici_kayit();
                Kullanici_kayit.Show();
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
    }

}