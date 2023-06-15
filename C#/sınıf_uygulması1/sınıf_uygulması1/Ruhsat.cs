using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sınıf_uygulması1
{
    internal class Ruhsat
    {
        public string sahibi;
        private string markası;
        
        public string marka
        {
            get
            {
                return markası;
            }
            set
            {
                markası = value.ToUpper();
            }
        }
    }
}
