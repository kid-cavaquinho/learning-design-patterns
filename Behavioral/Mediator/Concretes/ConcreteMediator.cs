namespace Behavioral.Mediator.Concretes
{
    internal class ConcreteMediator : Mediator
    {
        private Ampeg _ampeg;
        private Markbass _markbass;

        public Ampeg Ampeg { set => _ampeg = value; }
        public Markbass Markbass { set => _markbass = value; }

        public override void Send(string message, Amplifier amplifier)
        {
            if (amplifier == _ampeg)
            {
                _markbass.Notify(message);
            }
            else
            {
                _ampeg.Notify(message);
            }
        }
    }
}