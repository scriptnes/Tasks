using System;

namespace PointInACircle
{
    class Startup
    {
        static void Main()
        {
            double inputX = double.Parse(Console.ReadLine());
            double inputY = double.Parse(Console.ReadLine());

            double target = 2;
            double x = 0;
            double y = 0;
            double c = 0;
            double a = inputX - x;
            double b = inputY - y;

            c = Math.Sqrt(Math.Pow(a,2) + Math.Pow(b,2));

            if (c > target)
            {
                Console.WriteLine("no {0:0.00}", c);
            }
            else
            {
                Console.WriteLine("yes {0:0.00}", c);
            }          
        }
    }
}
