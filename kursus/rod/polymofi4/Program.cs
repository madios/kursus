using System;
using System.Collections.Generic;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hund h = new Hund()
            //{
            //    Navn = "a",
            //    AntalBen = 4,
            //    ErSulten = true,
            //    Land = "DK"
            //};
            //Console.WriteLine(h.ToString());
            //h.SigNoget();

            //GravHund g = new GravHund()
            //{
            //    Navn = "b",
            //    AntalBen = 3,
            //    ErSulten = false,
            //    LaengdePaaBen = 2,
            //    Land = "SE"
            //};
            //Console.WriteLine(g);
            //g.SigNoget();



            //List<GravHund> l1 = new List<GravHund>();
            //l1.Add(new GravHund() { Navn = "a" });
            //l1.Add(new GravHund() { Navn = "b" });
            //List<Puddel> l2 = new List<Puddel>();
            //l2.Add(new Puddel() { Navn = "c" });
            //l2.Add(new Puddel() { Navn = "d"});

            //foreach (var item in l1)
            //    Console.WriteLine(item);
            //foreach (var item in l2)
            //    Console.WriteLine(item);

            List<Hund> l1 = new List<Hund>();
            l1.Add(new GravHund() { Navn = "a" });
            l1.Add(new GravHund() { Navn = "b" });
            l1.Add(new Puddel() { Navn = "c" });
            l1.Add(new Puddel() { Navn = "d" });

            foreach (var item in l1)
            {
                Console.WriteLine(item.ToString());
            }


        }
    }

    abstract class Hund
    {

        public string? Navn { get; set; }
        public int AntalBen { get; set; }
        public bool ErSulten { get; set; }
        public string? Land { get; set; }

        public override string ToString()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            return json;
        }

        public abstract void SigNoget();
    }

    class GravHund : Hund
    {
        public int LaengdePaaBen { get; set; }


        public override string ToString()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            return json;
        }

        public override void SigNoget()
        {
            Console.WriteLine("Grrr Vov");
        }
    }

    class Puddel : Hund
    {
        public override void SigNoget()
        {
            Console.WriteLine("... vov");
        }
    }

}
