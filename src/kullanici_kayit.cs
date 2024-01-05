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
        public static List<Kullanici> Kullanici_list = new List<Kullanici>();
        public kullanici_kayit()
        {
            InitializeComponent();
        }

        private void kullanici_kayit_Load(object sender, EventArgs e)
        {
        }
        public Siniflar.Kullanici yeni;

        private void Button_kayit_Click(object sender, EventArgs e)
        {
            Kullanici yeniKullanici = new Kullanici();
            yeniKullanici.Id = Guid.NewGuid();
            yeniKullanici.Ad = textBox_ad.Text;
            yeniKullanici.Sifre = textBox_sifre.Text;
            yeniKullanici.Plaka = textBox_Plaka.Text;
            yeniKullanici.EPosta = textBox_e_posta.Text;
            Kullanici_list.Add(yeniKullanici);
            MessageBox.Show(yeniKullanici.Mesaj());
            MessageBox.Show(yeniKullanici.Id.ToString());
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
