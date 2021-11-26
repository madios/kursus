using System;

namespace Opgave9_120_1_SimpleOpgaveIDelegate
{
    internal class Program
    {
        public delegate void MinDelegate1(string txt);

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MinDelegate1 f1 = new MinDelegate1(MinSkrivTilConsole);

            f1.Invoke("test");

            MinDelegate1 f2 = MinSkrivTilConsole;

            f2("test1");

            MinDelegate1 f3 = MinSkrivTilConsole;

            f3 += MinSkrivTilConsole2;

            f3("test4");


            f1 -= MinSkrivTilConsole;
            f2 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole;
            f3 -= MinSkrivTilConsole2;


        }



        static void MinSkrivTilConsole(string txt)
        {
            Console.WriteLine("**** " + txt + " ****");
        }

        static void MinSkrivTilConsole2(string txt)
        {
            Console.WriteLine("**** £" + txt + "£ ****");
        }
    }
}
