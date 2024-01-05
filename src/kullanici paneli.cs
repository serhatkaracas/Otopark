using Siniflar;


namespace otopark
{
    public partial class Kullanici_paneli : Form
    {
        public Kullanici_paneli()
        {
            InitializeComponent();
        }
        private void parkYeriListesiGuncelleme()
        {
            var result = Admin_paneli.parkYeriListesi.Where(i => i.otopark_no == (OtoparkKullanici_listBox.SelectedValue) && i.Doluluk != "dolu").ToList();
            ParkYeriKullanici_listBox.DataSource = result;
            ParkYeriKullanici_listBox.DisplayMember = "park_yeri_no";
            ParkYeriKullanici_listBox.ValueMember = "otopark_no";
        }
        private void button_kullanicicikis_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
            MevcutKullanici.ucret = 0;

        }
        private void Kullanici_paneli_Load(object sender, EventArgs e)
        {
            OtoparkKullanici_listBox.DataSource = null;
            OtoparkKullanici_listBox.DataSource = Admin_paneli.otoparklist;
            OtoparkKullanici_listBox.DisplayMember = "ad";
            OtoparkKullanici_listBox.ValueMember = "otopark_no";
            parkYeriListesiGuncelleme();
            MessageBox.Show(MevcutKullanici.mevcutKullanici.Ad);



        }
        private void OtoparkKullanici_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            parkYeriListesiGuncelleme();
        }

        private void button_parket_Click(object sender, EventArgs e)
        {
            if (MevcutKullanici.mevcutKullanici.otopark_no == null)
            {
                var secilenParkYeri = (ParkYeri)ParkYeriKullanici_listBox.SelectedItem;
                secilenParkYeri.Doluluk = "dolu";
                // Listedeki index'i bul
                int index = Admin_paneli.parkYeriListesi.FindIndex(p => p.park_yeri_no == secilenParkYeri.park_yeri_no && p.otopark_no == secilenParkYeri.otopark_no);
                // Eğer nesne listede varsa, yerine yeni nesneyi kopyala

                MevcutKullanici.mevcutKullanici.otopark_no = secilenParkYeri.otopark_no;
                MevcutKullanici.mevcutKullanici.park_yeri_no = secilenParkYeri.park_yeri_no;
                secilenParkYeri.kullanici = MevcutKullanici.mevcutKullanici.Ad;
                parkYeriListesiGuncelleme();
                Admin_paneli.parkYeriListesi[index] = secilenParkYeri;
                int parkSaati = int.Parse(textBox_saat.Text);
                MevcutKullanici.ucret= MevcutKullanici.saatlikUcret * parkSaati;
                MevcutKullanici.ciro += MevcutKullanici.ucret;
                // MessageBox ile seçilen değerleri göster
                MessageBox.Show("Otopark no " + secilenParkYeri.otopark_no + "kulanici adı" + MevcutKullanici.mevcutKullanici.Ad);
                MessageBox.Show("Ödemeniz gereken ücret " + MevcutKullanici.ucret);
            }
            else
            {
                MessageBox.Show("Aracınızı zaten park etmiştiniz.");
            }
        }

        private void button_parktanCik_Click(object sender, EventArgs e)
        {

            // Listedeki index'i bul
            int index = Admin_paneli.parkYeriListesi.FindIndex(p => p.otopark_no == MevcutKullanici.mevcutKullanici.otopark_no && p.park_yeri_no == MevcutKullanici.mevcutKullanici.park_yeri_no);
            // Eğer nesne listede varsa, yerine yeni nesneyi kopyala
            var secilenParkYeri = Admin_paneli.parkYeriListesi[index];
            MevcutKullanici.mevcutKullanici.otopark_no = null;
            MevcutKullanici.mevcutKullanici.park_yeri_no = -1;
            secilenParkYeri.Doluluk = "boş";
            secilenParkYeri.kullanici = null;
            Admin_paneli.parkYeriListesi[index] = secilenParkYeri;
            parkYeriListesiGuncelleme();
            MevcutKullanici.ucret = 0;
        }

      
    }
}