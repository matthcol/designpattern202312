using Expression.Model;
using Expression.Visitor;

Variable x = new Variable()
{
    Name = "x"
};
Variable y = new Variable()
{
    Name = "y"
};
IArithmeticExpression expr = new AddOperator()
{
    LeftOperand = new MulOperator()
    {
        LeftOperand = new SubUnaryOperator()
        {
           Operand = x,
        },
        RightOperand = new Number()
        {
            Value = 12.5
        }
    },
    RightOperand = new DivOperator()
    {
        LeftOperand =  new SubOperator()
        {
            LeftOperand = x,
            RightOperand = y,
        },
        RightOperand = new Number()
        {
            Value = 2.0
        }
    }
};

// Visit Display
DisplayInfixVisitor displayVisitor = new DisplayInfixVisitor();
expr.Accept(displayVisitor);
Console.WriteLine();

foreach(IArithmeticExpression operand in (IOperator) expr){
    operand.Accept(displayVisitor);
    Console.WriteLine();
}

// Visit ToString
InfixToStringVisitor toStringVisitor = new InfixToStringVisitor();
expr.Accept(toStringVisitor);
Console.WriteLine(toStringVisitor.Result);
Console.WriteLine(toStringVisitor.Result);

IDictionary<Variable, double> variableValues = new Dictionary<Variable, double>()
{
    { x, 3.5 },
    { y, 2.0 }
};
ComputeVisitor computeVisitor = new ComputeVisitor()
{
    VariableValues = variableValues
};
// 1st visit
expr.Accept(computeVisitor);
double res = computeVisitor.Result;
Console.WriteLine("Computation: " + variableValues + " => " + res);
// 2nd visit
variableValues[x] = 10.0;
expr.Accept(computeVisitor);
double res2 = computeVisitor.Result;
Console.WriteLine("Computation: " + variableValues + " => " + res);

// TODO: 
// - operators: - / *
// - autre visites:
//      * IArithmeticExpression derivedExpr = expr.Derive(var=x);
//      * string exprStrI = expr.ToStringInfix();
//      * string exprStrP = expr.ToStringPostfix();
