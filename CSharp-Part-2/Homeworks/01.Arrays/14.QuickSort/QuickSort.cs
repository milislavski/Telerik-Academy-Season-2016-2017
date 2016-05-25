using System;

class QuickSort
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] numbersArray = new int[lengthOfArray];

        for (int i = 0; i < numbersArray.Length; i++)
        {
            numbersArray[i] = int.Parse(Console.ReadLine());
        }

        SortArray(numbersArray, 0, numbersArray.Length - 1);

        for (int i = 0; i < numbersArray.Length; i++)
        {
            Console.WriteLine(numbersArray[i]);
        }
    }

    public static void SortArray(int[] array, int startIndex, int endIndex)
    {
        if (startIndex < endIndex)
        {
            int q = Partition(array, startIndex, endIndex);
            SortArray(array, startIndex, q - 1);
            SortArray(array, q + 1, endIndex);
        }
    }

    private static int Partition(int[] array, int start, int end)
    {
        int pivotNumber = array[end];
        int temp;

        int i = start;
        for (int j = start; j < end; j++)
        {
            if (array[j] <= pivotNumber)
            {
                temp = array[j];
                array[j] = array[i];
                array[i] = temp;
                i++;
            }
        }

        array[end] = array[i];
        array[i] = pivotNumber;

        return i;
    }
}

