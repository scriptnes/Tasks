using System;

namespace LongSequence
{
    internal class Startup
    {
        private static void Main()
        {
            for (var i = 2; i <= 1001; i++)
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
