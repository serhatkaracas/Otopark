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
    public partial class Admin_paneli : Form
    {
        public Admin_paneli()
        {
            InitializeComponent();
        }

        private void Admin_paneli_Load(object sender, EventArgs e)
        {

        }

        private void button_cikisadmin_Click(object sender, EventArgs e)
        {
            Giris giris = new Giris();
            giris.Show();
            this.Hide();
        }
    }
}
