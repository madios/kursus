using System;
using System.Threading.Tasks;

namespace MinTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try
            {
                int tal = await FindTal();
                Console.WriteLine(tal);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        static Task<int> FindTal()
        {
            Task<int> t = Task<int>.Run(() => {
                System.Random r = new Random();
                // simulerer en fejl
                throw new ApplicationException("Hov - fejl i FindTal");
                return r.Next(1, 101);
            });
            return t;
        }
    }
}
