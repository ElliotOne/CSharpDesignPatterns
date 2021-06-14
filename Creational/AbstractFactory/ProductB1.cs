using System;

namespace AbstractFactory
{
    public class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA abstractProductA)
        {
            Console.WriteLine(GetType().Name + " interacts with " + abstractProductA.GetType().Name);
        }
    }
}
