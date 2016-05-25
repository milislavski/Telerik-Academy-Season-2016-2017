using System;
using System.Collections.Generic;
using System.Linq;

class FindMaximalSumOfConsecutive
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthOfArray];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int maxSum = array[0];
        int currentSum = array[0];
        //int currentStartIndex = 0;
        //int finalStartIndex = 0;
        //int endIndex = 0;

        for (int i = 1; i < array.Length; i++)
        {
            currentSum += array[i];
            if (currentSum < array[i])
            {
                currentSum = array[i];
                //currentStartIndex = i;
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                //finalStartIndex = currentStartIndex;
                //endIndex = i;
            }
        }
        //var resultArray = new List<int>();
        //for (int i = finalStartIndex; i <= endIndex; i++)
        //{
        //    resultArray.Add(array[i]);
        //}

        //string resultArrayAsString = string.Join(", ", resultArray);
        //Console.WriteLine(resultArrayAsString);

        //UNCOMMENT ALL(without this line) TO PRINT THE SEQUENCE OF ELEMENTS WITH MAXIMAL SUM. 
        Console.WriteLine(maxSum);
    }
}


