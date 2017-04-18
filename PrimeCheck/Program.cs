using System;

namespace PrimeCheck
{
    class Startup
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (input > 1)
            {
                for (int i = 2; i < input; i++)
                {
                    if (input % i == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
