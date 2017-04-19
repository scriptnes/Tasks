using System;

namespace PointCircleRectangle
{
    class Startup
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double R = 1.5;
            double xO = 1;
            double yO = 1;
            double c = 0;
            
            c = Math.Sqrt(Math.Pow(x-xO, 2) + Math.Pow(y-yO, 2));
            bool isInCircle = (c <= R);
            bool isInRectangle = (x >= -1 && x <= 5) && (y >= -1 && y <= 1);    

            if (isInCircle)
            {
                if (isInRectangle)
                {
                    Console.WriteLine("inside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("inside circle outside rectangle");
                }
            }
            else
            {
                if (isInRectangle)
                {
                    Console.WriteLine("outside circle inside rectangle");
                }
                else
                {
                    Console.WriteLine("outside circle outside rectangle");
                }
            }

        }

    }
}
