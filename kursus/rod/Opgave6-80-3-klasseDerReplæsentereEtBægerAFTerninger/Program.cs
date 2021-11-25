using System;

namespace Opgave6_80_3_klasseDerReplæsentereEtBægerAFTerninger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Bæger b = new Bæger();
        }




    }

    public class Bæger
    {
        Terning[] Terninger = new Terning[5];

        public Bæger()
        {

            Terninger[0] = new Terning();
            Terninger[1] = new Terning();
            Terninger[2] = new Terning();
            Terninger[3] = new Terning();
            Terninger[4] = new Terning();


            foreach (var item in Terninger)
            {
                item.Ryst();
            }

            skriv();
        }

        public void skriv()
        {
            foreach (var item in Terninger)
            {
                item.Skriv();
            }
        }
    }

    public class Terning
    {
        // Ved .NET Core behøver den ikke være statisk!!
        private static Random rnd = new Random();
        public int værdi;

        public Terning()
        {
            this.værdi = 1;
        }

        public void Skriv()
        {
            Console.Write("[" + this.værdi + "]");
        }

        public void Ryst()
        {
            this.værdi = rnd.Next(1, 7);
        }
    }
}
