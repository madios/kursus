using System;

namespace opgave8_90_5_AutomatiskeEgenskaber_terning_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            terning t1 = new terning();

            Console.WriteLine(t1.Værdi);
            t1.skriv();

            terning.

        }
    }

    public class terning
    {

        public int Værdi { get; private set; }

        public void setVærdi(int t) { Værdi = t; }

        public void ryst()
        {
            System.Random rnd = new Random();
            this.Værdi = rnd.Next(1, 7);
        }

        public void skriv()
        {
            Console.WriteLine("["+Værdi+"]");
        }

        public terning()
        {
            ryst();
        }

        public terning(int værdi)
        {
            if (værdi > 6 || værdi < 1)
            {
                Værdi = 1;
            }
            else
            {
                Værdi = Værdi;
            }
        }
          
    }
}
