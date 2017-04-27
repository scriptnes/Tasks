using System;

namespace BitExchange_v2
{
    internal class Startup
    {
        private static void Main()
        {
            var inputN = uint.Parse(Console.ReadLine()); //N will always be a valid 32-bit unsigned integer.

            var lo = inputN & 0x00000038; // get bits 3, 4, 5
            var hi = inputN & 0x07000000; // get bits 24, 25, 26
            inputN = inputN &~(uint)0x07000038; // clear bits 3, 4, 5 and 24, 25, 26
            inputN = inputN | lo << 21; // put bits 3, 4, 5 in 24, 25, 26
            inputN = inputN | hi >> 21; // put bits 24, 25, 26 in 3, 4, 5

            Console.WriteLine(inputN);
        }


    }
}
