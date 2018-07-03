using System;

namespace Behavioral.Mediator.Concretes
{
    internal class Ampeg : Amplifier
    {
        public Ampeg(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Ampeg plays : " + message);
        }
    }
}