using System;
using System.Linq;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Simpel liste...
            int[] tal = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };

            var mappe = new System.IO.DirectoryInfo(@"c:\temp");
            var filer = mappe.GetFiles("*.*", System.IO.SearchOption.AllDirectories);

            //var res1 = from t in tal where t < 7 orderby t select t;

            var res1 = tal.Where(t => t < 7).OrderByDescending(i => i);

            foreach (var item in res1)
            {
                Console.WriteLine(item);
            }

            var res2 = tal.Where(t => t < 7);
            var res3 = res2.OrderByDescending(i => i).ToList(); // laver den om til tal med det samme,


            var res5 = filer.Where(i => i.Extension == ".cs");
            foreach (var f in res5)
            {
                Console.WriteLine(f.FullName);

            }

            var res4 = filer.Where(i => i.Extension == ".cs" && i.Length < 100 && DateTime.Now.DayOfWeek == DayOfWeek.Friday);
            foreach (var f in res4)
            {
                Console.WriteLine(f.FullName);
            }


            var res = filer.Where(i => i.Extension == ".cs" && i.Length < 1000 && DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                .OrderBy(i => i.Length).ThenBy(i => i.Name);

            foreach (var f in res)
            {
                Console.WriteLine(f.FullName + " " + f.Length);
            }

            var res10 = filer.Where(i => i.Length > 1000);

            foreach (var f in res10)
            {
                Console.WriteLine(f.FullName + " " + f.Length);
            }

            var res11 = filer.Where(i => i.Length > 1000).Select(i => new MinFil { Navn = i.Name, Længde = i.Length }).ToList();

            foreach (var f in res11)
            {
                Console.WriteLine(f.Navn + " " + f.Længde);
            }

            var res12 = filer.Where(i => i.Length > 1000).Select(i => new { Navn = i.Name, Længde = i.Length }).ToList(); // så behøver du ikke lave en klasse

            foreach (var f in res12)
            {
                Console.WriteLine(f.Navn + " " + f.Længde);
            }


            var res13 = filer.Where(i => i.Length > 100)
                .GroupBy(i => i.Extension);

            foreach (var f in res13)
            {
                Console.WriteLine(f.Key);
                foreach (var item in f)
                {
                    Console.WriteLine("\t" + item.FullName);
                }
            }
        }
    }

    class MinFil
    {
        public string Navn { get; set; }
        public long Længde { get; set; }
    }
}
