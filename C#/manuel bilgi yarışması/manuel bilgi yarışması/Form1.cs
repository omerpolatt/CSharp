using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace manuel_bilgi_yarışması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogru_s = 0, yanlıs_s=0, soru_no = 0;

        private void btnB_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSONRAKİ.Enabled = true;


            label2.Text = btnB.Text;
            if (label1.Text == label2.Text)
            {
                dogru_s++;
                label5.Text = dogru_s.ToString();
                GREEN.Visible = true;
            }
            else
            {
                yanlıs_s++;
                label6.Text = yanlıs_s.ToString();
                RED.Visible = true;

            }




        }

        private void btnC_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSONRAKİ.Enabled = true;


            label2.Text = btnC.Text;
            if (label1.Text == label2.Text)
            {
                dogru_s++;
                label5.Text = dogru_s.ToString();
                GREEN.Visible = true;
            }
            else
            {
                yanlıs_s++;
                label6.Text = yanlıs_s.ToString();
                RED.Visible = true;

            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
            btnSONRAKİ.Enabled = true;


            label2.Text = btnD.Text;
            if (label1.Text == label2.Text)
            {
                dogru_s++;
                label5.Text = dogru_s.ToString();
                GREEN.Visible = true;
            }
            else
            {
                yanlıs_s++;
                label6.Text = yanlıs_s.ToString();
                RED.Visible = true;
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;   
            btnD.Enabled = false;
            btnSONRAKİ.Enabled = true;

            label2.Text = btnA.Text;
            if(label1.Text == label2.Text)
            {
                dogru_s++;
                label5.Text = dogru_s.ToString();
                GREEN.Visible = true;
            }
            else
            {
                yanlıs_s++;
                label6.Text = yanlıs_s.ToString();
                RED.Visible = true;

            }
        }

        private void btnSONRAKİ_Click(object sender, EventArgs e)
        {
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnSONRAKİ.Enabled = false;

            GREEN.Visible = false;
            RED.Visible = false;



            soru_no +=1 ; // ya da soru ++;
            label4.Text = soru_no.ToString();

            if (soru_no == 1 )
            {
                richTextBox1.Text = "CUMHURİYET KAÇ YILINDA KURULMUŞTUR?";
                btnA.Text = "1923";
                btnB.Text = "1925";
                btnC.Text = "1921";
                btnD.Text = "1920";
                label1.Text = "1923";
                
             
            }
            else if (soru_no == 2)
            {
                richTextBox1.Text = "HANGİ İL İÇ ANADOLU BÖLGESİNDE BULUNMAZ?";
                btnA.Text = "KAYSERİ";
                btnB.Text = "ADANA";
                btnC.Text = "KIRŞEHİR";
                btnD.Text = "ANKARA";
                label1.Text = "ADANA";
            }
            else if (soru_no==3)
            {
                richTextBox1.Text = "İSTİKLAL MARŞIMIZIN YAZARI KİMDİR?";
                btnA.Text = "ŞİNASİ";
                btnB.Text = "ADNAN MENDERES";
                btnC.Text = "NEŞET ERTAŞ";
                btnD.Text = "MEHMET AKİF ERSOY";
                label1.Text = "MEHMET AKİF ERSOY";
            }
            else if (soru_no == 4)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnSONRAKİ.Enabled = false;
                MessageBox.Show("DOĞRU SAYINIZ " +dogru_s +  " YANLIŞ SAYINIZ " + yanlıs_s);
            }
        }
    }
}
