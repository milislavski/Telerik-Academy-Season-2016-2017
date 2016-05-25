using System;

class Feathers
{
    static void Main()
    {
        double allBirds = double.Parse(Console.ReadLine());
        double allBirdsFeathers = double.Parse(Console.ReadLine());

        double evenMagicNumber = 123123123123;
        double oddMagicNumber = 317;

        double averageFeathersPerBird = allBirdsFeathers / allBirds;
        double result = 0;

        if (allBirds % 2 == 0)
        {
            result = averageFeathersPerBird * evenMagicNumber;
        }
        else
        {
            result = averageFeathersPerBird / oddMagicNumber;
        }

        Console.WriteLine("{0:F4}",result);
    }
}

