using System;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            new ConcreteClassA().TemplateMethod();

            new ConcreteClassB().TemplateMethod();

            Console.ReadKey();
        }
    }
}
