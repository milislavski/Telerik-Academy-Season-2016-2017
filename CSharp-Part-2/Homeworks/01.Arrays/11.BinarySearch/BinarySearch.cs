using System;

class BinarySearch
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] sortedNumbersArray = new int[lengthOfArray];

        for (int i = 0; i < sortedNumbersArray.Length; i++)
        {
            sortedNumbersArray[i] = int.Parse(Console.ReadLine());
        }

        int wantedNumber = int.Parse(Console.ReadLine());

        int startIndex = 0;
        int endIndex = sortedNumbersArray.Length - 1;
        if ((Array.IndexOf(sortedNumbersArray, wantedNumber) == -1) 
            || (sortedNumbersArray[startIndex] >= sortedNumbersArray[endIndex]))
        {
            Console.WriteLine(-1); 
            return;
        }

        while (true)
        {
            int middleIndex = ((endIndex - startIndex) / 2) + startIndex;

            if (sortedNumbersArray[middleIndex] < wantedNumber)
            {
                startIndex = middleIndex + 1;
            }
            else if (sortedNumbersArray[middleIndex] > wantedNumber)
            {
                endIndex = middleIndex - 1;
            }
            else if (sortedNumbersArray[middleIndex] == wantedNumber)
            {
                //indexOfWantedNumber = middleIndex;
                Console.WriteLine(middleIndex);
                break;
            }
        }
    }
}

