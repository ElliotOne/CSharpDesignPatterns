using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            new Adapter().Request();

            Console.ReadKey();
        }
    }
}
