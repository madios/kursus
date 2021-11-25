using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var i = System.IO.File.ReadAllText(@"c:\temp\data.csv");
        Console.WriteLine(i);
        var l = i.Split("\r\n");
        List<Person> lst = new List<Person>();
        for (int z = 1; z < l.Length; z++)
        {
            var c = l[z].Split(";");
            Person p = new Person();
            p.Navn = c[0];
            p.Alder = Convert.ToInt32(c[1]);
            p.ErSmart = Convert.ToBoolean(c[2]);
            lst.Add(p);
        }
        var res = lst.OrderBy(i => i.Alder).ToList();

        string jsonOut = System.Text.Json.JsonSerializer.Serialize(res, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
        System.IO.File.WriteAllText(@"c:\temp\data.json", jsonOut);

        string jsonIn = System.IO.File.ReadAllText(@"c:\temp\data.json");
        var lst2 = System.Text.Json.JsonSerializer.Deserialize<List<Person>>(jsonIn);
    }
}

class Person
{
    public string Navn { get; set; }
    public int Alder { get; set; }
    public bool ErSmart { get; set; }
}

