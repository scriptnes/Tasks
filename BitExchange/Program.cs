using System;

namespace BitExchange
{
    class Startup
    {
        static void Main()
        {
            //exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer
            uint num = uint.Parse(Console.ReadLine()); //N will always be a valid 32-bit unsigned integer.

            int numP; uint bit1; uint bit2; int mask1, mask2;

            //swap bits 3,4,5 with bits 24,25,26
            for (int i = 0; i < 3; i++)
            {
                // get bit 3 (,4,5)
                numP = (int)(num >> (3 + i));
                bit1 = (uint)(numP & 1);
                // get bit 24 (,25,26)
                numP = (int)(num >> (24 + i));
                bit2 = (uint)(numP & 1);
                // shift bit 3 (,4,5) to positon 24 (,25,26)
                bit1 = bit1 << (24 + i);
                // shift bit 24 (,25,26) to position 3 (,4,5)
                bit2 = bit2 << (3 + i);
                // set bit 3 (,4,5) to zero
                mask1 = 1 << (3 + i);
                num = (uint)(num & ~mask1);
                // set bit 24 (,25,26) to zero
                mask2 = 1 << (24 + i);
                num = (uint)(num & ~mask2);
                // put bit 3 (,4,5) in bit 24 (,25,26)
                num = num | bit1;
                // put bit 24 (,25,26) in bit 3 (,4,5)
                num = num | bit2;
            }

            Console.WriteLine(num);
        }

        //static uint BitExchanger(uint number, int index)
        //{
        //    uint bit = 0;
        //    int mask = 1 << index;
        //    bit = (uint)(number & mask) >> index;

        //    return bit;
        //}
    }
}
