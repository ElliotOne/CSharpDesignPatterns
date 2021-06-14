namespace Strategy
{
    public class Context
    {
        public Context(Strategy strategy)
        {
            Strategy = strategy;
        }

        public Strategy Strategy { get; }

        public void Method()
        {
            Strategy.Method();
        }
    }
}
