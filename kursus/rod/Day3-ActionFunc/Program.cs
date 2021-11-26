using System;

namespace DelegatesDemo
{


    internal class Program
    {
        static void Main(string[] args)
        {

            // Action    = void
            // Func      = Function
            // Predicate = bool ... (T)

            Action d1 = Console.Beep;
            Action<string> d2 = Console.WriteLine;
            d1.Invoke();
            d2.Invoke("***");

            Func<int, int, int> d3 = Math.Max;
            Console.WriteLine(d3(5, 1));

            Predicate<int> d4 = Test;
            Console.WriteLine(Test(1));

            bool Test(int a)
            {
                return a == 4;
            }

            int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //samme
            System.Array.ForEach(array, Console.WriteLine);
            //samme
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.WriteLine(System.Array.FindIndex(array, Test));


        }
    }
}
