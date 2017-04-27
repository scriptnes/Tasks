using System;

namespace MoonGravity
{
    internal class Startup
    {
        private static void Main()
        {
            var inputW = float.Parse(Console.ReadLine());

            var calc = inputW * 17 / 100f;
            Console.WriteLine("{0:0.000}", calc);
        }
    }
}
