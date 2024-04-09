Dictionary<int, string> nombres = new Dictionary<int, string>();

nombres.Add(0, "Ximenita");
nombres.Add(1, "Pablito");
nombres.Add(2, "Felipito");
nombres.Add(30, "Juanpa");

foreach(var name in nombres)
{
    Console.WriteLine($"{name.Key}. {name.Value}");
}

nombres.Remove(30);
Console.WriteLine("\n");

foreach (var name in nombres)
{
    Console.WriteLine($"{name.Key}. {name.Value}");
}

Console.WriteLine("\n");
var nameFind = nombres.FirstOrDefault(x => x.Value == "Felipito");
Console.WriteLine($"{nameFind.Key}. {nameFind.Value}");