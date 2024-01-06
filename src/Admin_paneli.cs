using Siniflar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace otopark
{
    public partial class Admin_paneli : Form
    {
        public Admin_paneli()
        {
            Admin admin = new Admin("Admin", "1", 505111, "a@a.com");
            MessageBox.Show(admin.Mesaj());
            InitializeComponent();
        }
        static public List<Otopark> otoparklist = new List<Otopark>();
        static public List<ParkYeri> parkYeriListesi = new List<ParkYeri>();
        private void Admin_paneli_Load(object sender, EventArgs e)
        {
            foreach (var eleman in kullanici_kayit.Kullanici_list)
            {
                listBox1.Items.Add(eleman.Ad);
            }
            int ciro = MevcutKullanici.ciro;
            label_ciro.Text = ciro.ToString();

            comboBox_otoparkListesi.DataSource = null;
            comboBox_otoparkListesi.DataSource = otoparklist;
            comboBox_otoparkListesi.DisplayMember = "ad";
            comboBox_otoparkListesi.ValueMember = "otopark_no";
        }
        private void button_cikisadmin_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        public Siniflar.Otopark yeni_otopark;
        private void button_oparkEkle_Click(object sender, EventArgs e)
        {
            Otopark yeni_otopark = new Otopark();
            yeni_otopark.ad = textBox_otopark_adi.Text;
            yeni_otopark.park_yeri_sayisi = int.Parse(textBox_park_yeri_sayisi.Text);
            yeni_otopark.otopark_no = textBox_otopark_no.Text;

            otoparklist.Add(yeni_otopark);
            comboBox_otoparkListesi.DataSource = null;
            comboBox_otoparkListesi.DataSource = otoparklist;
            comboBox_otoparkListesi.DisplayMember = "ad";
            comboBox_otoparkListesi.ValueMember = "otopark_no";
            MessageBox.Show(yeni_otopark.Kaydedildi());
            for (int i = 0; i < yeni_otopark.park_yeri_sayisi; i++)
            {
                ParkYeri park = new ParkYeri();
                park.Id = Guid.NewGuid();
                park.Doluluk = "boş";
                park.park_yeri_no = i + 1;
                park.otopark_no = yeni_otopark.otopark_no; ;
                parkYeriListesi.Add(park);
            }
        }
        private void comboBox_otoparkListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_otoparkListesi.SelectedValue != null)
            {
                var sonuc = parkYeriListesi.Where(i => i.otopark_no == comboBox_otoparkListesi.SelectedValue).ToList();

                comboBox_parkYeriListesi.DataSource = sonuc;
                comboBox_parkYeriListesi.DisplayMember = "park_yeri_no";
                comboBox_parkYeriListesi.ValueMember = "otopark_no";
            }
        }

        private void button_ucretGuncelle_Click(object sender, EventArgs e)
        {
            MevcutKullanici.saatlikUcret = int.Parse(textBox_Ucret.Text);
            MessageBox.Show("Saatlik ücret " + MevcutKullanici.saatlikUcret.ToString() + " TL olarak güncellendi");
        }


        private void button_musteriGor_Click(object sender, EventArgs e)
        {
            // Listedeki index'i bul
            int index = Admin_paneli.parkYeriListesi.FindIndex(i => i.otopark_no == comboBox_otoparkListesi.SelectedValue && i.park_yeri_no == comboBox_parkYeriListesi.SelectedIndex + 1);
            // Eğer nesne listede varsa, yerine yeni nesneyi kopyala
            var secilenParkYeri = Admin_paneli.parkYeriListesi[index];
            if (secilenParkYeri.kullanici != null)
            {
                MessageBox.Show("Şu an park yerindeki kişinin adı " + secilenParkYeri.kullanici);
            }

            else
            {
                MessageBox.Show("Park yeri boş");
            }
        }
    }
}
