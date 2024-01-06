namespace otopark
{
    partial class Admin_paneli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label11 = new Label();
            label15 = new Label();
            textBox_Ucret = new TextBox();
            listBox1 = new ListBox();
            label12 = new Label();
            button_ucretGuncelle = new Button();
            button_cikisadmin = new Button();
            comboBox_otoparkListesi = new ComboBox();
            label16 = new Label();
            textBox_otopark_adi = new TextBox();
            comboBox_parkYeriListesi = new ComboBox();
            button_oparkEkle = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            textBox_otopark_no = new TextBox();
            label_ciro = new Label();
            label1 = new Label();
            textBox_park_yeri_sayisi = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button_musteriGor = new Button();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 192, 0);
            label11.Location = new Point(30, 57);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 37;
            label11.Text = "Ücret tarifesi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(192, 255, 192);
            label15.Location = new Point(30, 106);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 33;
            label15.Text = "Saatlik";
            // 
            // textBox_Ucret
            // 
            textBox_Ucret.Location = new Point(145, 102);
            textBox_Ucret.Margin = new Padding(3, 4, 3, 4);
            textBox_Ucret.Name = "textBox_Ucret";
            textBox_Ucret.Size = new Size(114, 27);
            textBox_Ucret.TabIndex = 30;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(36, 74);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(147, 244);
            listBox1.TabIndex = 38;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 255, 128);
            label12.Location = new Point(36, 23);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 39;
            label12.Text = "Müşteri listesi";
            // 
            // button_ucretGuncelle
            // 
            button_ucretGuncelle.BackColor = Color.LightCoral;
            button_ucretGuncelle.Location = new Point(30, 152);
            button_ucretGuncelle.Margin = new Padding(3, 4, 3, 4);
            button_ucretGuncelle.Name = "button_ucretGuncelle";
            button_ucretGuncelle.Size = new Size(229, 31);
            button_ucretGuncelle.TabIndex = 41;
            button_ucretGuncelle.Text = "Ücreti güncelle";
            button_ucretGuncelle.UseVisualStyleBackColor = false;
            button_ucretGuncelle.Click += button_ucretGuncelle_Click;
            // 
            // button_cikisadmin
            // 
            button_cikisadmin.BackColor = Color.Red;
            button_cikisadmin.Location = new Point(688, 757);
            button_cikisadmin.Margin = new Padding(3, 4, 3, 4);
            button_cikisadmin.Name = "button_cikisadmin";
            button_cikisadmin.Size = new Size(114, 31);
            button_cikisadmin.TabIndex = 42;
            button_cikisadmin.Text = "Çıkış";
            button_cikisadmin.UseVisualStyleBackColor = false;
            button_cikisadmin.Click += button_cikisadmin_Click;
            // 
            // comboBox_otoparkListesi
            // 
            comboBox_otoparkListesi.FormattingEnabled = true;
            comboBox_otoparkListesi.Location = new Point(145, 89);
            comboBox_otoparkListesi.Name = "comboBox_otoparkListesi";
            comboBox_otoparkListesi.Size = new Size(151, 28);
            comboBox_otoparkListesi.TabIndex = 44;
            comboBox_otoparkListesi.SelectedIndexChanged += comboBox_otoparkListesi_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.BackColor = Color.FromArgb(192, 255, 255);
            label16.Location = new Point(47, 68);
            label16.Name = "label16";
            label16.Size = new Size(88, 20);
            label16.TabIndex = 46;
            label16.Text = "Otopark adı";
            // 
            // textBox_otopark_adi
            // 
            textBox_otopark_adi.Location = new Point(176, 65);
            textBox_otopark_adi.Margin = new Padding(3, 4, 3, 4);
            textBox_otopark_adi.Name = "textBox_otopark_adi";
            textBox_otopark_adi.Size = new Size(114, 27);
            textBox_otopark_adi.TabIndex = 45;
            // 
            // comboBox_parkYeriListesi
            // 
            comboBox_parkYeriListesi.FormattingEnabled = true;
            comboBox_parkYeriListesi.Location = new Point(145, 147);
            comboBox_parkYeriListesi.Name = "comboBox_parkYeriListesi";
            comboBox_parkYeriListesi.Size = new Size(151, 28);
            comboBox_parkYeriListesi.TabIndex = 47;
            // 
            // button_oparkEkle
            // 
            button_oparkEkle.BackColor = Color.LightCoral;
            button_oparkEkle.Location = new Point(179, 174);
            button_oparkEkle.Margin = new Padding(3, 4, 3, 4);
            button_oparkEkle.Name = "button_oparkEkle";
            button_oparkEkle.Size = new Size(114, 31);
            button_oparkEkle.TabIndex = 48;
            button_oparkEkle.Text = "Otopark ekle";
            button_oparkEkle.UseVisualStyleBackColor = false;
            button_oparkEkle.Click += button_oparkEkle_Click;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.FromArgb(192, 255, 255);
            label17.Location = new Point(13, 97);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 49;
            label17.Text = "Otopark listesi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.FromArgb(192, 255, 255);
            label18.Location = new Point(13, 147);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 50;
            label18.Text = "Park yerleri";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.FromArgb(192, 255, 255);
            label19.Location = new Point(47, 123);
            label19.Name = "label19";
            label19.Size = new Size(103, 20);
            label19.TabIndex = 52;
            label19.Text = "Park yeri sayisi";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.BackColor = Color.FromArgb(192, 255, 255);
            label20.Location = new Point(47, 23);
            label20.Name = "label20";
            label20.Size = new Size(84, 20);
            label20.TabIndex = 54;
            label20.Text = "Otopark no";
            // 
            // textBox_otopark_no
            // 
            textBox_otopark_no.Location = new Point(176, 16);
            textBox_otopark_no.Margin = new Padding(3, 4, 3, 4);
            textBox_otopark_no.Name = "textBox_otopark_no";
            textBox_otopark_no.Size = new Size(114, 27);
            textBox_otopark_no.TabIndex = 53;
            // 
            // label_ciro
            // 
            label_ciro.AutoSize = true;
            label_ciro.BackColor = Color.FromArgb(128, 255, 128);
            label_ciro.Location = new Point(30, 217);
            label_ciro.Name = "label_ciro";
            label_ciro.Size = new Size(36, 20);
            label_ciro.TabIndex = 55;
            label_ciro.Text = "Ciro";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(13, 23);
            label1.Name = "label1";
            label1.Size = new Size(342, 20);
            label1.TabIndex = 56;
            label1.Text = "Park yerindeki müşteriyi görmek için seçim yapınız.";
            // 
            // textBox_park_yeri_sayisi
            // 
            textBox_park_yeri_sayisi.Location = new Point(176, 116);
            textBox_park_yeri_sayisi.Name = "textBox_park_yeri_sayisi";
            textBox_park_yeri_sayisi.Size = new Size(114, 27);
            textBox_park_yeri_sayisi.TabIndex = 51;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(192, 192, 255);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(textBox_Ucret);
            groupBox1.Controls.Add(label_ciro);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(button_ucretGuncelle);
            groupBox1.Location = new Point(436, 54);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 348);
            groupBox1.TabIndex = 57;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(192, 192, 255);
            groupBox2.Controls.Add(button_musteriGor);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(comboBox_otoparkListesi);
            groupBox2.Controls.Add(comboBox_parkYeriListesi);
            groupBox2.Controls.Add(label17);
            groupBox2.Controls.Add(label18);
            groupBox2.Location = new Point(436, 443);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(366, 244);
            groupBox2.TabIndex = 58;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // button_musteriGor
            // 
            button_musteriGor.BackColor = Color.FromArgb(192, 255, 192);
            button_musteriGor.Location = new Point(13, 193);
            button_musteriGor.Name = "button_musteriGor";
            button_musteriGor.Size = new Size(283, 29);
            button_musteriGor.TabIndex = 57;
            button_musteriGor.Text = "Park eden müşterileri gör";
            button_musteriGor.UseVisualStyleBackColor = false;
            button_musteriGor.Click += button_musteriGor_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.FromArgb(192, 192, 255);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(textBox_otopark_adi);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(button_oparkEkle);
            groupBox3.Controls.Add(textBox_otopark_no);
            groupBox3.Controls.Add(textBox_park_yeri_sayisi);
            groupBox3.Controls.Add(label19);
            groupBox3.Location = new Point(27, 443);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(356, 244);
            groupBox3.TabIndex = 59;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.FromArgb(192, 192, 255);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(listBox1);
            groupBox4.Location = new Point(32, 54);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(351, 348);
            groupBox4.TabIndex = 60;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // Admin_paneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(841, 876);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button_cikisadmin);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_paneli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yönetici ekranı";
            Load += Admin_paneli_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label label11;
        private Label label15;
        private TextBox textBox_Ucret;
        private ListBox listBox1;
        private Label label12;
        private Button button_ucretGuncelle;
        private Button button_cikisadmin;
        private ComboBox comboBox_otoparkListesi;
        private Label label16;
        private TextBox textBox_otopark_adi;
        private ComboBox comboBox_parkYeriListesi;
        private Button buttonot_oparkEkle;
        private Label label17;
        private Label label18;
        private Label label19;
        private Button button_oparkEkle;
        private Label label20;
        private TextBox textBox_otopark_no;
        private Label label_ciro;
        private Label label1;
        private TextBox textBox_park_yeri_sayisi;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Button button_musteriGor;
    }
}