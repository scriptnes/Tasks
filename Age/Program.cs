using System;

namespace Age
{
    internal class Startup
    {
        private static void Main()
        {
            var input = Console.ReadLine();
            if (input == null) return;
            var inputToInt = int.Parse(input.Substring(6));
            var yearOld = 2016 - inputToInt;
            var afterTen = yearOld + 10;
            Console.WriteLine(yearOld);
            Console.WriteLine(afterTen);
        }
    }
}
