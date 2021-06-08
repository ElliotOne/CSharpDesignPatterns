using System;

namespace Interpreter
{
    public class NonTerminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("NonTerminalExpression.Interpret()");
        }
    }
}
