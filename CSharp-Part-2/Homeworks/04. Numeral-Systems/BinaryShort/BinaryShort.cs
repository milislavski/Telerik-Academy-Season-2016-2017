﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short number = short.Parse(Console.ReadLine());
            string binary = Convert.ToString(number, 2).PadLeft(16, '0');
            Console.WriteLine(binary);
        }
    }
}
