
namespace IntegerCalculations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class SomeCalculations
    {
        static void Main()
        {
            var input = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            Console.WriteLine(GetMinimum(input));
            Console.WriteLine(GetMaximum(input));
            Console.WriteLine("{0:F2}",GetAverage(input));
            Console.WriteLine(GetSum(input));
            Console.WriteLine(GetProduct(input));
        }
        public static int GetMinimum(int[] numbers)
        {
            var min = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i]<min)
                {
                    min = numbers[i];
                }
            }

            return min;
        }

        public static int GetMaximum(int[] numbers)
        {
            var max = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            return max;
        }

        public static double GetAverage(int[] numbers)
        {
            
            double average = GetSum(numbers) / (double)numbers.Length;
            return average;
        }

        public static int GetSum(int[] numbers)
        {
            var sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static long GetProduct(int[] numbers)
        {
            long product = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                product *= numbers[i];
            }

            return product;
        }
    }
}
