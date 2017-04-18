using System;

namespace ThirdDigit
{
    class Startup
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int n1 = n / 100;
            int n2 = n1 % 10;

            if (n2 == 7)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false {0}", n2);
            }

           

        }
    }
}
