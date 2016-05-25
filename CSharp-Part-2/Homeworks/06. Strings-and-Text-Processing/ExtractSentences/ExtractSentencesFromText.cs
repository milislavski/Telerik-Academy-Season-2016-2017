using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtractSentences
{
    class ExtractSentencesFromText
    {
        static void Main()
        {
            string inputWord = Console.ReadLine();
            string text = Console.ReadLine();

            var separators = new List<char>();

            foreach (var symbol in text)
            {
                if (symbol == '.' || char.IsDigit(symbol) || symbol == '\\')
                {
                    continue;
                }
                if (!char.IsLetter(symbol))
                {
                    separators.Add(symbol);
                }
            }
            var wordSeparators = separators.Distinct().ToArray();
            var sentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries).Select(x => x.Trim()).ToArray();
            var result = new StringBuilder();


            foreach (var sentence in sentences)
            {
                var currentWords = sentence.Split(wordSeparators);
                foreach (var word in currentWords)
                {
                    if (word == inputWord)
                    {
                        result.Append(sentence);
                        result.Append(". ");
                        break;
                    }
                }
            }
            Console.WriteLine(result.ToString());
        }
    }
}
