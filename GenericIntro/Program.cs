using System;

namespace GenericIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
            
            MyList<string> names = new MyList<string>();
            names.Add("Engin");

            Console.WriteLine(names.Length);
        }
    }
}
