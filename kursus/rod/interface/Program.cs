using System;
using System.Collections.Generic;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            h.Gem();

            UBåd u = new UBåd();
            u.Gem();

            IGem i = new UBåd();
            List<IGem> ting = new List<IGem>();
            ting.Add(new Hund());
            ting.Add(new UBåd());
            foreach (var item in ting)
            {
                item.Skriv(1);
            }

        }
    }

    interface IGem
    {
        void Gem();
        void Skriv(int a);
    }

    class Kasse { }
    class Hund : IGem
    {
        public void Gem()
        {
            Console.WriteLine("Gemmer Hund");
        }

        public void Skriv(int a)
        {
            Console.WriteLine("Skriver Hund");
        }
    }

    class UBåd : IGem
    {
        public void Test() { }
        public void Gem()
        {
            Console.WriteLine("Gemmer Ubåd");
        }

        public void Skriv(int a)
        {
            Console.WriteLine("Skriver Ubåd");
        }
    }


}
