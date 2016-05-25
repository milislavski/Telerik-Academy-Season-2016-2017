using System;
using System.Text.RegularExpressions;

namespace RaplaceTags
{
    class ReplacingTags
    {
        static void Main()
        {
            var input = Console.ReadLine();
            var result = Regex.Replace(input, @"<a href=""(.*?)"">(.*?)</a>", @"[URL=$1]$2[/URL]");

            Console.WriteLine(result);
        }
    }
}
