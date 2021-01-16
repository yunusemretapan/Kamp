using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //naming convention
        //syntax
        //good code
        public void Add(Product product)
        {
            Console.WriteLine("Congratulations. Added to cart. " + product.Name);
        }

        //bad code
        public void Add2(string name, string description, double price)
        {
            Console.WriteLine("Congratulations. Added to cart. " + name + description + price);
        }
    }
}
