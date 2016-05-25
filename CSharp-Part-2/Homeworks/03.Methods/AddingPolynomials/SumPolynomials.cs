using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class SumPolynomials
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();

            var firstPolinom = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();
            var secondPolinom = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            var result = AddPolynomials(firstPolinom, secondPolinom);
            var output = string.Join(" ", result);
            Console.WriteLine(output);
        }

        private static int[] AddPolynomials(int[] firstArr, int[] secondArr)
        {
            int[] result = new int[Math.Max(firstArr.Length, secondArr.Length)];
            Array.Reverse(firstArr);
            Array.Reverse(secondArr);
            for (int i = 0; i < result.Length; i++)
            {
                if (i < firstArr.Length)
                {
                    result[i] += firstArr[i];
                }
                if (i < secondArr.Length)
                {
                    result[i] += secondArr[i];
                }

            }
            Array.Reverse(result);
            return result;
        }
    }
}
