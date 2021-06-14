namespace Proxy
{
    public class Proxy : Subject
    {
        public override void Request()
        {
            new RealSubject().Request();
        }
    }
}
