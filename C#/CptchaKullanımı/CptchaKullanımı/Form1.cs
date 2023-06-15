using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CptchaKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] harf = { "a", "b", "c", "d", "e", "f", "g" };
            string[] sembol = { "+", "-", "*", "/", "#" };

            Random random= new Random();
            int s1, s2, s3;
            s1 = random.Next(harf.Length); // s1 ve s2 için burda dizi uzunluğu kadar bri random sayı ürettirdik
            s2 = random.Next(sembol.Length);//label daki yazıyı yazdırırken dizinin index numarasına göre eleman çektik 
            //index numarası da oluşturulan s1 ve s2 değerinden alındı 
            s3 = random.Next(1,11);

            label1.Text = harf[s1].ToString() + sembol[s2].ToString()+s3.ToString();

           



        }
    }
}
