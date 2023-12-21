using Expression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Visitor
{
    internal interface IVisitor
    {
        void VisitVariable(Variable variable);
        void VisitNumber(Number number);
        void VisitAddOperator(AddOperator addOperator);
    }
}
