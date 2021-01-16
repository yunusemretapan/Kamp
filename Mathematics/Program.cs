using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            FourOperations fourOperations = new FourOperations();
            fourOperations.Sum(10, 2);
        }
    }
}
