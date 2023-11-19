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
            InitializeComponent();
        }
        static public List<Otopark> otoparklist = new List<Otopark>();
        static public List<ParkYeri> parkYeriListesi = new List<ParkYeri>();
        private void Admin_paneli_Load(object sender, EventArgs e)
        {
            foreach (var eleman in kullanici_kayit.Kullanici_list)
            {
                listBox1.Items.Add(eleman.ad);
            }
        }

        private void button_cikisadmin_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox_musteriler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public Siniflar.Otopark yeni_otopark;
        private void button_oparkEkle_Click(object sender, EventArgs e)
        {
            Otopark yeni_otopark = new Otopark();
            yeni_otopark.ad = textBox_otopark_adi.Text;
            yeni_otopark.park_yeri_sayisi = int.Parse(textBox_park_yeri_sayisi.Text);
            yeni_otopark.otopark_no = int.Parse(textBox_otopark_no.Text);

            otoparklist.Add(yeni_otopark); // Listeye yeni otopark ekleyin
            comboBox_otoparkListesi.DataSource = null; // ComboBox'ın DataSource'unu temizleyin
            comboBox_otoparkListesi.DataSource = otoparklist; // Listeyi yeniden ata
            comboBox_otoparkListesi.DisplayMember = "ad"; // Gösterilecek metni belirleyin
            comboBox_otoparkListesi.ValueMember = "otopark_no"; // Arka plandaki değeri belirleyin

            for (int i = 0; i < yeni_otopark.park_yeri_sayisi; i++)
            {
                ParkYeri park = new ParkYeri();
                park.doluluk = "boş";
                park.park_yeri_no = i + 1;
                park.otopark_no = yeni_otopark.otopark_no; ;
                parkYeriListesi.Add(park);
            }
        }

        private void comboBox_otoparkListesi_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_otoparkListesi.SelectedValue != null)
            {
                
                var sonuc = parkYeriListesi.Where(p => p.otopark_no == (int)comboBox_otoparkListesi.SelectedValue).ToList();
               
                comboBox_parkYeriListesi.DataSource = sonuc;
                comboBox_parkYeriListesi.DisplayMember = "park_yeri_no";
                comboBox_parkYeriListesi.ValueMember = "otopark_no";
            }
        }
    }
}
