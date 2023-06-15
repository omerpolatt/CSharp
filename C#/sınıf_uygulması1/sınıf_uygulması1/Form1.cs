using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sınıf_uygulması1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba arabam1 = new Araba();

            arabam1.renk = "Siyah";
            arabam1.durum = 'S';
            arabam1.hız = 150;
            arabam1.fiyat = 250000;
            arabam1.motor = 3000;
            arabam1.uretım_yılı = 10;
            arabam1.marka = "toyota";
            arabam1.sahibi = "ömer faruk";



            label1.Text = arabam1.renk;
            label2.Text = arabam1.hız.ToString();
            label3.Text = arabam1.motor.ToString();
            label4.Text = arabam1.fiyat.ToString();
            label5.Text = arabam1.durum.ToString();
            label6.Text = arabam1.uretım_yılı.ToString();
            label7.Text = arabam1.marka;
            label8.Text = arabam1.sahibi;





        }

       
            
    }
}
