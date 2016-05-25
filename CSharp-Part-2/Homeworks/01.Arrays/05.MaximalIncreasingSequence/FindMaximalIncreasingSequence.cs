using System;

class FindMaximalIncreasingSequence
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthOfArray];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        if (array.Length == 1)
        {
            Console.WriteLine(1);
            return;
        }
        else
        {
            int currentSequence = 1;
            int maxSequence = 1;
            int firstValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > firstValue)
                {
                    currentSequence++;
                }
                else
                {
                    if (currentSequence > maxSequence)
                    {
                        maxSequence = currentSequence;
                    }
                    firstValue = array[i];
                    currentSequence = 1;
                }
                
            }
            if (currentSequence > maxSequence)
            {
                maxSequence = currentSequence;
            }
            Console.WriteLine(maxSequence);
        }


    }
}

