using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var component = new ConcreteComponent();
            var concreteDecoratorA = new ConcreteDecoratorA();
            var concreteDecoratorB = new ConcreteDecoratorB();

            concreteDecoratorA.SetComponent(component);
            concreteDecoratorB.SetComponent(concreteDecoratorA);
            concreteDecoratorB.Operation();

            Console.ReadKey();
        }
    }
}
