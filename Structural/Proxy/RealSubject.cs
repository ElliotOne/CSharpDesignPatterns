using System;

namespace Proxy
{
    public class RealSubject : Subject
    {
        public override void Request()
        {
            Console.WriteLine("RealSubject.Request()");
        }
    }
}
