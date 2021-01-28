using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class SepetManager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + product.Adi);
        }

        public void Ekle2(string urunAdi, string Aciklama, double Fiyat)
        {
            Console.WriteLine("Tebrikler Sepete Eklendi: " + urunAdi);
        }
    }
}
