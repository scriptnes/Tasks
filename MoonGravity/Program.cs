using System;

namespace MoonGravity
{
    class Program
    {
        static void Main()
        {
            float w = float.Parse(Console.ReadLine());

            float calc = w * 17 / 100f;
            Console.WriteLine("{0:0.000}", calc);
        }
    }
}
