using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        //naming convention
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Sepete eklendi : "  +  urun.Adi);
        }
        public void Ekle2(string urunAdi, string Aciklama,double fiyat,int stokAdedi) 
        {
            Console.WriteLine("Sepete eklendi : " + urunAdi);
        }
    }
}
