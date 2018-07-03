using System;

namespace Behavioral.Mediator.Concretes
{
    internal class Markbass : Amplifier
    {
        public Markbass(Mediator mediator) : base(mediator) { }

        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        public void Notify(string message)
        {
            Console.WriteLine("Markbass plays: " + message);
        }
    }
}