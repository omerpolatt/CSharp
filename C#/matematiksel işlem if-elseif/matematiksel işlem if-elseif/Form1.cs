using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace matematiksel_işlem_if_elseif
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float sayi1, sayi2, sonuc;
            sayi1=Convert.ToInt32(textBox1.Text);
            sayi2=Convert.ToInt32(textBox2.Text);

            if (radioButton1.Checked)
            {
                sonuc = sayi1 + sayi2;

            }
            else if (radioButton2.Checked)
            {
                sonuc = sayi2 - sayi1;  
            }
            else if (radioButton3.Checked)
            {
                sonuc= sayi1 * sayi2;
            }
            else
            {
                sonuc = sayi1 / sayi2;
            }
            label4.Text = sonuc.ToString();
        }
    }
}
