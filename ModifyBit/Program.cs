using System;

namespace ModifyBit
{
    class Startup
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine()); //N will always be a valid 64-bit unsigned integer.
            int P = int.Parse(Console.ReadLine()); // P will always be between in the range [0, 64]
            int v = int.Parse(Console.ReadLine()); // v will be always either 0 or 1

            ulong mBit = 0U;

            if (v == 0)
            {
                ulong mask = (ulong)~(1 << P);
                mBit = N & mask;
            }
            else
            {
                ulong mask = (ulong)1 << P;
                mBit = N | mask;
            }

            Console.WriteLine(mBit);
        }

    }
}
