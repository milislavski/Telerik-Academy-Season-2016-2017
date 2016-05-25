using System;

class SumOf5Numbers
{
    static void Main()
    {
        double sum = 0;
        for (int i = 0; i < 5; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            sum += currentNumber;
        }
        Console.WriteLine(sum);
    }
}

