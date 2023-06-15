using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomKomutuUygulaması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            Random random= new Random();
            int sayi1, sayi2;
            sayi1 = random.Next(1,6);
            sayi2= random.Next(1,6);

            label1.Text = sayi1.ToString();
            label2.Text = sayi2.ToString();

            Random random2 = new Random();
            int sayi3, sayi4;
            sayi3 = random.Next(1, 6);
            sayi4 = random.Next(1, 6);

            label3.Text = sayi3.ToString();
            label4.Text = sayi4.ToString();

            if (label1.Text == label3.Text)
            {
                label3.BackColor = Color.Green;
                label1.BackColor = Color.Green;

            }
            else
            {
                label3.BackColor = Color.Red;
                label1.BackColor = Color.Red;
            }



            if (label2.Text == label4.Text)
            {
                label4.BackColor = Color.Green;
                label2.BackColor = Color.Green;

            }
            else
            {
              label4.BackColor = Color.Red;
                label2.BackColor = Color.Red;
            }




        }
    }
}
