using System.Collections;

namespace Iterator
{
    public class ConcreteAggregate : Aggregate
    {
        public int Count => Items.Count;

        public ArrayList Items { get; } = new ArrayList();

        public object this[int index]
        {
            get => Items[index];
            set => Items.Insert(index, value);
        }
        
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
