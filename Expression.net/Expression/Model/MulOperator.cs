using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    public class MulOperator : AbstractBinaryOperator
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitMulOperator(this);
        }

        public override string ToString()
        {
            return "*";
        }
    }
}
