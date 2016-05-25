namespace SayHallo
{
    using System;

    class SayHalloToUser
    {
        static void Main()
        {
            Console.WriteLine(SayHi()); 
        }

        static string SayHi()
        {
            string name = Console.ReadLine();
            string hello = "Hello, ";
            return hello + name + "!";
        }
    }
}
