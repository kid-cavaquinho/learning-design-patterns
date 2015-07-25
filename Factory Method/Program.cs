using Factory_Method.Interfaces;
using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            InstrumentFactory factory = new ConcreteInstrumentFactory();

            IFactory fender = factory.GetInstrument(InstrumentType.Fender);
            fender.Play();

            IFactory gibson = factory.GetInstrument(InstrumentType.Gibson);
            gibson.Play();

            Console.ReadKey();
        }
    }
}
