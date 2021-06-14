namespace Mediator
{
    public abstract class Colleague
    {
        protected Mediator Mediator;

        protected Colleague(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}
