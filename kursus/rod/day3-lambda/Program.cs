using System;
using System.Linq;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Test1();
            Action d1 = Test1;
            Action d11 = () => { Console.WriteLine("Test1"); }; //"er det samme som test1"
            Action d12 = () => Console.WriteLine("Test1");

            Test2("a");
            //Action<string> d21 = (string a) => { Console.WriteLine("Test2 " + a); };
            //Action<string> d22 = a => { Console.WriteLine("Test2 " + a); };
            Action<string> d23 = a => Console.WriteLine("Test2 " + a);

            Test3("a", 1);
            Action<string, int> d31 = (string a, int b) => { Console.WriteLine("Test3 " + a + b); };
            Action<string, int> d32 = (a, b) => Console.WriteLine("Test3 " + a + b);

            d32("**", 52);

            int f = Test4();
            //Func<int> f1 = () => { return 1; };
            Func<int> f1 = () => 1;
            Console.WriteLine(f1());

            int g = Test5(5);

            //Func<int, int> f2 = (int a) => { return a * 2; };
            //Func<int, int> f2 = a => { return a * 2; };
            Func<int, int> f2 = a => a * 2;


            Console.WriteLine(f2(2));

            bool gg = Test6(4);
            //Func<int, bool> f3 = (int a) => { return a % 2 == 0; };
            //Func<int, bool> f3 = tal => { return tal % 2 == 0; };
            Func<int, bool> f3 = tal => tal % 2 == 0;

            Console.WriteLine();


            int[] vs = { 1, 2, 3, 4 };
            //var t = vs.Where((int a) => a < 3);
            var t = vs.Where(t => t < 3);

            Action p1 = () => Console.WriteLine("test1Peter");

            Action<string> p2 = a => Console.WriteLine("test1Peter" + a);
            p1.Invoke();

        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }
        static void Test2(string a)
        {
            Console.WriteLine("Test2 " + a);

        }
        static void Test3(string a, int b)
        {
            Console.WriteLine("Test3 " + a + b);
        }
        static int Test4()
        {
            return 1;
        }

        static int Test5(int a)
        {
            return a * 2;
        }

        static bool Test6(int a)
        {
            return a % 2 == 0;
        }

    }
}
