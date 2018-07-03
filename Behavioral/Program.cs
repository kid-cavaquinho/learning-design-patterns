using System;
using Behavioral.Chain_of_responsability.Concretes;
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
            
            //// Mediator
            //var mediator = new ConcreteMediator();

            //var ampeg = new Ampeg(mediator);
            //var markbass = new Markbass(mediator);

            //mediator.Ampeg = ampeg;
            //mediator.Markbass = markbass;

            //ampeg.Send("Rocking");
            //ampeg.Send("Make it until eleven!");

            //// Chain of responsability            
            var voxConcrete = new Vox();
            var glockenklangConcrete = new Glockenklang();

            voxConcrete.SetSuccessor(glockenklangConcrete);

            int[] levels = { -1, 2, 5, 1, 11, 4, 8, 6, 10, 3 };

            foreach (var level in levels)
            {
                voxConcrete.Process(level);
            }

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
