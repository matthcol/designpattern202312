using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.net.Model
{
    internal interface ISearchByYearStrategy
    {
        IEnumerable<Movie> SearchByYear(short year);
    }
}
