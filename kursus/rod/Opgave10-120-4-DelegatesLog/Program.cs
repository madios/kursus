using System;

namespace Opgave10_120_4_DelegatesLog
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            Maskine m = new Maskine();
            m.log = Console.WriteLine;
            m.log += AppendLog;
            m.log += AppendLogToConsole;
            m.start();
            m.stop();

        }

        static void AppendLogToConsole(string g)
        {
            Console.WriteLine(g + "din egen app");
        }

        static void AppendLog(string txt)
        {
            // Kræver at c:\temp findes i forvejen!
            System.IO.File.AppendAllText(@"c:\temp\log.txt", txt + "\r\n");
        }
    }
}

class Maskine
{

    public Action<string> log { get; set; }

    public void start()
    {
        log?.Invoke(DateTime.Now.ToString() + "her start vi");
    }
    public void stop()
    {
        log?.Invoke(DateTime.Now.ToString() + "her slutter vi");
    }

}