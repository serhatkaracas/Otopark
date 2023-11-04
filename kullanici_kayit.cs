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

        private void Button_kayit_Click(object sender, EventArgs e)
        {
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
    }
}
