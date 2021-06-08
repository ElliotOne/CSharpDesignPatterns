namespace Command
{
    public class ConcreteCommand : Command
    {
        public ConcreteCommand(Receiver receiver) : base(receiver)
        {

        }

        public override void Excute()
        {
            Receiver.Action();
        }
    }
}
