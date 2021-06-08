using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(object obj)
        {
            Console.WriteLine($"ConcreteHandlerA.HandleRequest(): {obj}");
            Successor?.HandleRequest(obj);
        }
    }
}
