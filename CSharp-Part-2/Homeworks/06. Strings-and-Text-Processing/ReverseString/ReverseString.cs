using System;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = Reverse(input);

            // second way
            //var secondResult = string.Concat(Enumerable.Reverse(input));

            Console.WriteLine(result);
            //Console.WriteLine(secondResult);
        }

        static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();

            for (int i = str.Length-1; i >=0; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();
        }
    }
}
