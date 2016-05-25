using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            string nToBinary = Convert.ToString(n, 2);
            int length = nToBinary.Length;
            var allCombs = new List<string>();

            var bests = new List<int>();
                int best = 0;

            for (int i = 0; i < c; i++)
            {
                int countOnes = 0;
                int comb = int.Parse(Console.ReadLine());
                string combToBinary = Convert.ToString(comb, 2).PadLeft(length,'0');

                for (int j = 0; j < length; j++)
                {
                    if (nToBinary[j] != combToBinary[j])
                    {
                        if (combToBinary[j] == '1')
                        {
                            countOnes++;
                        }
                    }
                    bests.Add(countOnes);
                }

            }
            bests.Sort();
            bests.Reverse();
            Console.WriteLine();
        }
        
    }
}
