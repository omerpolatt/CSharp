using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructoruygulması_2
{
    internal class Kimlik
    {   // sınıfımızı normal şekilde tanımladık
        private string ad;
        private string soyad;
        public int tc_no;
        public string memleket;
        public char cinsiyet;

        public string AD
        {
            get { return ad; }
            set { ad = value.ToLower(); }

        }
        public string SOYAD
        {
            get { return soyad; } 
            set { soyad = value.ToUpper(); }
        }

        
        //Constructor metodu oluşturup başlangıç için yada her nesnede aynı olacak değerleri girelim burda sınıf tanımındaki ilk isimlere göre tanımlarız
        public Kimlik()
        {
            ad = "";
            soyad = "";
            tc_no = 00000000000;
            memleket = "Kayseri";
            cinsiyet = 'E';

        }
               




    }
                
      
        

    
}
