using System;

namespace OddOrEven
{
    class Startup
    {
        private static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(n % 2 == 0 ? "even {0}" : "odd {0}", n);
        }
    }
}
