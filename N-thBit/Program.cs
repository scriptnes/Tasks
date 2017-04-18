using System;

namespace N_thBit
{
    class Startup
    {
        static void Main()
        {
            ulong p = ulong.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            int mask = 1 << n;
            ulong nThBit = (p & (ulong)mask) >> n;

            if (nThBit == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                Console.WriteLine(1);
            }

        }

    }
}
