using System;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hund h = new Hund()
            {
                Navn = "a",
                AntalBen = 4,
                ErSulten = true,
                Land = "DK"
            };
            Console.WriteLine(h.ToString());

        }
    }

    class Hund
    {

        public string? Navn { get; set; }
        public int AntalBen { get; set; }
        public bool ErSulten { get; set; }
        public string? Land { get; set; }

        public override string ToString()
        {
            string json = System.Text.Json.JsonSerializer.Serialize(this, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            return json;
        }

    }

}
