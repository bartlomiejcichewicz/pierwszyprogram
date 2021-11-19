using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "zielony", "niebieski", "różowy", "czarny", "fioletowy" };
            Console.WriteLine("Mój pierwszy kolor to: " + colors[0]);
            Console.WriteLine("Mój ostatni kolor to: " + colors[colors.Length - 1]);
        }
    }
}
