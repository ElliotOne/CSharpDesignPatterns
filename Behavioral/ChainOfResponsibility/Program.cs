using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteHandlerA = new ConcreteHandlerA();
            var concreteHandlerB = new ConcreteHandlerB();
            var concreteHandlerC = new ConcreteHandlerC();

            concreteHandlerA.SetSuccessor(concreteHandlerB);
            concreteHandlerB.SetSuccessor(concreteHandlerC);

            concreteHandlerA.HandleRequest("Request");

            Console.ReadKey();
        }
    }
}
