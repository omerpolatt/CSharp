using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_uygulması1
{
    internal class Araba :  Ruhsat
    {
        public string renk;
        public int hız;
        public double motor;
        public char durum;
        public int fiyat;
        private int olusum_yılı;


        public int uretım_yılı
        {
            get { return olusum_yılı; }


            set { 
                if (value < 2000)
                {
                    olusum_yılı = 0;
                }
                else
                {
                    olusum_yılı = value;
                }
                
                
                }

        }


    }
}
