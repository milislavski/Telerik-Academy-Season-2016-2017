using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryToHexadecimal
{
    class BinaryToHex
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = ConvertBinaryToHexNumber(input);
            Console.WriteLine(result);
        }

        static string ConvertBinaryToHexNumber(string binary)
        {
            string hexNumber = "";
            if (binary.Length % 4 != 0)
            {
                binary = new string('0', 4 - binary.Length % 4) + binary;
            }

            for (int i = 0; i < binary.Length; i+=4)
            {
                var currentHexDigit = binary.Substring(i, 4);
                switch (currentHexDigit)
                {
                    case "0000":
                        hexNumber += 0;
                        break;
                    case "0001":
                        hexNumber += 1;
                        break;
                    case "0010":
                        hexNumber += 2;
                        break;
                    case "0011":
                        hexNumber += 3;
                        break;
                    case "0100":
                        hexNumber += 4;
                        break;
                    case "0101":
                        hexNumber += 5;
                        break;
                    case "0110":
                        hexNumber += 6;
                        break;
                    case "0111":
                        hexNumber += 7;
                        break;
                    case "1000":
                        hexNumber += 8;
                        break;
                    case "1001":
                        hexNumber += 9;
                        break;
                    case "1010":
                        hexNumber += "A";
                        break;
                    case "1011":
                        hexNumber += "B";
                        break;
                    case "1100":
                        hexNumber += "C";
                        break;
                    case "1101":
                        hexNumber += "D";
                        break;
                    case "1110":
                        hexNumber += "E";
                        break;
                    case "1111":
                        hexNumber += "F";
                        break;
                    default:
                        break;
                }
            }
            return hexNumber;
        }
    }
}
