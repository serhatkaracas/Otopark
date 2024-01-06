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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label4 = new Label();
            label10 = new Label();
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
            textBox_park_yeri_sayisi = new TextBox();
            label19 = new Label();
            label20 = new Label();
            textBox_otopark_no = new TextBox();
            label_ciro = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(199, 112);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 13;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 183);
            label2.Name = "label2";
            label2.Size = new Size(17, 20);
            label2.TabIndex = 14;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(199, 252);
            label3.Name = "label3";
            label3.Size = new Size(17, 20);
            label3.TabIndex = 16;
            label3.Text = "3";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(199, 381);
            label5.Name = "label5";
            label5.Size = new Size(17, 20);
            label5.TabIndex = 18;
            label5.Text = "5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(199, 315);
            label6.Name = "label6";
            label6.Size = new Size(17, 20);
            label6.TabIndex = 17;
            label6.Text = "4";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(199, 451);
            label7.Name = "label7";
            label7.Size = new Size(17, 20);
            label7.TabIndex = 19;
            label7.Text = "6";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 128);
            label4.Location = new Point(270, 65);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 20;
            label4.Text = "Müşteriler";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.FromArgb(255, 255, 128);
            label10.Location = new Point(175, 65);
            label10.Name = "label10";
            label10.Size = new Size(64, 20);
            label10.TabIndex = 29;
            label10.Text = "Park yeri";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.FromArgb(0, 192, 0);
            label11.Location = new Point(747, 196);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 37;
            label11.Text = "Ücret tarifesi";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.FromArgb(192, 255, 192);
            label15.Location = new Point(747, 245);
            label15.Name = "label15";
            label15.Size = new Size(53, 20);
            label15.TabIndex = 33;
            label15.Text = "Saatlik";
            // 
            // textBox_Ucret
            // 
            textBox_Ucret.Location = new Point(862, 241);
            textBox_Ucret.Margin = new Padding(3, 4, 3, 4);
            textBox_Ucret.Name = "textBox_Ucret";
            textBox_Ucret.Size = new Size(114, 27);
            textBox_Ucret.TabIndex = 30;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(1151, 112);
            listBox1.Margin = new Padding(3, 4, 3, 4);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(151, 244);
            listBox1.TabIndex = 38;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.FromArgb(255, 255, 128);
            label12.Location = new Point(1151, 61);
            label12.Name = "label12";
            label12.Size = new Size(99, 20);
            label12.TabIndex = 39;
            label12.Text = "Müşteri listesi";
            // 
            // button_ucretGuncelle
            // 
            button_ucretGuncelle.BackColor = Color.LightCoral;
            button_ucretGuncelle.Location = new Point(747, 291);
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
            button_cikisadmin.Location = new Point(175, 747);
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
            comboBox_otoparkListesi.Location = new Point(1274, 626);
            comboBox_otoparkListesi.Name = "comboBox_otoparkListesi";
            comboBox_otoparkListesi.Size = new Size(151, 28);
            comboBox_otoparkListesi.TabIndex = 44;
            comboBox_otoparkListesi.SelectedIndexChanged += comboBox_otoparkListesi_SelectedIndexChanged;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1142, 454);
            label16.Name = "label16";
            label16.Size = new Size(88, 20);
            label16.TabIndex = 46;
            label16.Text = "Otopark adı";
            // 
            // textBox_otopark_adi
            // 
            textBox_otopark_adi.Location = new Point(1271, 454);
            textBox_otopark_adi.Margin = new Padding(3, 4, 3, 4);
            textBox_otopark_adi.Name = "textBox_otopark_adi";
            textBox_otopark_adi.Size = new Size(114, 27);
            textBox_otopark_adi.TabIndex = 45;
            // 
            // comboBox_parkYeriListesi
            // 
            comboBox_parkYeriListesi.FormattingEnabled = true;
            comboBox_parkYeriListesi.Location = new Point(1274, 684);
            comboBox_parkYeriListesi.Name = "comboBox_parkYeriListesi";
            comboBox_parkYeriListesi.Size = new Size(151, 28);
            comboBox_parkYeriListesi.TabIndex = 47;
            comboBox_parkYeriListesi.SelectedIndexChanged += comboBox_parkYeriListesi_SelectedIndexChanged;
            // 
            // button_oparkEkle
            // 
            button_oparkEkle.BackColor = Color.LightCoral;
            button_oparkEkle.Location = new Point(1274, 563);
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
            label17.Location = new Point(1142, 634);
            label17.Name = "label17";
            label17.Size = new Size(104, 20);
            label17.TabIndex = 49;
            label17.Text = "Otopark listesi";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1149, 684);
            label18.Name = "label18";
            label18.Size = new Size(81, 20);
            label18.TabIndex = 50;
            label18.Text = "Park yerleri";
            // 
            // textBox_park_yeri_sayisi
            // 
            textBox_park_yeri_sayisi.Location = new Point(1271, 505);
            textBox_park_yeri_sayisi.Name = "textBox_park_yeri_sayisi";
            textBox_park_yeri_sayisi.Size = new Size(125, 27);
            textBox_park_yeri_sayisi.TabIndex = 51;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(1142, 512);
            label19.Name = "label19";
            label19.Size = new Size(103, 20);
            label19.TabIndex = 52;
            label19.Text = "Park yeri sayisi";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(1142, 412);
            label20.Name = "label20";
            label20.Size = new Size(84, 20);
            label20.TabIndex = 54;
            label20.Text = "Otopark no";
            // 
            // textBox_otopark_no
            // 
            textBox_otopark_no.Location = new Point(1271, 405);
            textBox_otopark_no.Margin = new Padding(3, 4, 3, 4);
            textBox_otopark_no.Name = "textBox_otopark_no";
            textBox_otopark_no.Size = new Size(114, 27);
            textBox_otopark_no.TabIndex = 53;
            // 
            // label_ciro
            // 
            label_ciro.AutoSize = true;
            label_ciro.BackColor = Color.FromArgb(128, 255, 255);
            label_ciro.Location = new Point(747, 370);
            label_ciro.Name = "label_ciro";
            label_ciro.Size = new Size(36, 20);
            label_ciro.TabIndex = 55;
            label_ciro.Text = "Ciro";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(270, 112);
            listBox2.Margin = new Padding(3, 4, 3, 4);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(134, 564);
            listBox2.TabIndex = 56;
            // 
            // Admin_paneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1795, 876);
            Controls.Add(listBox2);
            Controls.Add(label_ciro);
            Controls.Add(label20);
            Controls.Add(textBox_otopark_no);
            Controls.Add(label19);
            Controls.Add(textBox_park_yeri_sayisi);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(button_oparkEkle);
            Controls.Add(comboBox_parkYeriListesi);
            Controls.Add(label16);
            Controls.Add(textBox_otopark_adi);
            Controls.Add(comboBox_otoparkListesi);
            Controls.Add(button_cikisadmin);
            Controls.Add(button_ucretGuncelle);
            Controls.Add(label12);
            Controls.Add(listBox1);
            Controls.Add(label11);
            Controls.Add(label15);
            Controls.Add(textBox_Ucret);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Admin_paneli";
            Text = "Yönetici ekranı";
            Load += Admin_paneli_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label4;
        private Label label10;
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
        private TextBox textBox_park_yeri_sayisi;
        private Label label19;
        private Button button_oparkEkle;
        private Label label20;
        private TextBox textBox_otopark_no;
        private Label label_ciro;
        private ListBox listBox2;
    }
}