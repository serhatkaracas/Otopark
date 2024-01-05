namespace otopark
{
    partial class Kullanici_paneli
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
            button_kullanicicikis = new Button();
            KullaniciPanelButon1 = new Button();
            OtoparkKullanici_listBox = new ListBox();
            ParkYeriKullanici_listBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            button_parket = new Button();
            button_parktanCik = new Button();
            textBox_saat = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button_kullanicicikis
            // 
            button_kullanicicikis.BackColor = Color.FromArgb(255, 128, 128);
            button_kullanicicikis.Location = new Point(932, 175);
            button_kullanicicikis.Margin = new Padding(3, 4, 3, 4);
            button_kullanicicikis.Name = "button_kullanicicikis";
            button_kullanicicikis.Size = new Size(86, 31);
            button_kullanicicikis.TabIndex = 24;
            button_kullanicicikis.Text = "Çıkış";
            button_kullanicicikis.UseVisualStyleBackColor = false;
            button_kullanicicikis.Click += button_kullanicicikis_Click;
            // 
            // KullaniciPanelButon1
            // 
            KullaniciPanelButon1.BackColor = Color.FromArgb(128, 255, 128);
            KullaniciPanelButon1.Location = new Point(932, 100);
            KullaniciPanelButon1.Name = "KullaniciPanelButon1";
            KullaniciPanelButon1.Size = new Size(104, 36);
            KullaniciPanelButon1.TabIndex = 25;
            KullaniciPanelButon1.Text = "Profil";
            KullaniciPanelButon1.UseVisualStyleBackColor = false;
            // 
            // OtoparkKullanici_listBox
            // 
            OtoparkKullanici_listBox.FormattingEnabled = true;
            OtoparkKullanici_listBox.ItemHeight = 20;
            OtoparkKullanici_listBox.Location = new Point(90, 95);
            OtoparkKullanici_listBox.Name = "OtoparkKullanici_listBox";
            OtoparkKullanici_listBox.Size = new Size(150, 464);
            OtoparkKullanici_listBox.TabIndex = 26;
            OtoparkKullanici_listBox.SelectedIndexChanged += OtoparkKullanici_listBox_SelectedIndexChanged;
            // 
            // ParkYeriKullanici_listBox
            // 
            ParkYeriKullanici_listBox.FormattingEnabled = true;
            ParkYeriKullanici_listBox.ItemHeight = 20;
            ParkYeriKullanici_listBox.Location = new Point(305, 95);
            ParkYeriKullanici_listBox.Name = "ParkYeriKullanici_listBox";
            ParkYeriKullanici_listBox.Size = new Size(150, 464);
            ParkYeriKullanici_listBox.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.GreenYellow;
            label1.Location = new Point(90, 51);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 29;
            label1.Text = "Otoparklar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(128, 255, 128);
            label2.Location = new Point(305, 51);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 30;
            label2.Text = "Park Yerleri";
            // 
            // button_parket
            // 
            button_parket.BackColor = Color.Green;
            button_parket.Location = new Point(697, 319);
            button_parket.Name = "button_parket";
            button_parket.Size = new Size(125, 53);
            button_parket.TabIndex = 35;
            button_parket.Text = "Park et";
            button_parket.UseVisualStyleBackColor = false;
            button_parket.Click += button_parket_Click;
            // 
            // button_parktanCik
            // 
            button_parktanCik.BackColor = Color.FromArgb(192, 0, 0);
            button_parktanCik.ForeColor = SystemColors.ControlText;
            button_parktanCik.Location = new Point(697, 390);
            button_parktanCik.Name = "button_parktanCik";
            button_parktanCik.Size = new Size(125, 53);
            button_parktanCik.TabIndex = 37;
            button_parktanCik.Text = "Parktan çık";
            button_parktanCik.UseVisualStyleBackColor = false;
            button_parktanCik.Click += button_parktanCik_Click;
            // 
            // textBox_saat
            // 
            textBox_saat.AcceptsReturn = true;
            textBox_saat.BackColor = Color.FloralWhite;
            textBox_saat.Location = new Point(697, 266);
            textBox_saat.Name = "textBox_saat";
            textBox_saat.Size = new Size(125, 27);
            textBox_saat.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(255, 255, 128);
            label3.Location = new Point(539, 266);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 41;
            label3.Text = "Park edilecek saat";
            // 
            // Kullanici_paneli
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1112, 733);
            Controls.Add(label3);
            Controls.Add(textBox_saat);
            Controls.Add(button_parktanCik);
            Controls.Add(button_parket);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ParkYeriKullanici_listBox);
            Controls.Add(OtoparkKullanici_listBox);
            Controls.Add(KullaniciPanelButon1);
            Controls.Add(button_kullanicicikis);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Kullanici_paneli";
            Text = "Kulanıcı paneli";
            Load += Kullanici_paneli_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button_kullanicicikis;
        private Button KullaniciPanelButon1;
        private ListBox OtoparkKullanici_listBox;
        private ListBox ParkYeriKullanici_listBox;
        private Label label1;
        private Label label2;
        private Button button_parket;
        private Button button_parktanCik;
        private TextBox textBox1;
        private TextBox textBox_saat;
        private Label label3;
    }
}