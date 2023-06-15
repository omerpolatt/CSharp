using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menustrip_kullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sAYILARToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kIRMIZIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;

        }

        private void sARIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void aNAMENÜToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("anamenü yerine geldiniz","anamenü",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        private void çIKIŞToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("ÇIKIŞ YAPIYORSUNUZ","ÇIKIŞ",MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                //this.Close();  //bunlardan herhangi birini kullanabilriz..
                Application.Exit();
            }
            else
            {
                
            }
           
        }
    }
}
