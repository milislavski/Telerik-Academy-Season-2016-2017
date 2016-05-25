using System;

class PrimeCheck
{
    static void Main()
    {
        int numberToCheck = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (numberToCheck <= 1)
        {
            isPrime = false;
        }
        double maxDivider = Math.Sqrt(numberToCheck);
        for (int divider = 2; divider <= maxDivider; divider++)
        {
            if (numberToCheck % divider == 0)
            {
                isPrime = false;
            }
        }
        if (isPrime == true)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }
    }
}
