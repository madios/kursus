using System;
using System.Collections.Generic;
using System.Linq;

namespace Opgave150_2_LinqMedObjecter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------Uden Order-------");
            var fakturaer = Faktura.HentFakturaer();
            fakturaer.ForEach(x => Console.WriteLine(x));

           
            //var lst = fakturaer.OrderBy(i => i.Kunde).ToList();
            //lst.ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("--------efter navn-------");
            fakturaer.OrderBy(i => i.Kunde).ToList().ForEach(x => Console.WriteLine(x));
            Console.WriteLine();
            Console.WriteLine("-------efter Dato---------");
            fakturaer.OrderBy(i => i.Dato).ToList().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("-------kun fyn efter Dato---------");
            //fakturaer.Select(i => i.Region == "Fyn").OrderBy(i => i.Dato).ToList().ForEach(x => Console.WriteLine(x));
            //fakturaer.Select(i => new Faktura{ i.Region == "Fyn" }).ToList().ForEach(x => Console.WriteLine(x));
            fakturaer.Where(i => i.Region == "Fyn").OrderBy(i => i.Dato).ToList().ForEach(x => Console.WriteLine(x));
            //var res12 = filer.Where(i => i.Length > 1000).Select(i => new { Navn = i.Name, Længde = i.Length }).ToList(); // så behøver du ikke lave en klasse
            
            Console.WriteLine();
            Console.WriteLine("Antal Fyn: " + fakturaer.Where(i => i.Region == "Fyn").OrderBy(i => i.Dato).ToList().Count());

            // Antal på Fyn
            Console.WriteLine();
            Console.WriteLine(fakturaer.Count(f => f.Region == "Fyn"));

            // Samlet salg
            Console.WriteLine();
            Console.WriteLine(fakturaer.Sum(f => f.Salg).ToString("N2"));

            // Samlet salg på Fyn
            Console.WriteLine();
            Console.WriteLine(fakturaer.Where(i => i.Region == "Fyn").Sum(f => f.Salg).ToString("N2"));
        }
    }

    class Faktura
    {

        public DateTime Dato { get; set; }
        public int Nummer { get; set; }
        public string Kunde { get; set; }
        public string Region { get; set; }
        public double Salg { get; set; }

        public static List<Faktura> HentFakturaer()
        {

            List<Faktura> lst = new List<Faktura> {
            new Faktura{ Dato = new DateTime(2020,7,1), Nummer = 1, Kunde ="Jens", Region = "Fyn", Salg = 100 },
            new Faktura{ Dato = new DateTime(2020,5,1), Nummer = 2, Kunde ="Anders", Region = "Fyn", Salg = 300 },
            new Faktura{ Dato = new DateTime(2021,1,1), Nummer = 3, Kunde ="Mette", Region = "Sjælland", Salg = 150 },
            new Faktura{ Dato = new DateTime(2020,12,1), Nummer = 4, Kunde ="Hans", Region = "Jylland", Salg = 900 },
        };
            return lst;
        }

        public override string ToString()
        {
            return $"{Dato.ToShortDateString()} {Nummer} {Kunde} ({Region})";
        }
    }
}
