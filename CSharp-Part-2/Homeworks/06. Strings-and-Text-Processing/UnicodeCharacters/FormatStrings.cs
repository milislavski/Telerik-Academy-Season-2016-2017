using System;
using System.Text;

namespace UnicodeCharacters
{
    class FormatStrings
    {
        static void Main()
        {
            string inputText = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            foreach (char ch in inputText)
            {
                result.Append(GetEscapeSequence(ch));
            }
            Console.WriteLine(result.ToString());
        }

        public static string GetEscapeSequence(char ch)
        {
            return "\\u" + ((int)ch).ToString("X4");
        }
    }
}
