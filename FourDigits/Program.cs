using System;

namespace FourDigitsExchanges
{
    class Startup
    {
        static void Main()
        {
            var number = Console.ReadLine();
            if (number == null) return;
            var numberAsChar = number.ToCharArray();
            var sum = 0;
            var d = new string[number.Length];

            for (var i = 0; i < number.Length; i++)
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
