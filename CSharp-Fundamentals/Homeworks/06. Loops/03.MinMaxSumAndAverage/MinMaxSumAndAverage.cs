using System;

class MinMaxSumAndAverage
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double sum = 0;
        double min = double.MaxValue;
        double max = double.MinValue;
        double average = 0;
        double[] numbers = new double[n];

        for (int i = 0; i < n; i++)
        {
            double currentNumber = double.Parse(Console.ReadLine());
            numbers[i] = currentNumber;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        Array.Sort(numbers);
        min = numbers[0];
        max = numbers[n - 1];
        average = sum / (double)n;
        Console.WriteLine("min={0:F2}", min);
        Console.WriteLine("max={0:F2}", max);
        Console.WriteLine("sum={0:F2}", sum);
        Console.WriteLine("avg={0:F2}", average);

    }
}

