using System;

namespace Strategy
{
    public class ConcreteStrategyC : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteStrategyC.Method()");
        }
    }
}
