namespace UÇAK_BİLET_REZARVASYON_PROJESİ
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(423, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UÇUŞ BİLGİLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(508, 126);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(429, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "YOLCU BİLGİLERİ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "NEREDEN :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "NEREYE:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1 Adana",
            "2 Adıyaman",
            "3 Afyonkarahisar ",
            "4 Ağrı",
            "5 Amasya ",
            "6 Ankara ",
            "7 Antalya ",
            "8 Artvin ",
            "9 Aydın",
            "10 Balıkesir ",
            "11 Bilecik ",
            "12 Bingöl ",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir ",
            "27 Gaziantep ",
            "28 Giresun ",
            "29 Gümüşhane ",
            "30 Hakkâri ",
            "31 Hatay ",
            "32 Isparta ",
            "33 Mersin ",
            "34 İstanbul ",
            "35 İzmir ",
            "36 Kars ",
            "37 Kastamonu ",
            "38 Kayseri ",
            "39 Kırklareli ",
            "40 Kırşehir",
            " 41 Kocaeli ",
            "42 Konya ",
            "43 Kütahya ",
            "44 Malatya ",
            "45 Manisa ",
            "46 Kahramanmaraş ",
            "47 Mardin ",
            "48 Muğla ",
            "49 Muş ",
            "50 Nevşehir",
            " 51 Niğde ",
            "52 Ordu ",
            "53 Rize ",
            "54 Sakarya ",
            "55 Samsun ",
            "56 Siirt",
            " 57 Sinop ",
            "58 Sivas ",
            "59 Tekirdağ ",
            "60 Tokat ",
            "61 Trabzon ",
            "62 Tunceli ",
            "63 Şanlıurfa ",
            "64 Uşak ",
            "65 Van ",
            "66 Yozgat ",
            "67 Zonguldak ",
            "68 Aksaray",
            " 69 Bayburt ",
            "70 Karaman ",
            "71 Kırıkkale ",
            "72 Batman ",
            "73 Şırnak ",
            "74 Bartın ",
            "75 Ardahan ",
            "76 Iğdır ",
            "77 Yalova ",
            "78 Karabük ",
            "79 Kilis ",
            "80 Osmaniye",
            "81 Düzce"});
            this.comboBox1.Location = new System.Drawing.Point(132, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(182, 30);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1 Adana",
            "2 Adıyaman",
            "3 Afyonkarahisar ",
            "4 Ağrı",
            "5 Amasya ",
            "6 Ankara ",
            "7 Antalya ",
            "8 Artvin ",
            "9 Aydın",
            "10 Balıkesir ",
            "11 Bilecik ",
            "12 Bingöl ",
            "13 Bitlis",
            "14 Bolu",
            "15 Burdur",
            "16 Bursa",
            "17 Çanakkale",
            "18 Çankırı",
            "19 Çorum",
            "20 Denizli",
            "21 Diyarbakır",
            "22 Edirne",
            "23 Elazığ",
            "24 Erzincan",
            "25 Erzurum",
            "26 Eskişehir ",
            "27 Gaziantep ",
            "28 Giresun ",
            "29 Gümüşhane ",
            "30 Hakkâri ",
            "31 Hatay ",
            "32 Isparta ",
            "33 Mersin ",
            "34 İstanbul ",
            "35 İzmir ",
            "36 Kars ",
            "37 Kastamonu ",
            "38 Kayseri ",
            "39 Kırklareli ",
            "40 Kırşehir",
            " 41 Kocaeli ",
            "42 Konya ",
            "43 Kütahya ",
            "44 Malatya ",
            "45 Manisa ",
            "46 Kahramanmaraş ",
            "47 Mardin ",
            "48 Muğla ",
            "49 Muş ",
            "50 Nevşehir",
            " 51 Niğde ",
            "52 Ordu ",
            "53 Rize ",
            "54 Sakarya ",
            "55 Samsun ",
            "56 Siirt",
            " 57 Sinop ",
            "58 Sivas ",
            "59 Tekirdağ ",
            "60 Tokat ",
            "61 Trabzon ",
            "62 Tunceli ",
            "63 Şanlıurfa ",
            "64 Uşak ",
            "65 Van ",
            "66 Yozgat ",
            "67 Zonguldak ",
            "68 Aksaray",
            " 69 Bayburt ",
            "70 Karaman ",
            "71 Kırıkkale ",
            "72 Batman ",
            "73 Şırnak ",
            "74 Bartın ",
            "75 Ardahan ",
            "76 Iğdır ",
            "77 Yalova ",
            "78 Karabük ",
            "79 Kilis ",
            "80 Osmaniye",
            "81 Düzce"});
            this.comboBox2.Location = new System.Drawing.Point(132, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(182, 30);
            this.comboBox2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "TARİH :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "AD-SOYAD:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(182, 28);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 22);
            this.label5.TabIndex = 2;
            this.label5.Text = "TCKİMLİK NUMARASI:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(192, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "TELEFON NUMARASI";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(227, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 28);
            this.textBox1.TabIndex = 3;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(227, 99);
            this.maskedTextBox1.Mask = "00000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(164, 28);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(227, 140);
            this.maskedTextBox2.Mask = "(999) 000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(164, 28);
            this.maskedTextBox2.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(252, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "KAYDET";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 22;
            this.listBox1.Location = new System.Drawing.Point(29, 379);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(908, 180);
            this.listBox1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(29, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 106);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Ravie", 16.2F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(214, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(447, 38);
            this.label7.TabIndex = 0;
            this.label7.Text = "POLAT HAVA YOLLARI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(683, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(196, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(323, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "değiştir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 619);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
    }
}

