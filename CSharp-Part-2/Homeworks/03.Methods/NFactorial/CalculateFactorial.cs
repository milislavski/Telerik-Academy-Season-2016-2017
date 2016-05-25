using System;
using System.Numerics;

namespace NFactorial
{
    class CalculateFactorial
    {
        static void Main()
        {
            var number = int.Parse(Console.ReadLine());
            var facrtorial = GetFactorial(number);
            Console.WriteLine(facrtorial);
        }

        private static BigInteger GetFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * GetFactorial(number - 1);
        }
    }
}

