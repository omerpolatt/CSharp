using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgressBar_kullanım_örneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   if (progressBar1.Value < 100) { 
            progressBar1.Value += 10;
            }
            else
            {
                MessageBox.Show("100 den büyükk değerler için yükleme yoktur");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           if (progressBar1.Value > 0)
            {
                progressBar1.Value -= 10;
            }
            else
            {
                MessageBox.Show("0 dan küçük değerler için yükleme yoktur");
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value= 0;  
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.BackColor = Color.Blue;
        }
    }
}
