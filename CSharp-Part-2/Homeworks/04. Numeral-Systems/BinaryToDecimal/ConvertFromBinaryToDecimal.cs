using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToDecimal
{
    class ConvertFromBinaryToDecimal
    {
        static void Main()
        {
            var input = Console.ReadLine();
            long result = ConvertBinaryToDecimal(input);
            Console.WriteLine(result);
        }

        static long ConvertBinaryToDecimal(string binary)
        {
            long decimalNumber = 0;

            for (int i = 0; i < binary.Length; i++)
            {
                decimalNumber += (long.Parse(binary[binary.Length - 1 - i].ToString())) * (long)Math.Pow(2, i);
            }

            return decimalNumber;
        }
    }
}
