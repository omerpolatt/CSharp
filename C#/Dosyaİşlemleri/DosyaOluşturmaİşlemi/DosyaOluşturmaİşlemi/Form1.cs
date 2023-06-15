using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DosyaOluşturmaİşlemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosya_yolu, dosya_adı;
        StreamWriter sw; // dosya oluşturmak için oluşturulan değşken 

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosya_yolu = folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosya_yolu;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dosya_adı = textBox2.Text;

            sw = File.CreateText(dosya_yolu + "\\" + dosya_adı + ".txt"); // dosyamızı bu methot ile oluşturduk 
            sw.Close();


        }


    }
}
