using System;

class SelectionSort
{
    static void Main()
    {
        int lengthOfArray = int.Parse(Console.ReadLine());
        int[] array = new int[lengthOfArray];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array.Length - 1; i++)
        {
            int indexOfSmallestNumber = i;

            for (int j = i+1; j < array.Length; j++)
            {
                if (array[j] < array[indexOfSmallestNumber])
                {
                    indexOfSmallestNumber = j;
                }
            }

            if (indexOfSmallestNumber != i)
            {
                //whit temp value - more memory!!!

                //int temp = array[indexOfSmallestNumber];
                //array[indexOfSmallestNumber] = array[i];
                //array[i] = temp;


                //using binary

                array[indexOfSmallestNumber] ^= array[i];
                array[i] ^= array[indexOfSmallestNumber];
                array[indexOfSmallestNumber] ^= array[i];
            }
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}

