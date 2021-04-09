using System;

namespace DegerVeReferanstipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi2 = sayi1; //İlk değeri ikinci değere eşitliyor. //stack and heap.
            Console.WriteLine(sayi1); //cevap 30 olur.
            sayi2 = 65;
            //değer == int, decimal, float, double ,bool
            //referanslar == array, class, interface

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = ? 999 olur. //sayilar1 sayilar2 nin kümesini alır sayilar 1 kümesi tamamen unutulur.sayilar2 nin ilk elemanı 999 atandığı için sayilar 1 inde ilk elemanı 999 olur aynı değer kümelerinden oluştukları için eşitlemeden sonra.

        }   
    }
}
