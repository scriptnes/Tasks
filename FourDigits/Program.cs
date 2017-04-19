using System;

namespace FourDigits
{
    class Startup
    {
        static void Main()
        {
            string number = Console.ReadLine();
            char[] numberAsChar = number.ToCharArray();
            int sum = 0;
            string[] d = new string[number.Length];

            for (int i = 0; i < number.Length; i++)
            {
                sum += numberAsChar[i] - '0'; 
                d[i] = numberAsChar[i].ToString();
            }
            Console.WriteLine(sum);
            Console.WriteLine(d[3] + d[2] + d[1] + d[0]);
            Console.WriteLine(d[3] + d[0] + d[1] + d[2]);
            Console.WriteLine(d[0] + d[2] + d[1] + d[3]);
        }
    }
}
