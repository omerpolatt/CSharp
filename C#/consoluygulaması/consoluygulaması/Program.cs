using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace consoluygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
                                    //yazdır komutudur
            Console.WriteLine("isminiz :"); // Console.Write ve Console.writeline arasındaki fark write aynı satıra devam ederken
                                            // Console.Writeline bir alt satırdan ifadeyi almaya başlar

            string isim = Console.ReadLine(); //Console.Readline input verialma komutudur

            if (isim == "ömer")
            {
                Console.WriteLine("isminiz"+ "\t"+isim);
            }
            else
            {
                Console.WriteLine("tekrar isim giriniz");
            }
            Console.ReadKey(); // siyah ekran dediğmiz kod ekranının açılmasını yarayan komuttur bunu da mümkün olduüunda eklemeliyiz.
                // kod ekranını açar ve bir tuşa filan basana kadar o ekranın açık olmasını sağlar.





        }
    }
}
