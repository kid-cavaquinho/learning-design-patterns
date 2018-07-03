namespace Behavioral.Chain_of_responsability
{
    internal abstract class Handler
    {
        protected Handler Successor;

        public void SetSuccessor(Handler successor)
        {
            Successor = successor;
        }

        public abstract void Process(int level);
    }
}