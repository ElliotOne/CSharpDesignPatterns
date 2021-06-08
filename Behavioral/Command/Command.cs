namespace Command
{
    public abstract class Command
    {
        protected readonly Receiver Receiver;

        protected Command(Receiver receiver)
        {
            Receiver = receiver;
        }

        public abstract void Excute();
    }
}
