using System;

namespace PierwszyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10, n2 = 20;
            if (n1 > n2)
                Console.WriteLine("n1 jest większe od n2");
            else if (n2 > n1)
                Console.WriteLine("n2 jest większe od n1");
            else
                Console.WriteLine("n1 jest równe n2");
        }
    }
}
