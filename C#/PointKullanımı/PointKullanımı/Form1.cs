using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointKullanımı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point konum = new Point(); // POİNT Sınıfından konum adlı nesne oluşturduk ve bunu X ve Y değerlerine göre atama yaptık

            konum.X = 500;//atama konumları
            konum.Y = 500;

            button2.Location = konum; //nesnemizin konumunun oluşturduğumuz point nesnesine göre adlandırıyoruz çünkü x ve y yi o nesne üzerimnden tanımladık
            button2.BackColor= Color.Red;




            
        }
    }
}
