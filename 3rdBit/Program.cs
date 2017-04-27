using System;

namespace Find3rdBit
{
    internal class Startup
    {
        private static void Main()
        {
            var digit = int.Parse(Console.ReadLine());

            var mask = 1 << 3;
            var find3RdBit = (digit & mask) >> 3;

            Console.WriteLine(find3RdBit == 0 ? 0 : 1);
        }
    }
}
