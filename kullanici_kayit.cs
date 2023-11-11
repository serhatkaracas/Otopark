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
        public kullanici_kayit()
        {
            InitializeComponent();
        }


        private void kullanici_kayit_Load(object sender, EventArgs e)
        {

        }
        private Siniflar.Kullanicilar yeni;

        private void Button_kayit_Click(object sender, EventArgs e)
        {
            yeni = new Siniflar.Kullanicilar(textBox_ad.Text, textBox_sifre.Text,textBox_Plaka.Text, textBox_e_posta.Text );
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

        private void textBox_Plaka_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
