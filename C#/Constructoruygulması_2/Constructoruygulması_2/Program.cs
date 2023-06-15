using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructoruygulması_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu şekilde tanımlayınca ad ve soyad bizim tanımladığımız değerler girilecek girilmeyen değerler
            // ise Constructor daki bilgiler olarak girilecektir..
            //ad ve soyad bilgileri hiç girilmeseydi boş olarak gösteriecekti tüm nesneler için memlket ve cinsiyet bilgiileri 
            //ortaktır bu bize ortak özellkikleri olan nesnelerde kolaylık sağlar..
            Kimlik kişi = new Kimlik();
            kişi.AD = "ÖMER"; // burdaki set deki fonksiyonlarıda çalıştıurır get set özellikleri burda tekrar kullandık..
            kişi.SOYAD = "polat";
            Console.WriteLine(kişi.AD);
            Console.WriteLine(kişi.SOYAD);
            Console.WriteLine(kişi.tc_no);
            Console.WriteLine(kişi.memleket);
            Console.WriteLine(kişi.cinsiyet);



            

            Console.ReadKey();

        }
    }
}
