using System;

namespace Strategy
{
    public class ConcreteStrategyB : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteStrategyB.Method()");
        }
    }
}
