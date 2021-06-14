using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var creators = new Creator[] { new ConcreteCreatorA(), new ConcreteCreatorB() };

            foreach (var creator in creators)
            {
                Console.WriteLine(creator.FactoryMethod());
            }

            Console.ReadKey();
        }
    }
}
