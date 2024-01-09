using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSearch.net.Model
{
    internal class Movie
    {
        public string Title { get; set; }
        public short Year { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}",Title, Year);
        }

    }
}
