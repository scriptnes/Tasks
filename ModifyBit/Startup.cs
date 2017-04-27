using System;

namespace ModifyBit
{
    internal class Startup
    {
        private static void Main()
        {
            var inputN = ulong.Parse(Console.ReadLine()); // N will always be a valid 64-bit unsigned integer.
            var inputP = int.Parse(Console.ReadLine()); // P will always be between in the range [0, 64]
            var inputV = int.Parse(Console.ReadLine()); // v will be always either 0 or 1

            var mBit = 0U;

            if (inputV == 0)
            {
                var mask = (ulong)~(1 << inputP);
                mBit = (uint) (inputN & mask);
            }
            else
            {
                var mask = (ulong)1 << inputP;
                mBit = (uint) (inputN | mask);
            }

            Console.WriteLine(mBit);
        }

    }
}
