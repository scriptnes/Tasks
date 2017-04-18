using System;

namespace BitExchange_v2
{
    class Startup
    {
        static void Main()
        {
            uint N = uint.Parse(Console.ReadLine()); //N will always be a valid 32-bit unsigned integer.

            uint lo = N & 0x00000038; // get bits 3, 4, 5
            uint hi = N & 0x07000000; // get bits 24, 25, 26
            N = N &~(uint)0x07000038; // clear bits 3, 4, 5 and 24, 25, 26
            N = N | lo << 21; // put bits 3, 4, 5 in 24, 25, 26
            N = N | hi >> 21; // put bits 24, 25, 26 in 3, 4, 5

            Console.WriteLine(N);
        }


    }
}
