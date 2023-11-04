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

            var bulundu = false;
            for (int i = 0; i < 3; i++)
            {
                if (text_ad_giris.Text == Program.kullaniciAdlari[i] && text_sifre_giris.Text == Program.sifreler[i])
                {
                    bulundu = true;
                    break;
                }
            }
            if (bulundu == true)
            {
                MessageBox.Show("Giriþ yapýldý");
                kullanici_kayit Kullanici_kayit = new kullanici_kayit();

                // Form2'yi gösterin ve modally açýn (form2 kapanana kadar form1 üzerinde çalýþamazsýnýz)
                Kullanici_kayit.Show();
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