using System;
using System.Linq;
using System.Text;

namespace ExtractSentences
{
    class ExtractSentencesFromText
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string text = Console.ReadLine();

            string[] allSentences = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            char[] wordSeparators = text.Where(ch => !char.IsLetter(ch)).Distinct().ToArray();

            foreach (var sentence in allSentences)
            {
                var currentWords = sentence.Split(wordSeparators, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < currentWords.Length; i++)
                {
                    if (word.ToLower() == currentWords[i].ToLower())//.Trim();
                    {
                        Console.Write(sentence + '.' + ' ');
                        break;
                    }
                }
            }
        }
    }
}
