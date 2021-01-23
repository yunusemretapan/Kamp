using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<string> names = new List<string> { "Yunus", "Murat", "Kerem", "Halil" };
            names.Add("İlker");
        }
    }
}
