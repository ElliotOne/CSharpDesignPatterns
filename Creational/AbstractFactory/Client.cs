namespace AbstractFactory
{
    public class Client
    {
        public Client(AbstractFactory abstractFactory)
        {
            AbstractProductA = abstractFactory.CreateProductA();

            AbstractProductB = abstractFactory.CreateProductB();
        }

        public AbstractProductA AbstractProductA { get; }

        public AbstractProductB AbstractProductB { get; }

        public void Run()
        {
            AbstractProductB.Interact(AbstractProductA);
        }
    }
}
