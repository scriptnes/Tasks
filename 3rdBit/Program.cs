using System;

namespace _3rdBit
{
    class Startup
    {
        static void Main()
        {

            int digit = int.Parse(Console.ReadLine());

            int mask = 1 << 3;
            int _3rdBit = (digit & mask) >> 3;

            if (_3rdBit == 0)
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
