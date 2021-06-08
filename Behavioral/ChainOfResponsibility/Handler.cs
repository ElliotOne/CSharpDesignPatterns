namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler Successor;

        public abstract void HandleRequest(object obj);

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }
    }
}
