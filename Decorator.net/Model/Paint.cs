using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.net.Model
{
    internal class Paint : IPaint
    {
        public string Content { get; set; } = "";

        public string Visual()
        {
            return string.Format("Paint[{0}]", Content);
        }
    }
}
