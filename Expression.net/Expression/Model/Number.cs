using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    internal class Number: IArithmeticExpression
    {
        public double Value { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitNumber(this);
        }

        public void Display()
        {
            Console.Write(Value);
        }
    }
}
