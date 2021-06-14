using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();
            facade.Method1();
            facade.Method2();

            Console.ReadKey();
        }
    }
}
