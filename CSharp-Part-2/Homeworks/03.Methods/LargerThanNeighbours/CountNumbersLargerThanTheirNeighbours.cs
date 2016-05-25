namespace LargerThanNeighbours
{
    using System;
    using System.Linq;

    class CountNumbersLargerThanTheirNeighbours
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            Console.WriteLine(CountLargerThanNeightbours(inputNumbers));
        }

        static int CountLargerThanNeightbours(int[] array)
        {
            int counter = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}
