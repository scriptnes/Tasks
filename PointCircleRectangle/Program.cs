using System;

namespace PointCircleRectangle
{
    internal class Startup
    {
        private static void Main()
        {
            var inputX = double.Parse(Console.ReadLine());
            var inputY = double.Parse(Console.ReadLine());
            const double circleRad = 1.5;
            const int xO = 1;
            const int yO = 1;
            var c = 0;
            
            c = (int) Math.Sqrt(Math.Pow(inputX-xO, 2) + Math.Pow(inputY-yO, 2));
            var isInCircle = (c <= circleRad);
            var isInRectangle = (inputX >= -1 && inputX <= 5) && (inputY >= -1 && inputY <= 1);    

            if (isInCircle)
            {
                Console.WriteLine(isInRectangle ? "inside circle inside rectangle" : "inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine(
                    isInRectangle ? "outside circle inside rectangle" : "outside circle outside rectangle");
            }

        }

    }
}
