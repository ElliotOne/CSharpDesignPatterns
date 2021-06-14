using System.Collections;

namespace Flyweight
{
    public class FlyweightFactory
    {
        public FlyweightFactory()
        {
            Flyweights.Add("ConcreteFlyweightA", new ConcreteFlyweight());
            Flyweights.Add("ConcreteFlyweightB", new ConcreteFlyweight());
            Flyweights.Add("ConcreteFlyweightC", new ConcreteFlyweight());
        }

        private Hashtable Flyweights { get; } = new Hashtable();

        public Flyweight GetFlyweight(string key)
        {
            return (Flyweight)Flyweights[key];
        }
    }
}
