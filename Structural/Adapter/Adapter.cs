namespace Adapter
{
    public class Adapter : ITarget
    {
        public void Request()
        {
            new Adaptee().SpecificRequest();
        }
    }
}
