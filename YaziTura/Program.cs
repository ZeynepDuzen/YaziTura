using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YaziTura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int para; // 1:tura, 0:yazi

            Random rdm = new Random();
            para = rdm.Next(0,2);

            Console.WriteLine("Yazi mi: y, tura mi: t");
            string kullaniciGirisi = Console.ReadLine();
            int giris = kullaniciGirisi == "y" ? 0 : kullaniciGirisi == "t" ? 1 : -1;

            if (giris == -1)
            {
                Console.WriteLine("Lütfen y veya t giriniz");
            }
            else
            {
                Console.WriteLine(giris == para ? "Tebrikler, bildiniz" : "Bilemediniz");
            }


            Console.Read();
        }
    }
}
