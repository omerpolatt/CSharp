using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖĞrenci_sınav_notları_hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int  s1, s2, proje;
            double ortalama;

            ad = textBox1.Text; 
            soyad= textBox2.Text;
            
            
            s1 = Convert.ToInt32(maskedTextBox3.Text);
            s2= Convert.ToInt32(maskedTextBox2.Text);
            proje = Convert.ToInt32(maskedTextBox1.Text);

            ortalama = (s1 *0.4) + (s2 *  0.6) + (proje*0.5) ;

            listBox1.Items.Add(ad + soyad+"  öğrencimizin ortalaması  "+ortalama);









        }
    }
}
