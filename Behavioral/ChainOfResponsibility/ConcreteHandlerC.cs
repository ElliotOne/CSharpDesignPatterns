using System;

namespace ChainOfResponsibility
{
    public class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(object obj)
        {
            Console.WriteLine($"ConcreteHandlerC.HandleRequest(): {obj}");
            Successor?.HandleRequest(obj);
        }
    }
}
