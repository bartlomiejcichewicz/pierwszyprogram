using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj swoje imię:");
            var name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            int number = 0;
            float money = 0;
            string text = "";
            bool isLogged = true;
            char myChar = ' ';
            decimal price = 0;
            Console.WriteLine(number);
            Console.WriteLine(money);
            Console.WriteLine(text);
            Console.WriteLine(isLogged);
            Console.WriteLine(myChar);
            Console.WriteLine(price);
        }
    }
}
