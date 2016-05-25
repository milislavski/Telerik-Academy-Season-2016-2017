using System;
using System.Text;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            var text = Console.ReadLine().Split(new char[] { '<', '>' });
            
            var openTag = "upcase";
            var closeTag = "/upcase";

            var isUpperCase = false;

            var result = new StringBuilder();

            foreach (var word in text)
            {
                if (word == openTag)
                {
                    isUpperCase = true;
                    continue;
                }
                if (word == closeTag)
                {
                    isUpperCase = false;
                    continue;
                }
                if (isUpperCase)
                {
                    result.Append(word.ToUpper());
                }
                else
                {
                    result.Append(word);
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
