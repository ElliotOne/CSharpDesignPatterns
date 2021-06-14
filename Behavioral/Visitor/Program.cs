using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var objectStructure = new ObjectStructure();

            objectStructure.Attach(new ConcreteElementA());
            objectStructure.Attach(new ConcreteElementB());

            objectStructure.Accept(new ConcreteVisitorA());
            objectStructure.Accept(new ConcreteVisitorB());

            Console.ReadKey();
        }
    }
}
