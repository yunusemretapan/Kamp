﻿using System;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + "added.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + "updated.");
        }
    }
}
