using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diziler_uygulması
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double[] sayilar = { 5, 8, 7, -8, 22, 5, 7, 66, };

            foreach(int i in sayilar)
            {
                listBox1.Items.Add(i);
            }


        }
    }
}
