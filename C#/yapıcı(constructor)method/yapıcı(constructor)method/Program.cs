using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yapıcı_constructor_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ogrenci ilk= new Ogrenci();
            //Console.WriteLine(ilk.ad);
            // Console.WriteLine(ilk.sehir);
            //Console.WriteLine(ilk.yası);
            //Console.WriteLine(ilk.numara);



            //Ogrenci ilk= new Ogrenci();
            // Console.ReadKey();


            Ogrenci ilk= new Ogrenci("Parametre li olarak ilk nesne oluşturuldu");
            Console.ReadKey();
        }
    }
}
