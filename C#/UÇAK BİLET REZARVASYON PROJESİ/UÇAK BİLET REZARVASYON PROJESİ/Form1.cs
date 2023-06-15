using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UÇAK_BİLET_REZARVASYON_PROJESİ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("ROTANIZ  : "+comboBox1.Text + " ----> " + comboBox2.Text +  "  Tarih  : "+dateTimePicker1.Text +
                "  ADNIZ SOYADINIZ  : " + textBox1.Text + "  TC KİMLİK NUMARANIZ  : "+ maskedTextBox1.Text+"  TELEFON NUMARANIZ  :"+maskedTextBox2.Text);

            MessageBox.Show("..KAYDINIZ BAŞARI İLE GERÇEKLEŞMİŞTİR..");
        }

        private void button2_Click(object sender, EventArgs e)
        { // değitir butonuna basınca iki şehir yer değiştirecek 
            label8.Text = comboBox2.Text;
            comboBox2.Text = comboBox1.Text; 
            comboBox1.Text = label8.Text;
            // label 8 i ekranda gözükmemesi için Özelliklerinden VİSİBLE özwlliğini False yaptık

        }
    }
}
