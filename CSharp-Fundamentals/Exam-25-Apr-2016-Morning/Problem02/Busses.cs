using System;

class Busses

{
    static void Main()
    {
        int busses = int.Parse(Console.ReadLine());
        int[] allSpeeds = new int[busses];

        for (int i = 0; i < busses; i++)
        {
            int currentSpeed = int.Parse(Console.ReadLine());
            allSpeeds[i] = currentSpeed;
        }

        int countGroups = 1;


        for (int i = 1; i < allSpeeds.Length; i++)
        {
            if (allSpeeds[i] > allSpeeds[i - 1])
            {
                allSpeeds[i] = allSpeeds[i - 1];
            }

            else if (allSpeeds[i] < allSpeeds[i-1])
            {
                countGroups++;
            }
            else
            {
                countGroups += 1;
            }
            //else
            //{
            //    if (allSpeeds[i] == allSpeeds[i-1])
            //    {
            //        countGroups++;
                    
            //    }
            //    countGroups++;
            //}
        }
        Console.WriteLine(countGroups);
    }
}

