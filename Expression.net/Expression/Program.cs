using Expression.Model;
using Expression.Visitor;

Variable x = new Variable()
{
    Name = "x"
};
IArithmeticExpression expr = new AddOperator()
{
    LeftOperand = x,
    RightOperand = new Number()
    {
        Value = 12.5
    }
};

expr.Display();
Console.WriteLine();

IDictionary<Variable, double> variableValues = new Dictionary<Variable, double>()
{
    { x, 3.5 }
};
ComputeVisitor computeVisitor = new ComputeVisitor()
{
    VariableValues = variableValues
};
// 1st visit
expr.Accept(computeVisitor);
double res = computeVisitor.Result;
Console.WriteLine("Computation: " + res);
// 2nd visit
variableValues[x] = 10.0;
expr.Accept(computeVisitor);
double res2 = computeVisitor.Result;
Console.WriteLine("Computation: " + res2);

// TODO: 
// - operators: - / *
// - autre visites:
//      * IArithmeticExpression derivedExpr = expr.Derive(var=x);
//      * string exprStrI = expr.ToStringInfix();
//      * string exprStrP = expr.ToStringPostfix();
