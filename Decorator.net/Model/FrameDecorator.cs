using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.net.Model
{
    internal class FrameDecorator : AbstractPaintDecorator
    {
        public string Color { get; set; }
        public override string Visual()
        {
            return string.Format("Frame({0})[{1}]", 
                Color,
                DecoratedPaint.Visual()
            );
        }
    }
}
