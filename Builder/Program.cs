using Builder.ConcreteBuilders;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var intrumentCreator = new InstrumentCreator(new FenderBuilder());
            intrumentCreator.CreateInstrument();
            var instrument = intrumentCreator.GetInstrument();

            Console.WriteLine("Rockin' with {0}", instrument.Model);

            intrumentCreator = new InstrumentCreator(new FoderaBuilder());
            intrumentCreator.CreateInstrument();
            instrument = intrumentCreator.GetInstrument();

            Console.WriteLine("Groovin' with {0}", instrument.Model);

            Console.Read();
        }
    }
}
