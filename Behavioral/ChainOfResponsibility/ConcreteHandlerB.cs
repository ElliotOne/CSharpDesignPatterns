using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(object obj)
        {
            Console.WriteLine($"ConcreteHandlerB.HandleRequest(): {obj}");
            Successor?.HandleRequest(obj);
        }
    }
}
