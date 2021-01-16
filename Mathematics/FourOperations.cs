using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics
{
    class FourOperations
    {
        public void Sum(int number1, int number2)
        {
            int result = number1 + number2;
            Console.WriteLine("Result: " + result);
        }

        public void Minus(int number1, int number2)
        {
            int result = number1 - number2;
            Console.WriteLine("Result: " + result);
        }

        public void Multiply(int number1, int number2)
        {
            int result = number1 * number2;
            Console.WriteLine("Result: " + result);
        }

        public void Divide(int number1, int number2)
        {
            int result = number1 / number2;
            Console.WriteLine("Result: " + result);
        }
    }
}
