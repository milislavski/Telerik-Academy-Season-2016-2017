using System;
using System.Text.RegularExpressions;

namespace SubStringInText
{
    class SubStrInText
    {
        static void Main()
        {
            string pattern = Console.ReadLine().Trim();
            string text = Console.ReadLine();

            var count = 0;

            for (int i = 0; i <= text.Length-pattern.Length; i++)
            {
                if (text.Substring(i,pattern.Length).ToLower() == pattern.ToLower())
                {
                    count++;
                }
            }

            Console.WriteLine(count);
            //var count = Regex.Matches(text, pattern, RegexOptions.IgnoreCase).Count;
            //Console.WriteLine(count);
        }
    }
}
