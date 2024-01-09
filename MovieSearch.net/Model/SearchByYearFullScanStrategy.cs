using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.net.Model
{
    internal class SearchByYearFullScanStrategy : ISearchByYearStrategy
    {
        public IEnumerable<Movie> Data { get; set; }    

        public IEnumerable<Movie> SearchByYear(short year)
        {
            return Data.Where(movie => movie.Year == year);
        }
    }
}
