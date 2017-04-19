using System;

namespace Rectangles
{
    class Startup
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double area = width * height;
            double perimeter = (width * 2) + (height * 2);

            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }

    }
}
