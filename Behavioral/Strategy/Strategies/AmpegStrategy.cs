using Behavioral.Strategy.Interface;

namespace Behavioral.Strategy.Strategies
{
    class AmpegStrategy : IAmplifier
    {
        public string SpeakerConnection()
        {
            // Implement the necessary logic for the ampeg speaker connection
            return "Ampeg amplification goes till eleven";
        }
    }
}
