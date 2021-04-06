using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //Type safety- tip güvenliği
            //Kendini tekrarlama!! Don't repeat yourself.
            //değer tutucu, alias
            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000;       //Tam sayılar
            double faizOrani = 1.45;         //ondalıklı sayılar
            bool sistemeGirisYapmisMi = true;

            double dolarDun = 7.35;
            double dolarBugun = 7.35;
            //double ondalıklı verilerde kullanılır.

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış oku");
            }
            else if(dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış oku");
            }
            else
            {
                Console.WriteLine("Eşittir butonu");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");              
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
        }
    }
}
