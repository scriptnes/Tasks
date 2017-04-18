using System;

namespace Age
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int inputToInt = int.Parse(input.Substring(6));
            int yearOld = 2016 - inputToInt;
            int afterTen = yearOld + 10;
            Console.WriteLine(yearOld);
            Console.WriteLine(afterTen);

        }
    }
}
