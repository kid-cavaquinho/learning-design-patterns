using System;
using Behavioral.Mediator;
using Behavioral.Mediator.Concretes;
using Behavioral.Strategy.Clients;
using Behavioral.Strategy.Strategies;

namespace Behavioral
{
    static class Program
    {
        static void Main(string[] args)
        {
            //// Strategy pattern
            //AmplifierClient client = new AmplifierClient();

            //client.SetAmplifier(new AmpegStrategy());
            //Console.WriteLine("Ampeg: " + client.SpeakerConnection());

            //client.SetAmplifier(new MarkbassStrategy());
            //Console.WriteLine("Markbass: " + client.SpeakerConnection());

            var mediator = new ConcreteMediator();

            var ampeg = new Ampeg(mediator);
            var markbass = new Markbass(mediator);

            mediator.Ampeg = ampeg;
            mediator.Markbass = markbass;

            ampeg.Send("Rocking");
            ampeg.Send("Make it until eleven!");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
