using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            new Context(new ConcreteStrategyA()).Method();

            new Context(new ConcreteStrategyB()).Method();

            new Context(new ConcreteStrategyC()).Method();

            Console.ReadKey();
        }
    }
}
