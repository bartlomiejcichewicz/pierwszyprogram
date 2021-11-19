using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int exam = 69;
            int point = exam;
            if (point >= 0 && point < 40)
                Console.WriteLine("Ocena Nieodstateczna");
            else if (point < 55)
                Console.WriteLine("Ocena Dopuszczająca");
            else if (point < 70)
                Console.WriteLine("Ocena Dostateczna");
            else if (point < 85)
                Console.WriteLine("Ocena Dobra");
            else if (point < 99)
                Console.WriteLine("Ocena Bardzo Dobra");
            else if (point < 100)
                Console.WriteLine("Ocena Celująca");
            else
                Console.WriteLine("Wartość poza zakresem");
        }
    }
}
