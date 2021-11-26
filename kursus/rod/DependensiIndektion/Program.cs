using System;
using System.Collections.Generic;
using System.Net;

namespace Test2
{
    internal class Program
    {
        static void Main(string[] args)
        {







            //Hund h = new Hund();
            //h.Gem();

            //UBåd u = new UBåd();
            //u.Gem();

            //IGem i = new UBåd();
            //List<IGem> ting = new List<IGem>();
            //ting.Add(new Hund());
            //ting.Add(new UBåd());
            //foreach (var item in ting)
            //{
            //    item.Skriv(1);
            //}


            Terning t = new Terning();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(t.Værdi);
                t.Ryst();
            }
        }
    }

    class TilfældighedsGeneratorSaturn : ITilfældighedsGenerator
    {
        public int TilfældigTal(int min, int max)
        {
            using (WebClient w = new WebClient())
            {
                string s = w.DownloadString("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
                return Convert.ToInt32(s);
            }
        }
    }

    class TilfældighedsGeneratorMock : ITilfældighedsGenerator
    {
        public int TilfældigTal(int min, int max)
        {
            return 6;
        }
    }

    class Terning
    {
        public int Værdi { get; private set; }
        private ITilfældighedsGenerator rnd;
        public Terning()
        {
            this.rnd = new TilfældighedsGeneratorRandom();
            Ryst();

        }
        public Terning(ITilfældighedsGenerator r)
        {
            this.rnd = r;
            Ryst();
        }
        public void Ryst()
        {
            this.Værdi = rnd.TilfældigTal(1, 7);
        }
    }

    interface ITilfældighedsGenerator
    {
        int TilfældigTal(int min, int max);
    }

    class TilfældighedsGeneratorRandom : ITilfældighedsGenerator
    {
        private Random rnd = new Random();
        public int TilfældigTal(int min, int max)
        {
            return rnd.Next(min, max);
        }
    }



    class Kunde : IDisposable
    {
        public Kunde()
        {
            Console.WriteLine("Jeg fødes");
        }

        public void Dispose()
        {
            Console.WriteLine("Jeg dør");
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
