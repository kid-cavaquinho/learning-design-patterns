namespace Behavioral.Mediator
{
    internal abstract class Mediator
    {
        public abstract void Send(string message, Amplifier amplifier);
    }
}