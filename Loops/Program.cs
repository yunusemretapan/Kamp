using System;
using System.Collections.Generic;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            List<string> list = new List<string> { "C#", "Java", "Python" };

            string[] array = new string[] { "C#", "Java", "Python" };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
