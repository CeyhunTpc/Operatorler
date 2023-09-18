using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Aritmatiksel Operatörler

            int sayi1 = 15;
            int sayi2 = 45;
            int toplam = sayi1 + sayi2;
            Console.WriteLine("toplam =");
            Console.WriteLine(toplam);

            //Sayi 1 den sayı 2 çıkart fark isminceki değişkene at
            int fark = sayi1 - sayi2;
            Console.WriteLine("Fark = ");
            Console.WriteLine(fark);

            int carpim = sayi1 * sayi2;
            Console.WriteLine("Çarpım = ");
            Console.WriteLine(carpim);

            double bolum = sayi1 / sayi2;
            Console.WriteLine("Bölüm");
            Console.WriteLine(bolum);

            double sayi3 = 13;
            double sayi4 = 2;

            double bolum2 = sayi3 / sayi4;
            Console.WriteLine("Bölüm = ");
            Console.WriteLine(bolum2);

            //mod iki sayidan kalan 
            int mod = sayi1 % sayi2;
            Console.WriteLine("Mod = ");
            Console.WriteLine(mod);

            sayi1++;
            Console.WriteLine(sayi1);
            #endregion

        }
    }
}
