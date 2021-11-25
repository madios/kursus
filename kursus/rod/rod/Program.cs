using System;
using System.Linq;

namespace rod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var ge  = Test();

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

            double dReturn = test();
            int ireturn = test1();
        }

        static (int v1, bool v2) Test()
        {
            if(DateTime.Now.Millisecond % 2 == 0)
            {
                return ( 1, true);
            }

            //return (1, true);
            int fkfe = 0;
            Console.WriteLine(fkfe);




            return (1, true);

        } // return 


        static void Metode1(string navn, int alder, bool erSmart, string land)
        {
        }

        
        static void visFiler(string sti)
        {
            //...;
            //se alle filer i folder

        }

        static int test2()
        {
            return 3;
        }
        static double test2()
        {
            return 0.3;
        }

    }
}
