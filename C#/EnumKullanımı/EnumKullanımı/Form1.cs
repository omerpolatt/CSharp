using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnumKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        enum sehirler{ _,adana,ağrı,ankara,kayeri, }
        private void button1_Click(object sender, EventArgs e)
        {
            int plaka = Convert.ToInt32(textBox1.Text);
            sehirler kod;
            kod = (sehirler)plaka;
            label1.Text = kod.ToString();


        }
    }
}
