using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    internal class Variable: IArithmeticExpression
    {
        public string Name { get; set; } = "?";

        public void Accept(IVisitor visitor)
        {
            visitor.VisitVariable(this);
        }

        public void Display()
        {
            Console.Write(Name);
        }
    }
}
