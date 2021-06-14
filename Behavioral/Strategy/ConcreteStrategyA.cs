using System;

namespace Strategy
{
    public class ConcreteStrategyA : Strategy
    {
        public override void Method()
        {
            Console.WriteLine("ConcreteStrategyA.Method()");
        }
    }
}
