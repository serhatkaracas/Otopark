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
            MessageBox.Show("Kullan�c� giri� ekran�na ho�geldiniz");
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
                MessageBox.Show("Giri� yap�ld�");
                kullanici_kayit Kullanici_kayit = new kullanici_kayit();

                // Form2'yi g�sterin ve modally a��n (form2 kapanana kadar form1 �zerinde �al��amazs�n�z)
                Kullanici_kayit.Show();
            }

            else
            {
                MessageBox.Show("Kullan�c� ad� veya �ifre hatal�");
            }
        }

        private void button_sifremiunuttum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("�ifre s�f�rlama ba�lant�s� mail adresine g�nderildi");
        }
    }

}