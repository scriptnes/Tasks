using System;

namespace N_thBit
{
    class Startup
    {
        private static void Main()
        {
            var inputP = ulong.Parse(Console.ReadLine());
            var inputN = byte.Parse(Console.ReadLine());

            var mask = 1 << inputN;
            var nThBit = (inputP & (ulong)mask) >> inputN;

            Console.WriteLine(nThBit == 0 ? 0 : 1);
        }

    }
}
