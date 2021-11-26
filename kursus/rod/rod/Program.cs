using Humanizer;
using System;
using System.Globalization;
using System.Text;

namespace rod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int pris = 100;
            DateTime dato = new DateTime(2018, 1, 1);

            string res3 = $"Prisen er {pris:n2} pr {dato:dd-MM-yyyy}";
            Console.WriteLine(res3);

            string a = null;
            Console.WriteLine(a?.ToUpper());     // fejl
            if (a != null)
            {
                Console.WriteLine(a.ToUpper()); // ok
            }

            a += "fdewf";

            if (a != null)
            {
                Console.WriteLine(a.ToUpper()); // ok
            }
            Console.WriteLine(a?.ToUpper()); // ok


            string a1 = null;
            string b = a1 ?? "";
            Console.WriteLine(b.ToUpper());

            StringBuilder test = new();
            test.Append("dwd");
            Console.WriteLine(test.ToString());

            System.Threading.Thread.
                CurrentThread.CurrentUICulture =
                new CultureInfo("da-DK");

            string _a = DateTime.Now.AddDays(-10).Humanize();
            Console.WriteLine(_a);



            Køn køn = Køn.mand;
            
            Console.WriteLine(Convert.ToInt32(køn));

            switch (køn)
            {
                case Køn.mand:
                    break;
                case Køn.kvinde:
                    break;
            }

        }
    }

    enum Køn
    {
        mand,
        kvinde
    }
}



