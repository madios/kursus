using System;

namespace Opgave7_90_1_TerningMedEgenskaber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Terning t1 = new Terning();

            t1.Værdi = 0;
            t1.skriv();


        }
    }

    public class Terning
    {

        private int værdi;

        public int Værdi
        {
            get { 
                return værdi; 
            
            }
            set { 
                if(value > 6 || value < 1)
                {
                    værdi = 1;
                }
                else
                {
                    værdi = value;
                }
            }
        }
        public void Ryst()
        {
            System.Random rnd = new Random();
            this.værdi = rnd.Next(1, 7);
        }
        public void skriv()
        {
            Console.WriteLine("["+værdi+"]");
        }

    }
}
