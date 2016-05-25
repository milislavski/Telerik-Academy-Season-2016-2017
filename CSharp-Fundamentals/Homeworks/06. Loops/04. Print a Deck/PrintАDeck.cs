using System;

class PrintАDeck
{
    static void Main()
    {
        string sign = Console.ReadLine();
        int endIndex = 0;
        switch (sign)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
                endIndex = int.Parse(sign);
                break;
            case "J":
                endIndex = 11;
                break;
            case "Q":
                endIndex = 12;
                break;
            case "K":
                endIndex = 13;
                break;
            case "A":
                endIndex = 14;
                break;
            default:
                break;
        }

        for (int i = 2; i <= endIndex; i++)
        {
            for (int j = 1; j <= 4; j++)
            {
                switch (i)
                {
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.Write(i);
                        break;
                    case 10:
                        Console.Write(10);
                        break;
                    case 11:
                        Console.Write("J");
                        break;
                    case 12:
                        Console.Write("Q");
                        break;
                    case 13:
                        Console.Write("K");
                        break;
                    case 14:
                        Console.Write("A");
                        break;
                }
                switch (j)
                {
                    case 1:
                        Console.Write(" of spades, ");
                        break;
                    case 2:
                        Console.Write(" of clubs, ");
                        break;
                    case 3:
                        Console.Write(" of hearts, ");
                        break;
                    case 4:
                        Console.WriteLine(" of diamonds");
                        break;
                }
            }
        }
    }
}

