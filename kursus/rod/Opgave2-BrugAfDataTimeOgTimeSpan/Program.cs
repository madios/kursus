using System;

namespace Opgave2_BrugAfDataTimeOgTimeSpan
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DateTime d1 = DateTime.Now;

            Console.WriteLine( d1.ToString());

            d1 = d1.AddDays(10);

            Console.WriteLine( d1.ToString() );

            d1 = d1.AddMinutes(20);

            Console.WriteLine(d1.ToString());

            d1 = d1.AddMonths(-1);

            Console.WriteLine(d1.ToString());

            /*
            DateTime d4 = d2.Subtract(d3);
            Console.WriteLine( d4.ToString("dd") );
            int pris = 100;
*/            Console.WriteLine("Hello World!");
        }
    }
}
