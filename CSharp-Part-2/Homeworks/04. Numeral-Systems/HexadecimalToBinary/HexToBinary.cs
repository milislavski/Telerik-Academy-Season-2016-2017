using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalToBinary
{
    class HexToBinary
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = ConvertHexToBinaryNum(input);
            Console.WriteLine(result);
        }

        static string ConvertHexToBinaryNum(string hexNumber)
        {
            string binary = "";

            for (int i = 0; i < hexNumber.Length; i++)
            {
                if (hexNumber[i] >= '0' && hexNumber[i] <= '9')
                {
                    binary += Convert.ToString(int.Parse(hexNumber[i].ToString()), 2).PadLeft(4,'0');
                }
                else
                {
                    binary += Convert.ToString((hexNumber[i]  - 'A' + 10), 2).PadLeft(4, '0');
                }
            }

            return binary.TrimStart('0');
        }
    }
}
