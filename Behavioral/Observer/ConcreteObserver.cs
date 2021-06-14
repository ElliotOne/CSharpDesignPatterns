using System;

namespace Observer
{
    public class ConcreteObserver : Observer
    {
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            Name = name;
            Subject = subject;
        }

        private string Name { get; }

        private ConcreteSubject Subject { get; }

        public override void Update()
        {
            Console.WriteLine($"{Name}.Update(): {Subject.SubjectState}");
        }
    }
}
