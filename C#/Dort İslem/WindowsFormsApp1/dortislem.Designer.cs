namespace WindowsFormsApp1
{
    partial class dortislem
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntoplama = new System.Windows.Forms.Button();
            this.btncikarma = new System.Windows.Forms.Button();
            this.btnbolme = new System.Windows.Forms.Button();
            this.btncarpma = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 95);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 31);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 144);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 31);
            this.textBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(158, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "SAYI 1 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI 2 :";
            // 
            // btntoplama
            // 
            this.btntoplama.Location = new System.Drawing.Point(431, 95);
            this.btntoplama.Name = "btntoplama";
            this.btntoplama.Size = new System.Drawing.Size(121, 31);
            this.btntoplama.TabIndex = 3;
            this.btntoplama.Text = "TOPLAMA";
            this.btntoplama.UseVisualStyleBackColor = true;
            this.btntoplama.Click += new System.EventHandler(this.btntoplama_Click);
            // 
            // btncikarma
            // 
            this.btncikarma.Location = new System.Drawing.Point(569, 95);
            this.btncikarma.Name = "btncikarma";
            this.btncikarma.Size = new System.Drawing.Size(121, 31);
            this.btncikarma.TabIndex = 4;
            this.btncikarma.Text = "ÇIKARMA";
            this.btncikarma.UseVisualStyleBackColor = true;
            this.btncikarma.Click += new System.EventHandler(this.btncikarma_Click);
            // 
            // btnbolme
            // 
            this.btnbolme.Location = new System.Drawing.Point(431, 143);
            this.btnbolme.Name = "btnbolme";
            this.btnbolme.Size = new System.Drawing.Size(121, 32);
            this.btnbolme.TabIndex = 5;
            this.btnbolme.Text = "BÖLME";
            this.btnbolme.UseVisualStyleBackColor = true;
            this.btnbolme.Click += new System.EventHandler(this.btnbolme_Click);
            // 
            // btncarpma
            // 
            this.btncarpma.Location = new System.Drawing.Point(569, 143);
            this.btncarpma.Name = "btncarpma";
            this.btncarpma.Size = new System.Drawing.Size(121, 32);
            this.btncarpma.TabIndex = 6;
            this.btncarpma.Text = "ÇARPMA";
            this.btncarpma.UseVisualStyleBackColor = true;
            this.btncarpma.Click += new System.EventHandler(this.btncarpma_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(363, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "SONUÇ :";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(489, 220);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(21, 24);
            this.lblsonuc.TabIndex = 3;
            this.lblsonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(772, 316);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncarpma);
            this.Controls.Add(this.btnbolme);
            this.Controls.Add(this.btncikarma);
            this.Controls.Add(this.btntoplama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntoplama;
        private System.Windows.Forms.Button btncikarma;
        private System.Windows.Forms.Button btnbolme;
        private System.Windows.Forms.Button btncarpma;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblsonuc;
    }
}

