using System;
using System.Threading.Tasks;

namespace MinTest
{
    internal class Program
    {
        private static readonly System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient();

        private async static Task Main(string[] args)
        {
            string antalTxt = await httpClient.GetStringAsync("https://www.random.org/integers/?num=1&min=1&max=6&col=1&base=10&format=plain&rnd=new");
            int antal = Convert.ToInt32(antalTxt);
            string stjerner = new string('*', antal);
            await System.IO.File.WriteAllTextAsync(@"c:\temp\stjerner.txt", stjerner);
            Console.WriteLine($"Der er gemt {antal} stjerne{(antal > 1 ? "r" : "")} i c:\\temp\\stjerner.txt");
        }
    }
}