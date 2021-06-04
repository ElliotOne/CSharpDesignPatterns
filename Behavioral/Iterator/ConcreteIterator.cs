namespace Iterator
{
    public class ConcreteIterator : Iterator
    {
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            Aggregate = aggregate;
        }

        public ConcreteAggregate Aggregate { get; }

        public int Current { get; private set; }

        public override object CurrentItem()
        {
            return Aggregate[Current];
        }

        public override object First()
        {
            return Aggregate[0];
        }

        public override object IsDone()
        {
            return Current >= Aggregate.Count;
        }

        public override object Next()
        {
            object result = null;

            if (Current < Aggregate.Count - 1)
            {
                result = Aggregate[++Current];
            }

            return result;
        }
    }
}
