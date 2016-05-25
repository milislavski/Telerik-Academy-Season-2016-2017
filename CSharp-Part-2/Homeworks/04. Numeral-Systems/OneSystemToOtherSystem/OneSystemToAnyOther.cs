using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace OneSystemToOtherSystem
{
    class OneSystemToAnyOther
    {
        static void Main(string[] args)
        {
            BigInteger fromBaseSystem = BigInteger.Parse(Console.ReadLine());
            var number = Console.ReadLine();
            BigInteger toBaseSystem = BigInteger.Parse(Console.ReadLine());

            BigInteger decimalNumber = ConvertToDecimal(number,fromBaseSystem);
            var result = ConvertFromDecimal(decimalNumber, toBaseSystem);
            Console.WriteLine(result);

        }


        static BigInteger ConvertToDecimal(string number, BigInteger fromBase)
        {
            BigInteger result = 0; // if results are false try with BigIntiger;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                if (number[i] >= '0' && number[i] <= '9')
                {
                    result += ulong.Parse(number[i].ToString()) * BigInteger.Pow(fromBase, number.Length - i - 1);
                }
                else
                {
                    result += (ulong)(number[i] - 'A' + 10) * BigInteger.Pow(fromBase, number.Length - i - 1);
                }
            }
            return result;
        }

        static string ConvertFromDecimal(BigInteger number, BigInteger toBase)
        {
            string result = "";
            if (number == 0)
            {
                result = "0";
            }
            else
            {
                while (number > 0)
                {
                    if (number % toBase < 10)
                    {
                        result = number % toBase + result;
                    }
                    else
                    {
                        result = (char)(number % toBase + 'A' - 10) + result;
                    }
                    number /= toBase;
                }
            }
            return result;
        }
    }
}
