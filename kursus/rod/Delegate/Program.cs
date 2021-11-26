using System;

namespace DelegatesDemo
{
    internal class Program
    {

        public delegate void MinDeletage1();

        public delegate int MinDeletage2(int a, int b);

        static void Main(string[] args)
        {
            //// Direkte
            //Test1();

            //// Inddirekte
            //MinDeletage1 d1 = new MinDeletage1(Test1);
            //d1.Invoke();

            //// Gennem metode
            //KørMig(1, true, d1);

            //MinDeletage1 d2 = FindDelegate();
            //d2.Invoke();

            Maskine maskine = new Maskine();
            //maskine.LogFunktion = new LogDelegate(Gem);
            maskine.LogFunktion = Gem;
            maskine.LogFunktion += Skriv;
            maskine.LogFunktion += Console.WriteLine;
            maskine.LogFunktion += Console.Write;
            maskine.Start();
            maskine.Stop();

            Console.WriteLine();
            MinDeletage2 d2 = new MinDeletage2(LægSammen);
            d2 += Math.Min;
            Console.WriteLine(d2.Invoke(2, 1));
            foreach (MinDeletage2 item in d2.GetInvocationList())
            {
                Console.WriteLine(item.Invoke(2, 1));
            }

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }
        static void Skriv(string d)
        {
            Console.WriteLine("----" + d);
        }

        static void Gem(string d)
        {
            System.IO.File.AppendAllText(@"c:\temp\log.txt", d + "\r\n");
        }


        static void KørMig(int a, bool b, MinDeletage1 f)
        {
            // ældskfjlædskjgfj 
            f.Invoke();



        }

        static MinDeletage1 FindDelegate()
        {
            return new MinDeletage1(Test1);
        }

        static void Test1()
        {
            Console.WriteLine("Test1");
        }
    }

    public delegate void LogDelegate(string txt);

    class Maskine
    {

        public LogDelegate LogFunktion = null;

        public void Start()
        {
            Log("Jeg starter");
        }
        public void Stop()
        {
            Log("Jeg stopper");
        }
        private void Log(string txt)
        {
            //Console.WriteLine(DateTime.Now.ToLongTimeString() + " " + txt);
            if (LogFunktion != null)
                LogFunktion.Invoke(DateTime.Now.ToLongTimeString() + " " + txt);
                //LogFunktion(DateTime.Now.ToLongTimeString() + " " + txt);
        }

    }


}
