using System;

namespace LongSequence
{
    class Startup
    {
        static void Main()
        {
            for (int i = 2; i <= 1001; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine((-1) * i);
                }         
            }
        }
    }
}
