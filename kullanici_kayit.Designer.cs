﻿namespace otopark
{
    partial class kullanici_kayit
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            textBox4 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Location = new Point(317, 257);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Kayıt";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 75);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 1;
            label1.Text = "Ad soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 122);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "Şifre";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(317, 75);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(317, 119);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(317, 163);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 170);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 5;
            label3.Text = "Plaka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(191, 301);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 7;
            label4.Text = "Hesabınız varsa";
            // 
            // button2
            // 
            button2.BackColor = Color.DarkOliveGreen;
            button2.Location = new Point(317, 292);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 8;
            button2.Text = "Giriş yap";
            button2.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(317, 216);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(191, 219);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "E-posta";
            // 
            // kullanici_kayit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "kullanici_kayit";
            Text = "Kallnıcı Kayıt";
            Load += kullanici_kayit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label3;
        private Label label4;
        private Button button2;
        private TextBox textBox4;
        private Label label5;
    }
}