using System;

class CompareTwoАrrays
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] firstArray = new int[n];
        int[] secondArray = new int[n];

        for (int i = 0; i < 2 * n; i++)
        {
            if (i < n)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            else
            {
                secondArray[i - n] = int.Parse(Console.ReadLine());
            }
        }

        bool isEqual = true;

        for (int i = 0; i < n; i++)
        {
            if (firstArray[i] != secondArray[i])
            {
                isEqual = false;
            }
        }

        if (isEqual)
        {
            Console.WriteLine("Equal");
        }
        else
        {
            Console.WriteLine("Not equal");
        }
    }
}

