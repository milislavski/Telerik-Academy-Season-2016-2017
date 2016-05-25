using System;

class FindMaximalSequence
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[lengthOfArray];

        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        int maxSequence = 0;
        int currentSequence = 1;

        for (int i = 0; i < numbersArray.Length - 1; i++)
        {
            if (numbersArray[i] == numbersArray[i + 1])
            {
                currentSequence++;
            }
            else
            {
                currentSequence = 1;
            }

            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
        }

        Console.WriteLine(maxSequence);
    }
}

