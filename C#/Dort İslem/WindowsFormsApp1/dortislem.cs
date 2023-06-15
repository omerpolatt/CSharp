using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class dortislem : Form
    {
        public dortislem()
        {
            InitializeComponent();
        }

        private void btntoplama_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double toplam;
            toplam = sayi1 + sayi2;

            lblsonuc.Text = toplam.ToString();

            
            
            
        }

        private void btncikarma_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double kalan;
            kalan = sayi1 - sayi2;

            lblsonuc.Text = kalan.ToString();
        }

        private void btnbolme_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double bolum;
            bolum = sayi1 / sayi2;

            lblsonuc.Text = bolum.ToString();

        }

        private void btncarpma_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(textBox1.Text);
            double sayi2 = Convert.ToDouble(textBox2.Text);
            double carpim;
            carpim = sayi1 * sayi2;

            lblsonuc.Text = carpim.ToString();
        }
    }
}
