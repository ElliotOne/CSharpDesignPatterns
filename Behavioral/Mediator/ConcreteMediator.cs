namespace Mediator
{
    public class ConcreteMediator : Mediator
    {
        public ConcreteColleagueA ColleagueA { get; set; }
        public ConcreteColleagueB ColleagueB { get; set; }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == ColleagueA)
            {
                ColleagueA.Notify(message);
            }
            else
            {
                ColleagueB.Notify(message);
            }
        }
    }
}
