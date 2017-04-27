using System;

namespace ComparingFloats
{
    internal class Startup
    {
        static void Main()
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var eps = 0.000001;

            Console.WriteLine(Math.Abs(a - b) > eps ? "false" : "true");
        }
    }
}
