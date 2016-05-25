using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    class PrintTenRandomNumbers
    {
        static void Main()
        {
            Random randomNumbers = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(randomNumbers.Next(100, 201));
            }
        }
    }
}
