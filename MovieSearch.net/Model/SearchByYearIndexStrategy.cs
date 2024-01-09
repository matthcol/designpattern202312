using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.net.Model
{
    internal class SearchByYearIndexStrategy: ISearchByYearStrategy
    {
        public IDictionary<short, IEnumerable<Movie>> IndexByYear { get; set; } = new Dictionary<short, IEnumerable<Movie>>();

        public IEnumerable<Movie> SearchByYear(short year)
        {
            IEnumerable<Movie> res;
            bool ok = IndexByYear.TryGetValue(year, out res);
            return ok ? res : new List<Movie>();
        }
    }
}
