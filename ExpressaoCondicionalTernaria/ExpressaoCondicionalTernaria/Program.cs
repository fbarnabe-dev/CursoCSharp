using System;
using System.Globalization;

namespace ExpressaoCondicionalTernaria
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t1 = new TimeSpan();
            TimeSpan t2 = new TimeSpan(900000000L);

            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
