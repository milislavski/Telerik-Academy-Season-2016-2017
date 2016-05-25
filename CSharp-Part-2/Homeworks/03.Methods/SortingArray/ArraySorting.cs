
namespace SortingArray
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class ArraySorting
    {
        static void Main()
        {

            int n = int.Parse(Console.ReadLine());
            var inputNumbers = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            var start = 0;
            var end = inputNumbers.Length - 1;
            var index = GetMaxElement(inputNumbers, start, end);

            var ascending = AscendingSort(inputNumbers);
            var output = string.Join(" ", ascending);
            Console.WriteLine(output);
        }

        private static int[] DescendingSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int swap = arr[i];
                int max = GetMaxElement(arr, i, arr.Length - 1);
                arr[i] = arr[max];
                arr[max] = swap;
            }
            return arr;
        }

        private static int[] AscendingSort(int[] arr)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int swap = arr[i];
                int max = GetMaxElement(arr, 0, i);
                arr[i] = arr[max];
                arr[max] = swap;
            }
            return arr;
        }

        private static int GetMaxElement(int[] arr, int start, int end)
        {
            if (start < 0 || end >= arr.Length)
            {
                throw new Exception("Index Out of range.");
            }
            int max = start;
            for (int i = start; i < end; i++)
            {
                if (arr[max] < arr[i + 1])
                {
                    max = i + 1;
                }
            }
            return max;
        }
    }
}


