using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menustrip_örneği2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //WEB BROWSER EKLEYİP ONUN İÇİNDE LİNK EKLEYEBİLİR YADA İNTERNETTE BU ŞEKİLDE GEZİNMEMİZİ SAĞLAR

        private void korkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.youtube.com/watch?v=CGoTOSdJsGw");
        }
    }
}
