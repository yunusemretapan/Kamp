﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            Product product1 = new Product { Id = 1, CategoryId = 2, ProductName = "Masa", UnitPrice = 500, UnitsInStock = 3 };

            Product product2 = new Product { Id = 2, CategoryId = 5, ProductName = "Kalem", UnitPrice = 35, UnitsInStock = 5 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
        }
    }
}
