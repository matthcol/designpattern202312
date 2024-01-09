// some data
using MovieSearch.net.Model;

Random rand = new();

IList<Movie> data = new List<Movie>();
short startYear = 1888;
for (int i = 0; i < 15000; i++)
{
    short deltaYear = (short)(rand.NextInt64(150));
    Movie movie = new()
    {
        Title = string.Format("Rambo {0}", i),
        Year = (short)(startYear + deltaYear)
    };
    data.Add(movie);
}

short year = 2023;

// search with Linq
IList<Movie> selection = data.Where(movie => movie.Year == year)
    .ToList();
Console.WriteLine(selection.Count);
foreach (Movie movie in selection)
{
    Console.WriteLine(movie);
}
Console.WriteLine();


ISearchByYearStrategy searchStrategy = new SearchByYearFullScanStrategy() // TODO: singleton
{
    Data = data
};


// search wih strategy: iterate over whole collection
IEnumerable<Movie> selection2 = searchStrategy.SearchByYear(year);
Console.WriteLine(selection2.Count());
foreach (Movie movie in selection2)
{
    Console.WriteLine(movie);
}
Console.WriteLine();

// search wih strategy: search by index
IDictionary<short, IEnumerable<Movie>> index = new Dictionary<short, IEnumerable<Movie>>();
foreach(Movie movie in data)
{
    if (index.ContainsKey(movie.Year))
    {
        ((IList<Movie>) index[movie.Year]).Add(movie);
    } else
    {
        index.Add(movie.Year, new List<Movie>() { movie });
    }
}
searchStrategy = new SearchByYearIndexStrategy()
{
    IndexByYear = index
};
IEnumerable<Movie> selection3 = searchStrategy.SearchByYear(year);
Console.WriteLine(selection3.Count());
foreach (Movie movie in selection3)
{
    Console.WriteLine(movie);
}
Console.WriteLine();

