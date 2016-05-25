using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalToHexadecimal
{
    class DecimalToHex
    {
        static void Main()
        {
            long input = long.Parse(Console.ReadLine());
            string result = ConvertDecimalToHexadecimal(input);
            Console.WriteLine(result);
        }

        static string ConvertDecimalToHexadecimal(long number)
        {
            string hexNumber = "";
            if (number == 0)
            {
                hexNumber = "0";
            }
            else
            {
                while (number > 0)
                {
                    switch (number % 16)
                    {
                        case 0:
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                        case 7:
                        case 8:
                        case 9:
                            hexNumber = number % 16 + hexNumber;
                            break;
                        case 10:
                            hexNumber = "A" + hexNumber;
                            break;
                        case 11:
                            hexNumber = "B" + hexNumber;
                            break;
                        case 12:
                            hexNumber = "C" + hexNumber;
                            break;
                        case 13:
                            hexNumber = "D" + hexNumber;
                            break;
                        case 14:
                            hexNumber = "E" + hexNumber;
                            break;
                        case 15:
                            hexNumber = "F" + hexNumber;
                            break;
                    }
                    number /= 16;
                }
            }
            return hexNumber;
        }
    }
}
