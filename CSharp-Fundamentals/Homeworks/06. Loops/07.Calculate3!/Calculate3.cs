using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        BigInteger result = (GetFactorial(n)) / (GetFactorial(k) * GetFactorial(n - k));
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

