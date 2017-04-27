using System;

namespace DivideBy7and5
{
    internal class Startup
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            if (n % 5 == 0 && n % 7 == 0)
                Console.WriteLine("true {0}", n);
            else
                Console.WriteLine("false {0}", n);
        }
    }
}
