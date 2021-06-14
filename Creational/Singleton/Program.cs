using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton1 = Singleton.Instance();
            var singleton2 = Singleton.Instance();

            if (singleton1 == singleton2)
            {
                Console.WriteLine("Objects are the same instance!");
            }

            Console.ReadKey();
        }
    }
}
