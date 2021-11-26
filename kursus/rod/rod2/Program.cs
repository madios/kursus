using System;
using System.Collections.Generic;
using System.Linq;

namespace rod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // nøgle = int, værdi = string
            System.Collections.Generic.Dictionary<string, int> lst = new Dictionary<string, int>();
            lst.Add("a", 1324);
            lst.Add("b", 23);
            lst.Add("c", 113);
            foreach (var item in lst)
            {
                Console.WriteLine($"{item}, {item.Key}, {item.Value}");
            }
            int v = lst["b"];
            Console.WriteLine($"v = {v}");

            Console.WriteLine("Hello World!");

            Metode1("a", 10, true, "DK");
            Metode1(alder: 10, erSmart: true, land: "DK", navn: "a");

            skriv("peter");



            void skriv(string a )
            {
                Console.WriteLine(a);
            }


            (int peter, double aghilas, string String) testTuble;

            testTuble.aghilas = 103;
            testTuble.peter = 10;
            testTuble.String = "per";

        }
        private static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }

    }



        

}


