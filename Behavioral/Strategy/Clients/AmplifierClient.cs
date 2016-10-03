using Behavioral.Strategy.Interface;

namespace Behavioral.Strategy.Clients
{
    class AmplifierClient
    {
        private IAmplifier _strategy;

        // Change the strategy
        public void SetAmplifier(IAmplifier strategy)
        {
            _strategy = strategy;
        }

        // Executes the strategy
        public string SpeakerConnection()
        {
            return _strategy?.SpeakerConnection();
        }
    }
}
