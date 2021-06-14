using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            new Client(new ConcreteFactoryA()).Run();
            new Client(new ConcreteFactoryB()).Run();

            Console.ReadKey();
        }
    }
}
