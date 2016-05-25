using System;

class OddAndEvenProduct
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        var numbersAsStrings = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        int[] numbers = new int[n];

        
        long evenProduct = 1;
        long oddProduct = 1;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(numbersAsStrings[i]);

            if (i % 2 == 0)
            {
                evenProduct *= numbers[i];
            }
            else
            {
                oddProduct *= numbers[i];
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }


    }
}

