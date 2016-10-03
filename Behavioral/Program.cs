using System;
using Behavioral.Strategy.Clients;
using Behavioral.Strategy.Strategies;

namespace Behavioral
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Strategy pattern
            AmplifierClient client = new AmplifierClient();

            client.SetAmplifier(new AmpegStrategy());
            Console.WriteLine("Ampeg: " + client.SpeakerConnection());
            
            client.SetAmplifier(new MarkbassStrategy());
            Console.WriteLine("Markbass: " + client.SpeakerConnection());

            Console.ReadKey();
        }
    }
}
