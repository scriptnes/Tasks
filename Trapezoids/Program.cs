using System;

namespace Trapezoids
{
    class Startup
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());

            double Area = ((a + b) * h )/ 2;

            Console.WriteLine("{0:0.0000000}", Area);
            //
        }
    }
}
