using System;

class MaxKSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(array);
        Array.Reverse(array);
        int sum = 0;

        for (int i = 0; i < k; i++)
        {
            sum += array[i];
        }

        Console.WriteLine(sum);
    }
}
