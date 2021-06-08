using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var receiver = new Receiver();
            var command = new ConcreteCommand(receiver);
            var invoker = new Invoker();

            invoker.SetCommand(command);
            invoker.ExcuteCommand();

            Console.ReadKey();
        }
    }
}
