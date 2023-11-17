using Siniflar;
using System;
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
            otoparklist.Add(yeni_otopark);
            comboBox_otoparkListesi.Items.Add(yeni_otopark.ad);
            comboBox_otoparkListesi.DisplayMember = "ad";
            comboBox_otoparkListesi.ValueMember = "ad";
            
            List<ParkYeri> parkYerleriListesi = new List<ParkYeri>();
            for (int i = 0; i < yeni_otopark.park_yeri_sayisi; i++)
            {
                ParkYeri park = new ParkYeri();
                park.doluluk = "boş";
                park.park_yeri_no = i+1;
                parkYerleriListesi.Add(park);
                comboBox_parkYeriListesi.Items.Add(park.park_yeri_no);
                comboBox_parkYeriListesi.DisplayMember = "doluluk";
                comboBox_parkYeriListesi.ValueMember = "doluluk";

            }

        }
    }
}
