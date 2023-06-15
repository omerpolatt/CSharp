using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatematikFonksiyonları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sayı = Convert.ToDouble(textBox1.Text);
            //label3.Text = Math.Abs(sayı).ToString(); //MUTLAK DEĞER FONKSİYONU
            //label3.Text = Math.Pow(sayı,2).ToString(); // üs alma fonksiyonu
            //label3.Text = Math.Sqrt(sayı).ToString();// karakök alma fonksiyonu
        }
    }
}
