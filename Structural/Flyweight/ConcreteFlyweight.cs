using System;

namespace Flyweight
{
    public class ConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicstate)
        {
            Console.WriteLine("ConcreteFlyweight.Operation(): " + extrinsicstate);
        }
    }
}
