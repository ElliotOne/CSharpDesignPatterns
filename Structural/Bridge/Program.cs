using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            var abstraction = new RefinedAbstraction { Implementor = new ConcreteImplementorA() };
            abstraction.Operation();

            abstraction.Implementor = new ConcreteImplementorB();
            abstraction.Operation();

            Console.ReadKey();
        }
    }
}
