using System;

class Program
{
    static void Main(string[] args)
    {
        // reflection
        Person person = new Person() { Navn = "ælkæ" };
        //Person person = new Person() { Navn = "ælkæ" };
        //person.Navn = "ældw";
        var r = person.GetType().GetMethods(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
        foreach (var f in r)
        {
            Console.WriteLine(f.Name);
        }
        Console.WriteLine(  "new line  \n\n\n" );
        var r1 = person.GetType().GetFields(System.Reflection.BindingFlags.Instance |
           System.Reflection.BindingFlags.NonPublic);
        foreach (var f in r)
        {
            Console.WriteLine(f.Name);
        }




    }
}

class Person
{
    //private string navn;

    //public string Navn
    //{
    //    get { return navn; }
    //    set { navn = value; }
    //}

    public string Navn { get; set; }

    public int Alder { get; set; }

    public bool ErSmart { get; set; }

    public void Skriv()
    {
        Navn = "lkjsælkdj";
        Console.WriteLine(this.Navn);
    }


    class Terning
    {
        public int Værdi { get; init; }
    }
}

class Person2
{
    //private string navn;

    //public string Navn
    //{
    //    get { return navn; }
    //    set { navn = value; }
    //}

    public string Navn { get; set; }

    public int Alder { get; set; }

    public bool ErSmart { get; set; }

}