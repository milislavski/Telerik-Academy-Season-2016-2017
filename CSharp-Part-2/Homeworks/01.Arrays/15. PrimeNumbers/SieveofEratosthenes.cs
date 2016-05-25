using System;
using System.Numerics;
using System.Collections.Generic;

class SieveofEratosthenes
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        bool[] primes = new bool[n + 1];
        double divider = Math.Sqrt(primes.Length);
        int primeNumber = 0;
        for (int i = 2; i <= n; i++)
        {
            if (primes[i] == false)
            {
                if (i < divider)
                {
                    long product = i * i;
                    for (long j = product; j <= n; j += i)
                    {
                        primes[j] = true;
                    }
                }
                primeNumber = i;
            }
        }

        Console.WriteLine(primeNumber);

    }

}