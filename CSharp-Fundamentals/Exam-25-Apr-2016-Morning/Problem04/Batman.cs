using System;

class Batman
{
    static void Main()
    {
        int s = int.Parse(Console.ReadLine());
        char ch = char.Parse(Console.ReadLine());
        int width = 3 * s;
        int middleSpaces = s;
        int chars = s;
        int spaces = 0;

        for (int i = 0; i < (s-3)/2; i++)
        {
            Console.Write(new string(' ', spaces));
            Console.Write(new string(ch,chars));
            Console.Write(new string(' ',middleSpaces));
            Console.Write(new string(ch, chars));
            Console.WriteLine(new string(' ', spaces));

            chars--;
            spaces++;
        }

        Console.Write(new string(' ', spaces));
        Console.Write(new string(ch,chars));
        Console.Write(new string(' ', (s - 3) / 2));
        Console.Write(ch);
        Console.Write(' ');
        Console.Write(ch);
        Console.Write(new string(' ', (s - 3) / 2));
        Console.Write(new string(ch, chars));
        Console.WriteLine(new string(' ', spaces));
        spaces++;

        for (int i = 0; i < (s - 3) / 2; i++)
        {
            Console.Write(new string(' ',spaces));
            Console.Write(new string(ch,width-(spaces*2)));
            Console.WriteLine(new string(' ', spaces));

        }
        int bottomSpaces = s + 1;
        for (int i = 0; i < ((s - 3) / 2)+1; i++)
        {
            Console.Write(new string(' ',bottomSpaces));
            Console.Write(new string(ch,width-(bottomSpaces*2)));
            Console.WriteLine(new string(' ', bottomSpaces));
            bottomSpaces++;
        }
        
    }
}

