namespace otopark
{
    partial class Giris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            text_ad_giris = new TextBox();
            button_sifremiunuttum = new Button();
            button_giris = new Button();
            text_sifre_giris = new TextBox();
            button_Hesapolustur = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 74);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // text_ad_giris
            // 
            text_ad_giris.Location = new Point(181, 32);
            text_ad_giris.Margin = new Padding(3, 2, 3, 2);
            text_ad_giris.Name = "text_ad_giris";
            text_ad_giris.Size = new Size(110, 23);
            text_ad_giris.TabIndex = 2;
            // 
            // button_sifremiunuttum
            // 
            button_sifremiunuttum.Location = new Point(94, 108);
            button_sifremiunuttum.Margin = new Padding(3, 2, 3, 2);
            button_sifremiunuttum.Name = "button_sifremiunuttum";
            button_sifremiunuttum.Size = new Size(109, 22);
            button_sifremiunuttum.TabIndex = 3;
            button_sifremiunuttum.Text = "Şifremi unuttum";
            button_sifremiunuttum.UseVisualStyleBackColor = true;
            button_sifremiunuttum.Click += button_sifremiunuttum_Click;
            // 
            // button_giris
            // 
            button_giris.BackColor = Color.FromArgb(0, 192, 0);
            button_giris.ForeColor = Color.Black;
            button_giris.Location = new Point(208, 108);
            button_giris.Margin = new Padding(3, 2, 3, 2);
            button_giris.Name = "button_giris";
            button_giris.Size = new Size(82, 22);
            button_giris.TabIndex = 4;
            button_giris.Text = "Giriş";
            button_giris.UseVisualStyleBackColor = false;
            button_giris.Click += button2_Click;
            // 
            // text_sifre_giris
            // 
            text_sifre_giris.AcceptsTab = true;
            text_sifre_giris.Location = new Point(181, 72);
            text_sifre_giris.Margin = new Padding(3, 2, 3, 2);
            text_sifre_giris.Name = "text_sifre_giris";
            text_sifre_giris.Size = new Size(110, 23);
            text_sifre_giris.TabIndex = 5;
            text_sifre_giris.UseSystemPasswordChar = true;
            // 
            // button_Hesapolustur
            // 
            button_Hesapolustur.Location = new Point(181, 147);
            button_Hesapolustur.Margin = new Padding(3, 2, 3, 2);
            button_Hesapolustur.Name = "button_Hesapolustur";
            button_Hesapolustur.Size = new Size(108, 22);
            button_Hesapolustur.TabIndex = 6;
            button_Hesapolustur.Text = "Hesap oluştur";
            button_Hesapolustur.UseVisualStyleBackColor = true;
            button_Hesapolustur.Click += button_Hesapolustur_Click;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(405, 250);
            Controls.Add(button_Hesapolustur);
            Controls.Add(text_sifre_giris);
            Controls.Add(button_giris);
            Controls.Add(button_sifremiunuttum);
            Controls.Add(text_ad_giris);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Giris";
            Text = "Giriş ekranı";
            Load += Giris_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox text_ad_giris;
        private Button button_sifremiunuttum;
        private Button button_giris;
        private TextBox text_sifre_giris;
        private Button button_Hesapolustur;
    }
}