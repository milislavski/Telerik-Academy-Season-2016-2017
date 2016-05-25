using System;

class MergeSort
{
    static void Main()
    {
        int LengthOfArray = int.Parse(Console.ReadLine());
        int[] numbers = new int[LengthOfArray];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        var resultArray = SplitArray(numbers);

        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.WriteLine(resultArray[i]);
        }

    }

    static int[] SplitArray(int[] array)
    {
        if (array.Length == 1) 
        {                    
            return array;
        }

        int middleIndex = array.Length / 2;
        int[] leftArray = new int[middleIndex];
        int[] rightArray = new int[array.Length - middleIndex];

        for (int i = 0; i < middleIndex; i++)
        {
            leftArray[i] = array[i];
        }

        for (int i = middleIndex, j = 0; i < array.Length; i++, j++)
        {
            rightArray[j] = array[i];
        }

        leftArray = SplitArray(leftArray); 
        rightArray = SplitArray(rightArray);

        return Merge(leftArray, rightArray); 
    }

    static int[] Merge(int[] leftArray, int[] rightArray)
    {
        int leftCounter = 0;
        int rightCounter = 0;
        int[] resultArray = new int[leftArray.Length + rightArray.Length];
        for (int i = 0; i < resultArray.Length; i++)
        {
            if (rightCounter == rightArray.Length 
                || ((leftCounter < leftArray.Length) 
                && (leftArray[leftCounter] <= rightArray[rightCounter])))
            {
                resultArray[i] = leftArray[leftCounter];
                leftCounter++;
            }
            else if (leftCounter == leftArray.Length 
                || ((rightCounter < rightArray.Length) 
                && (leftArray[leftCounter] >= rightArray[rightCounter])))
            {
                resultArray[i] = rightArray[rightCounter];
                rightCounter++;
            }

        }
        return resultArray;
    }
}

