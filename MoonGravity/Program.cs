using System;

namespace MoonGravity
{
    class Startup
    {
        static void Main()
        {
            float w = float.Parse(Console.ReadLine());

            float calc = w * 17 / 100f;
            Console.WriteLine("{0:0.000}", calc);
        }
    }
}
