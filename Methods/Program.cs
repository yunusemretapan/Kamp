using System;
using System.Collections.Generic;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<Product> products = new List<Product> {
            new Product{Id=1, Name="Apple", Price=25, Description="Apple of Amasya"},
            new Product{Id=1, Name="Orange", Price=25, Description="Orange of Antalya"},
            };

            foreach (Product item in products)
            {
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Description);
                Console.WriteLine("---------------------");
            }

            Console.WriteLine("------------------Methods------------------");

            //instance - örnek

            BasketManager basketManager = new BasketManager();
            basketManager.Add(new Product { Name = "Apple" });
            basketManager.Add(new Product { Name = "Orange" });


            basketManager.Add2("Apple", "Apple of Amasya", 20);
        }
    }
}
