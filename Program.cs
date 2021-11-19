using System;
using System.Collections.Generic;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fruits = new List<string>();
            fruits.Add("Jabłko");
            fruits.Add("Gruszka");
            fruits.Add("Brzoskwinia");
            fruits.Add("Czereśnie");
            int i = 0;
            for (i = 0; i < fruits.Count; i++)
            {
                Console.Write(fruits[i]);
                if (i < fruits.Count - 1)
                    Console.Write(", ");
            }
            Console.WriteLine();
            fruits.Remove("Jabłko");
            fruits.RemoveAt(fruits.Count - 1);
            for (i = 0; i < fruits.Count; i++)
            {
                Console.Write(fruits[i]);
                if (i < fruits.Count - 1)
                    Console.Write(", ");
            }
        }
    }
}
