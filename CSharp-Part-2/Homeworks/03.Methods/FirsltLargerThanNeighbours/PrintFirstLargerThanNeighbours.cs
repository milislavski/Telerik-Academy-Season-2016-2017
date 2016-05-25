namespace FirsltLargerThanNeighbours
{
    using System;
    using System.Linq;

    class PrintFirstLargerThanNeighbours
    {
        static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(n => int.Parse(n))
                .ToArray();

            Console.WriteLine(ReturnIndexOfFirsltLargerThanNeighbours(inputNumbers));
        }

        static int ReturnIndexOfFirsltLargerThanNeighbours(int[] array)
        {
            int index = -1;

            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1] && array[i] > array[i - 1])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
    }
}
