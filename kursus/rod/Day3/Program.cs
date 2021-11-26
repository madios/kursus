using System;

namespace Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund();
            h.Navn = "Test";
            Console.WriteLine(h.ToString());

        }
    }

    class Hund
    {

        public string? Navn { get; set; }

        public override string ToString()
        {
            return "* **************************";
        }

    }
}
