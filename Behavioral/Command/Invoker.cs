namespace Command
{
    public class Invoker
    {
        private Command Command { get; set; }

        public void ExcuteCommand()
        {
            Command.Excute();
        }

        public void SetCommand(Command command)
        {
            Command = command;
        }
    }
}
