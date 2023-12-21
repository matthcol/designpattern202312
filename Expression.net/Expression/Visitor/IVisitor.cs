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
        void visitVariable(Variable variable);
        void visitNumber(Number number);
        void visitAddOperator(AddOperator addOperator);
    }
}
