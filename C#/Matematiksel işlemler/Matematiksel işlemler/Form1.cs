using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matematiksel_işlemler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, fark, bolme, çarpma, mod_alma;

            sayi1 = Convert.ToInt32(maskedTextBox1.Text);
            sayi2 = Convert.ToInt32(maskedTextBox2.Text);

            toplam = sayi1 + sayi2;
            fark = sayi1 - sayi2  ;
            bolme = sayi1 / sayi2;
            çarpma = sayi1 * sayi2;
            mod_alma = sayi1 % sayi2;

            listBox1.Items.Add("TOPLAM SONUCU =  " + toplam + "\n  ÇIKARMA SONUCU =  " + fark + "\n BÖLME SONUCUNUZ  =" + bolme + " \nÇARPMA SONUCUNUZ  =" + çarpma + "\nMOD SONUCUNUZ" + mod_alma);
            // listbox un yanandoğru kayması için özelliklerinden horizontalScrollbar özelliğini True Yaptık
            MessageBox.Show("İŞELMLER YAPILMIŞTIR");
        }
    }
}
