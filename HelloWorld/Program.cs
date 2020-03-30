using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello DeShawn");
            Console.Read(); // This allows the console to stay open after running the program and executing the functions
        }
    }
}
