using Expression.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression.Visitor
{
    internal class ComputeVisitor : IVisitor
    {
        public IDictionary<Variable, double> VariableValues { get; set; } = new Dictionary<Variable, double>();
        
        public double Result { get; private set; }
        
        public void VisitAddOperator(AddOperator addOperator)
        {
            addOperator.LeftOperand.Accept(this);
            double left = Result;
            addOperator.RightOperand.Accept(this);
            Result += left; 
        }

        public void VisitNumber(Number number)
        {
            Result = number.Value;
        }

        public void VisitVariable(Variable variable)
        {
            Result = VariableValues[variable];
        }
    }
}
