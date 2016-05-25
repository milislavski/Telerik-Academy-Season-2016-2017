using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FibonacciNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long firstFibonacciNumber = 0;
        long secondFibonacciNumner = 1;
        var fibonacciNumbers = new List<long>();
        fibonacciNumbers.Add(firstFibonacciNumber);
        fibonacciNumbers.Add(secondFibonacciNumner);
        if (n == 1)
        {
            Console.WriteLine(firstFibonacciNumber);
        }
        else if (n == 2)
        {
            Console.WriteLine(string.Join(", ", fibonacciNumbers));
        }
        else
        {
            for (int i = 2; i < n; i++)
            {
                long nextFibonacciNumber = firstFibonacciNumber + secondFibonacciNumner;
                fibonacciNumbers.Add(nextFibonacciNumber);
                firstFibonacciNumber = secondFibonacciNumner;
                secondFibonacciNumner = nextFibonacciNumber;
            }

            Console.WriteLine(string.Join(", ", fibonacciNumbers));
        }
    }
}
