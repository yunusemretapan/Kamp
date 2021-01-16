using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //type safety
            double dolarYestarday = 7.4;
            double dolarToday = 7.51;

            if (dolarYestarday > dolarToday)
            {
                Console.WriteLine("increase button");
            }
            else
            {
                Console.WriteLine("decrease button");
            }
        }
    }
}
