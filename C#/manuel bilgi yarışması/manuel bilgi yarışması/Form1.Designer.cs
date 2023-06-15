namespace manuel_bilgi_yarışması
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnA = new System.Windows.Forms.Button();
            this.btnB = new System.Windows.Forms.Button();
            this.btnD = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.labelsoru = new System.Windows.Forms.Label();
            this.labeld = new System.Windows.Forms.Label();
            this.labely = new System.Windows.Forms.Label();
            this.btnSONRAKİ = new System.Windows.Forms.Button();
            this.GREEN = new System.Windows.Forms.PictureBox();
            this.RED = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GREEN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(674, 266);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnA
            // 
            this.btnA.Location = new System.Drawing.Point(12, 299);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(329, 50);
            this.btnA.TabIndex = 1;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnB
            // 
            this.btnB.Location = new System.Drawing.Point(389, 299);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(297, 50);
            this.btnB.TabIndex = 2;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.Location = new System.Drawing.Point(389, 375);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(297, 42);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnC
            // 
            this.btnC.Location = new System.Drawing.Point(12, 375);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(329, 42);
            this.btnC.TabIndex = 4;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // labelsoru
            // 
            this.labelsoru.AutoSize = true;
            this.labelsoru.Location = new System.Drawing.Point(706, 32);
            this.labelsoru.Name = "labelsoru";
            this.labelsoru.Size = new System.Drawing.Size(87, 18);
            this.labelsoru.TabIndex = 5;
            this.labelsoru.Text = "SORU NO :";
            // 
            // labeld
            // 
            this.labeld.AutoSize = true;
            this.labeld.Location = new System.Drawing.Point(720, 72);
            this.labeld.Name = "labeld";
            this.labeld.Size = new System.Drawing.Size(73, 18);
            this.labeld.TabIndex = 5;
            this.labeld.Text = "DOĞRU :";
            // 
            // labely
            // 
            this.labely.AutoSize = true;
            this.labely.Location = new System.Drawing.Point(727, 112);
            this.labely.Name = "labely";
            this.labely.Size = new System.Drawing.Size(66, 18);
            this.labely.TabIndex = 5;
            this.labely.Text = "YANLIŞ :";
            // 
            // btnSONRAKİ
            // 
            this.btnSONRAKİ.Location = new System.Drawing.Point(730, 149);
            this.btnSONRAKİ.Name = "btnSONRAKİ";
            this.btnSONRAKİ.Size = new System.Drawing.Size(131, 45);
            this.btnSONRAKİ.TabIndex = 6;
            this.btnSONRAKİ.Text = "SONRAKİ";
            this.btnSONRAKİ.UseVisualStyleBackColor = true;
            this.btnSONRAKİ.Click += new System.EventHandler(this.btnSONRAKİ_Click);
            // 
            // GREEN
            // 
            this.GREEN.Image = ((System.Drawing.Image)(resources.GetObject("GREEN.Image")));
            this.GREEN.Location = new System.Drawing.Point(730, 216);
            this.GREEN.Name = "GREEN";
            this.GREEN.Size = new System.Drawing.Size(131, 94);
            this.GREEN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GREEN.TabIndex = 7;
            this.GREEN.TabStop = false;
            this.GREEN.Visible = false;
            // 
            // RED
            // 
            this.RED.Image = ((System.Drawing.Image)(resources.GetObject("RED.Image")));
            this.RED.Location = new System.Drawing.Point(730, 330);
            this.RED.Name = "RED";
            this.RED.Size = new System.Drawing.Size(131, 87);
            this.RED.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RED.TabIndex = 7;
            this.RED.TabStop = false;
            this.RED.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 429);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "label1";
            this.label2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(813, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(815, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(815, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 456);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RED);
            this.Controls.Add(this.GREEN);
            this.Controls.Add(this.btnSONRAKİ);
            this.Controls.Add(this.labely);
            this.Controls.Add(this.labeld);
            this.Controls.Add(this.labelsoru);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.richTextBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.GREEN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RED)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Label labelsoru;
        private System.Windows.Forms.Label labeld;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Button btnSONRAKİ;
        private System.Windows.Forms.PictureBox GREEN;
        private System.Windows.Forms.PictureBox RED;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

