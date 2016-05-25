using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Remove_elements_from_array
{
    class RemoveElements
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array = new int[N];
            int[] dp = new int[N];

            for (int i = 0; i < N; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            int maxSizeOfSubseq = 0;
            for (int i = 0; i < N; i++)
            {
                dp[i] = 1;
                maxSizeOfSubseq = 0;
                for (int j = 0; j <= i - 1; j++)
                {
                    if (array[j] <= array[i] && dp[j] >= maxSizeOfSubseq)
                    {
                        maxSizeOfSubseq = dp[j];
                    }
                }
                dp[i] = dp[i] + maxSizeOfSubseq;
            }


            //Now find the Max Size Of Subsequence amongst all computes subsequence lengths
            maxSizeOfSubseq = 0;
            for (int count = 0; count < dp.Length; ++count)
            {
                if (dp[count] > maxSizeOfSubseq)
                {
                    maxSizeOfSubseq = dp[count];
                }
            }

            Console.WriteLine(N - maxSizeOfSubseq);
            
        }
    }
}









//using System;

//class RemoveElementsFromArray
//{
//    static void Main()
//    {
//        int n = int.Parse(Console.ReadLine());
//        var numbers = new int[n];

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = int.Parse(Console.ReadLine());
//        }

//        int counter = 0;

//        for (int i = 0; i < numbers.Length - 1; i++)
//        {
//            if (numbers[i] > numbers[i + 1])
//            {

//                counter++;
//            }

//        }

//        Console.WriteLine(counter);
//    }
//}