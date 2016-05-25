using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToBinary
{
    class ConvertDecimalToBinary
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            var result = ConvertDecimalNumberToBinary(number);
            Console.WriteLine(result);
        }

        static string ConvertDecimalNumberToBinary(long number)
        {
            long remainder = 0;
            string binaryNumber = string.Empty;

            while (number != 0)
            {
                remainder = number % 2;
                binaryNumber = remainder + binaryNumber;

                number /= 2;
            }

            return binaryNumber;

        }
    }
}
