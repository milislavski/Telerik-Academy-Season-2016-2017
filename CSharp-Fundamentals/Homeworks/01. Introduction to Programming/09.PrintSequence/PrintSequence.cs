//Print on the console the first 10 members of the sequence from the description. Print each member on a separate line.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class PrintSequence
{
    static void Main()
    {
        for (int number = 2; number < 12; number++)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number * (-1));
            }
            else
            {
                Console.WriteLine(number);
            }
        }
    }
}
