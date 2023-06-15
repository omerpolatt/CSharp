namespace Menustrip_kullanımı
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rENKLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aÇIKMAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lACİVERTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kIRMIZIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sAYILARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hAKKIMIZDAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aNAMENÜToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çIKIŞToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rENKLERToolStripMenuItem,
            this.sAYILARToolStripMenuItem,
            this.hAKKIMIZDAToolStripMenuItem,
            this.çIKIŞToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rENKLERToolStripMenuItem
            // 
            this.rENKLERToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAVİToolStripMenuItem,
            this.kIRMIZIToolStripMenuItem,
            this.sARIToolStripMenuItem});
            this.rENKLERToolStripMenuItem.Name = "rENKLERToolStripMenuItem";
            this.rENKLERToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.rENKLERToolStripMenuItem.Text = "RENKLER";
            // 
            // mAVİToolStripMenuItem
            // 
            this.mAVİToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aÇIKMAVİToolStripMenuItem,
            this.lACİVERTToolStripMenuItem});
            this.mAVİToolStripMenuItem.Name = "mAVİToolStripMenuItem";
            this.mAVİToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.mAVİToolStripMenuItem.Text = "MAVİ";
            // 
            // aÇIKMAVİToolStripMenuItem
            // 
            this.aÇIKMAVİToolStripMenuItem.Name = "aÇIKMAVİToolStripMenuItem";
            this.aÇIKMAVİToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.aÇIKMAVİToolStripMenuItem.Text = "TURKUAZ";
            // 
            // lACİVERTToolStripMenuItem
            // 
            this.lACİVERTToolStripMenuItem.Name = "lACİVERTToolStripMenuItem";
            this.lACİVERTToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.lACİVERTToolStripMenuItem.Text = "LACİVERT";
            // 
            // kIRMIZIToolStripMenuItem
            // 
            this.kIRMIZIToolStripMenuItem.Name = "kIRMIZIToolStripMenuItem";
            this.kIRMIZIToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.kIRMIZIToolStripMenuItem.Text = "KIRMIZI";
            this.kIRMIZIToolStripMenuItem.Click += new System.EventHandler(this.kIRMIZIToolStripMenuItem_Click);
            // 
            // sARIToolStripMenuItem
            // 
            this.sARIToolStripMenuItem.Name = "sARIToolStripMenuItem";
            this.sARIToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.sARIToolStripMenuItem.Text = "SARI";
            this.sARIToolStripMenuItem.Click += new System.EventHandler(this.sARIToolStripMenuItem_Click);
            // 
            // sAYILARToolStripMenuItem
            // 
            this.sAYILARToolStripMenuItem.Name = "sAYILARToolStripMenuItem";
            this.sAYILARToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.sAYILARToolStripMenuItem.Text = "SAYILAR";
            this.sAYILARToolStripMenuItem.Click += new System.EventHandler(this.sAYILARToolStripMenuItem_Click);
            // 
            // hAKKIMIZDAToolStripMenuItem
            // 
            this.hAKKIMIZDAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aNAMENÜToolStripMenuItem});
            this.hAKKIMIZDAToolStripMenuItem.Name = "hAKKIMIZDAToolStripMenuItem";
            this.hAKKIMIZDAToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.hAKKIMIZDAToolStripMenuItem.Text = "HAKKIMIZDA";
            // 
            // aNAMENÜToolStripMenuItem
            // 
            this.aNAMENÜToolStripMenuItem.Name = "aNAMENÜToolStripMenuItem";
            this.aNAMENÜToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.aNAMENÜToolStripMenuItem.Text = "ANAMENÜ";
            this.aNAMENÜToolStripMenuItem.Click += new System.EventHandler(this.aNAMENÜToolStripMenuItem_Click);
            // 
            // çIKIŞToolStripMenuItem
            // 
            this.çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            this.çIKIŞToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            this.çIKIŞToolStripMenuItem.Click += new System.EventHandler(this.çIKIŞToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rENKLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mAVİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aÇIKMAVİToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lACİVERTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kIRMIZIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sARIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sAYILARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hAKKIMIZDAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aNAMENÜToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çIKIŞToolStripMenuItem;
    }
}

