using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        BigInteger kFactorial = k;
        BigInteger nFactorial = n;

        for (int i = 1; i < n; i++)
        {
            if (k - i > 0)
            {
                kFactorial *= (k - i);
            }
            nFactorial *= (n - i);
        }

        Console.WriteLine(nFactorial / kFactorial);
    }
}

