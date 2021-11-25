using System;

namespace opgave4_60_5_RekursiveMetoder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            visFiler(@"C:\kursus\github\kursus\rod");


            static void visFiler(string sti)
            {
                var filer = System.IO.Directory.GetFiles(sti);
                foreach (var fil in filer)
                {
                    Console.WriteLine(fil + "  (fil)");
                    var mapper = System.IO.Directory.GetDirectories(sti);
                    foreach (var mappe in mapper)
                    {
                        Console.WriteLine(mappe + "  (mappe)");
                        visFiler(mappe);
                    }

                }

            }

        }
    }
}
