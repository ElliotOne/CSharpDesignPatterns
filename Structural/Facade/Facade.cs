using System;

namespace Facade
{
    public class Facade
    {
        public void Method1()
        {
            Console.WriteLine("Facade.Method1()");
            new OtherSystemA().Method();
        }

        public void Method2()
        {
            Console.WriteLine("Facade.Method2()");
            new OtherSystemB().Method();
        }
    }
}
