using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 15, 3, 21, 9, 4, 15, 31, 44, 1 };
            for (int i = 0; i < numbers.Length; i++)
                Console.WriteLine("Liczba: " + numbers[i]);
        }
    }
}
