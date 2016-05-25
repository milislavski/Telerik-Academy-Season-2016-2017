using System;

class AllocateArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = i * 5;
            Console.WriteLine(numbers[i]);
        }
    }
}

