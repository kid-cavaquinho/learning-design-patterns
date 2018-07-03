namespace Behavioral.Mediator
{
    internal abstract class Amplifier
    {
        protected readonly Mediator Mediator;

        protected Amplifier(Mediator mediator)
        {
            Mediator = mediator;
        }
    }
}