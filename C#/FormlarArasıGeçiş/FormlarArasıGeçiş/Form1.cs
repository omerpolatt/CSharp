using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormlarArasıGeçiş
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = 5.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            yeniform.Show(); //Sınıf mantığı var  burda da yeni açılan form da nesne oluşturup SHOW() komutu ile onu getirip 1.forumu 
            //kapatıyoruz (saklıyoruz) ama CLOSE komutu ile değil HİDE komutu ile 
            this.Hide();
            //CLOSE komutu form 1 i kapttığı için form 2 de otomatik kapnıypor
        }
    }
}
