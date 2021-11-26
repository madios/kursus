using System;

namespace Opgave1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo("en-US");
            Console.WriteLine("Indtast 1");
            string tal1 = Console.ReadLine();
            Console.WriteLine("Indtast 2");
            string tal2 = Console.ReadLine();
            double dTal1 = Convert.ToDouble(tal1);
            double dTal2 = Convert.ToDouble(tal2);
            double dTal3 = dTal1 + dTal2;
            Console.WriteLine(dTal3.ToString("N2"));
        }
    }
}
