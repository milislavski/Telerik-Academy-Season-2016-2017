﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesOfLetters
{
    class Program
    {
        static void Main()
        {
            var input = Console.ReadLine();
            StringBuilder result = new StringBuilder();

            result.Append(input[0]);

            for (int i = 1; i < input.Length; i++)
            {
                if (input[i] != input[i - 1])
                {
                    result.Append(input[i]);
                }
            }

            var output = result.ToString();
            Console.WriteLine(output);
        }
    }
}
