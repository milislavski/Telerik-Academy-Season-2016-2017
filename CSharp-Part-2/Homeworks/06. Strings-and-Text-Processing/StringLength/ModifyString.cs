using System;

namespace StringLength
{
    class ModifyString
    {
        static void Main()
        {
            var inputString = Console.ReadLine();
            var result = FillString(inputString);

            Console.WriteLine(result);
        }

        static string FillString (string str)
        {
            str = str.Replace(@"\", string.Empty);
            var length = str.Length;
            var maxLength = 20;
            var symbolToFill = '*';

            if (length != maxLength)
            {
                var endStringLength = maxLength - length;
                str += new string(symbolToFill, endStringLength);
            }

            return str;
        }
    }
}
