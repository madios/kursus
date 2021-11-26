using System;

namespace TestNull
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TestNullHello World!");

            Person person = new Person();
            person.Navn = null;
            
            if (person.Navn != null)
            {
                string s = person.Navn.ToUpper();
            }

            //var a = person.Navn.ToUpper();

            //string? a; //nullable<bool> f; kan være null
            //Console.WriteLine(  a);
        }
    }

    class Person
    {
        public string Navn;

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public string peter { get; set; }

    }
}
