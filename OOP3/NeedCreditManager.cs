using System;

namespace OOP3
{
    class NeedCreditManager : ICreditManager
    {
        public void Calculate()
        {
            Console.WriteLine("Need credit calculated.");
        }
    }
}
