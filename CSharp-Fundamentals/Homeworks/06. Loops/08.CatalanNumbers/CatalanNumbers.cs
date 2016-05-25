using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger result = GetFactorial(2 * n) / (GetFactorial(n + 1) * GetFactorial(n));

        Console.WriteLine(result);
    }

    private static BigInteger GetFactorial(int n)
    {
        if (n == 0)
        {
            return 1;
        }
        return n * GetFactorial(n - 1);
    }
}

