using System;
using System.Collections.Generic;

class PrintIndexOfLetters
{
    static void Main()
    {
        var allLetters = new List<char>();
        for (char i = 'a'; i <= 'z'; i++)
        {
            allLetters.Add(i);
        }

        string input = Console.ReadLine();

        foreach (var symbol in input)
        {
            Console.WriteLine(allLetters.IndexOf(symbol));
        }
    }
}

