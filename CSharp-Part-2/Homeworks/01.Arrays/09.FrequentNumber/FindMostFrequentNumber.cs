using System;

class FindMostFrequentNumber
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthOfArray];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int counterOfEqualNumbers = 1;
        int maxEqualNumbers = 0;
        int mostFrequentNumber = array[0];

        Array.Sort(array);

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] == array[i - 1])
            {
                counterOfEqualNumbers++;
            }
            else
            {
                counterOfEqualNumbers = 1;
            }
            if (counterOfEqualNumbers > maxEqualNumbers)
            {
                maxEqualNumbers = counterOfEqualNumbers;
                mostFrequentNumber = array[i];
            }
        }

        Console.WriteLine("{0} ({1} times)",mostFrequentNumber,maxEqualNumbers);
    }
}

