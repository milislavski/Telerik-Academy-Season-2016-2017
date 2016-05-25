using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static int ReadNumbers(int start, int end)
        {

            int numb = int.Parse(Console.ReadLine());
            if (numb < start || numb > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            return numb;
        }
    }
}
