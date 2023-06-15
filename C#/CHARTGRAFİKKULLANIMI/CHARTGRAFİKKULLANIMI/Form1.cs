using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CHARTGRAFİKKULLANIMI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {// SERİES ALANINA EKLENEN AD İLE BURDAKİ SERİES DAN SONRAKİ AD AYNI OLMALI BUNA DİKKAT ET
            chart1.Series["KİTAP"].Points.AddXY("ömer", 5);
            chart1.Series["KİTAP"].Points.AddXY("mehmet", 1);
            // SÜTÜNLARIN ŞKELİNE GÖRE DE POİNTS İN VERİ DALINA YANI BURDAKİ XY DEĞERİNE GÖRE FARKLILIK DA GÖSTEREBİLİR 
            //BAZI SÜTÜN GÖSTERMELERİ TEK DEĞER ALACAĞI GİBİ BUNADA DİKKAT ET
        }
    }
}
