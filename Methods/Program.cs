using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Ozellik = "Amasya elması";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 10;
            product2.Ozellik = "Diyarbakır Karpuzu";

            Product[] products = new Product[] {product1,product2};

            foreach (Product product in products)
            {
                Console.WriteLine(product.Adi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Ozellik);
                Console.WriteLine("*********");
            }

            Console.WriteLine("-------Methods-------");
            //instance - örnek oluşturmak
            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(product1);
            sepetManager.Ekle(product2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12);//encapsulation
            sepetManager.Ekle2("Elma", "Yeşil Elma", 9);
            sepetManager.Ekle2("Çilek", "Taze Çilek", 15);
        }
    }
}
//Don't repeat yourself - DRY - Clean Code - est Practice
//C# ve Java dilleri Çok Büyük Çoğunlukla Classlardan  Oluşur