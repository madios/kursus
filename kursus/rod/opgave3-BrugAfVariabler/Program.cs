using System;

namespace opgave3_BrugAfVariabler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            værdi kort1Værdi = værdi.n2 ;
            kortKulør kort1Kulør = kortKulør.Hjerter;

            værdi kort2Værdi = værdi.n2;
            kortKulør kort2Kulør = kortKulør.Ruder;

            kortNummer kn = new();

            kn.Setkort(værdi.n2, kortKulør.Hjerter);
            kn.Setkort(værdi.n2, kortKulør.Ruder);

            Console.WriteLine(kn.getKortKulør().ToString());
        }
    }

    public class kortNummer
    {
        værdi kort1Værdi = værdi.n1;
        kortKulør kort1Kulør = kortKulør.Ruder;

        public void Setkort(værdi v, kortKulør kk) 
        { 
            kort1Værdi = v; 
            kort1Kulør = kk; 
        }

        public værdi getKortVærdi() { return kort1Værdi; }
        public kortKulør getKortKulør() { return kort1Kulør; }

    }

    public enum kortKulør
    {
        Spar,
        Hjerter,
        Ruder,
        Klør
    }
    public enum værdi
    {
        n1,
        n2,
        n4,
        n5,
        n6,
        n7,
        n8,
        n9,
        knækt,
        dame,
        konge,
        Es,
        joker


    }
}
