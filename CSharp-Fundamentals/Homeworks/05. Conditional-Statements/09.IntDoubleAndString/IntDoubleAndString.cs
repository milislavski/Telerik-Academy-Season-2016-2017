using System;

class IntDoubleAndString
{
    static void Main()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "integer":
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine(intNumber + 1);
                break;
            case "real":
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:F2}", (doubleNumber + 1));
                break;
            case "text":
                string stringValue = Console.ReadLine();
                Console.WriteLine(stringValue + "*");
                break;
            default:
                break;
        }
    }
}








