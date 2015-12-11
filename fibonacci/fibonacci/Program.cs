using System;
using System.Numerics;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;
            Console.WriteLine("Enter amount of fibonacci numbers to calculate\n(be careful with values over 10,000)");
            Console.WriteLine("\nEnter 3040 to exit.");
            uint amount = uint.Parse(Console.ReadLine());

            if (amount == 3040)
                return;

            if (amount <= 100000 && amount <= uint.MaxValue)
                Calculate(amount);
            else
                throw new NotSupportedException("Safe mode: True\nValue not supported.");
        }

        static void Calculate(uint amount)
        {
            for (uint i = 0; i < amount; i++)
            {
                if (i != amount - 1)
                    Console.Write("{0}, ", Fibonacci(i));
                else
                    Console.Write("{0}", Fibonacci(i));
            }
            Console.ReadKey();
        }

        static BigInteger Fibonacci(uint n)
        {
            BigInteger number = 0;
            BigInteger nxtNumber = 1;
            for (uint i = 0; i < n; i++)
            {
                BigInteger temp = number;
                number = nxtNumber;
                nxtNumber = temp + nxtNumber;
            }
            return number;
        }
    }
}
