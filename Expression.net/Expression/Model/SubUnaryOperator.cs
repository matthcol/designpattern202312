using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    public class SubUnaryOperator : AbstractUnaryOperator
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitSubUnaryOperator(this);
        }

        public override string ToString()
        {
            return ".-.";
        }
    }
}
