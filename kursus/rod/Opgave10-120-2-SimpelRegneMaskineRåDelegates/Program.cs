using System;

namespace Opgave10_120_2_SimpelRegneMaskineRåDelegates
{
    internal class Program
    {

        public delegate int r1(int tal1, int tal2);
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            
            RegnemaskineApp.RegnemaskineConsoleUI r =  new RegnemaskineApp.RegnemaskineConsoleUI();
            //r += TilføjBeregning("minus", new RegnemaskineApp.RegnemaskineConsoleUI());
            r.TilføjBeregning("Minus", new RegnemaskineApp.BeregnDelegate(Minus));
            r.Start();
        }

        public static int Minus(int tal1, int tal2)
        { 
            return tal1 - tal2;
        }
    }
}


namespace RegnemaskineApp
{
    using System;
    using System.Collections.Generic;

    public delegate int BeregnDelegate(int tal1, int tal2);

    public class RegnemaskineConsoleUI
    {
        private Dictionary<string, BeregnDelegate> beregninger { get; set; }

        public RegnemaskineConsoleUI()
        {
            beregninger = new Dictionary<string, BeregnDelegate>();
            TilføjBeregning("plus", (a, b) => a + b);
        }

        public void TilføjBeregning(string navn, BeregnDelegate funktion)
        {
            beregninger.Add(navn.ToLower(), funktion);
        }

        public void Start()
        {
            try
            {
                do
                {
                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("REGNEMASKINE");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine("------------");
                    Console.WriteLine();
                    Console.WriteLine("Skriv navnet på en af følgende beregninger:");
                    foreach (var item in beregninger)
                    {
                        Console.WriteLine(" - " + item.Key);
                    }
                    Console.WriteLine();
                    string b = Console.ReadLine().ToLower();
                    if (!beregninger.ContainsKey(b))
                    {
                        Console.WriteLine("Beregning findes ikke");
                        return;
                    }
                    var beregning = beregninger[b];
                    Console.WriteLine("Indtast tal1:");
                    string tal1s = Console.ReadLine();
                    Console.WriteLine("Indtast tal2:");
                    string tal2s = Console.ReadLine();
                    int tal1 = Convert.ToInt32(tal1s);
                    int tal2 = Convert.ToInt32(tal2s);
                    int res = beregning(tal1, tal2);
                    Console.WriteLine("Resultatet er:");
                    Console.WriteLine(res);
                    Console.WriteLine("Tryk Esc for at afbryde eller en anden tast for at foretage ny beregning");
                    var tast = Console.ReadKey();
                    if (tast.Key == ConsoleKey.Escape)
                        break;

                } while (true);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Hov - der er sket en fejl (" + ex.Message + ")");
                return;
            }
        }
    }
}