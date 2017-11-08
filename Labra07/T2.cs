using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labra07
{
    class T2
    {
        public static void Test()
        {
            List<Product> ostoskori = new List<Product>();
            ostoskori.Add(new Product("Milk",1.4F));
            ostoskori.Add(new Product("Beer", 2.2F));
            ostoskori.Add(new Product("Butter", 3.2F));
            ostoskori.Add(new Product("Cheese", 4.2F));
            Console.WriteLine("All products in collection:");
            foreach (Product tavara in ostoskori)
            {
                Console.WriteLine(tavara.ToString());
            }

        }
    }
    class Product
    {
        string Nimi { get; set; }
        float Hinta { get; set; }
        public Product(string nimi, float hinta)
        {
            Nimi = nimi;
            Hinta = hinta;
        }
        public override string ToString()
        {
            return "- product: " + Nimi + " " + Hinta + " e";
        }
    }
}
