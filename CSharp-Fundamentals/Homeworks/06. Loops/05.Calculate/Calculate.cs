using System;

class Calculate
{
    static void Main()
    {
        long n = int.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());

        double sum = 1;

        for (int i = 1; i <= n; i++)
        {
            sum += (double)(GetFactorial(i)) / (Math.Pow(x, i));
        }

        Console.WriteLine("{0:F5}", sum);
    }

    private static long GetFactorial(long number)
    {
        if (number == 1)
        {
            return 1;
        }
        return number * GetFactorial(number - 1);
    }
}

