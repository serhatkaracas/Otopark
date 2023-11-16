using Siniflar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otopark
{
    public partial class kullanici_kayit : Form
    {
        public static List<Kullanicilar> Kullanici_list = new List<Kullanicilar>();
        public kullanici_kayit()
        {
            InitializeComponent();
        }

        private void kullanici_kayit_Load(object sender, EventArgs e)
        {
        }
        public Siniflar.Kullanicilar yeni;

        private void Button_kayit_Click(object sender, EventArgs e)
        {
            Kullanicilar yeni = new Kullanicilar();
            yeni.ad = textBox_ad.Text;
            yeni.sifre = textBox_sifre.Text;
            yeni.plaka = textBox_Plaka.Text;
            yeni.e_posta = textBox_e_posta.Text;
            Kullanici_list.Add(yeni);

            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void Kaiyit_giris_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }

        private void textBox_Plaka_TextChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
