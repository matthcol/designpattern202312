// See https://aka.ms/new-console-template for more information


IEnumerable<string> cities = new List<string>()
{
    "Toulouse",
    "Pau"
};

IEnumerator<string> itCity = cities.GetEnumerator();
Console.WriteLine(itCity.GetType());

itCity.MoveNext();
Console.WriteLine("City: " + itCity.Current);
itCity.MoveNext();
Console.WriteLine("City: " + itCity.Current);

Console.WriteLine();

foreach (string city in cities)
{
    Console.WriteLine(city);
}