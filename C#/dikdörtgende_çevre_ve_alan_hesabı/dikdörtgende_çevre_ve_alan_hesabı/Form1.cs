using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dikdörtgende_çevre_ve_alan_hesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cevre(int kenar_1,int kenar_2)
        {
            int cevre = kenar_1 * 2 + kenar_2 * 2;
            return cevre;
        }

        int alan(int kenar_1, int kenar_2)
        {
            int alan = kenar_1 * kenar_2;
            return alan;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int deger1 = Convert.ToInt32(textBox1.Text);
            int deger2 = Convert.ToInt32(textBox2.Text);
            label3.Text =cevre(deger1,deger2).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int deger3 = Convert.ToInt32(textBox1.Text);
            int deger4 = Convert.ToInt32(textBox2.Text);
            label4.Text = alan(deger3, deger4).ToString();
        }
    }
}
