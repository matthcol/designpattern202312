using Expression.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Model
{
    public class DivOperator : AbstractBinaryOperator
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.VisitDivOperator(this);
        }

        public override string ToString()
        {
            return "/";
        }
    }
}
