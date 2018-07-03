using System;
using Creational.Builder;
using Creational.Builder.ConcreteBuilders;
using Creational.Factory_Method;
using Creational.Factory_Method.Interfaces;
using Creational.Prototype;
using Creational.Prototype.ConcretePrototypes;
using Creational.Singleton;

namespace Creational
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Builder 
            //var intrumentCreator = new InstrumentCreator(new FenderBuilder());
            //intrumentCreator.CreateInstrument();
            //var instrument = intrumentCreator.GetInstrument();

            //Console.WriteLine("Rockin' with {0}", instrument.Model);

            //intrumentCreator = new InstrumentCreator(new FoderaBuilder());
            //intrumentCreator.CreateInstrument();
            //instrument = intrumentCreator.GetInstrument();

            //Console.WriteLine("Groovin' with {0}", instrument.Model);
            //Console.ReadKey();

            //// Factory
            //InstrumentFactory factory = new ConcreteInstrumentFactory();

            //IFactory fender = factory.GetInstrument(InstrumentType.Fender);
            //fender.Play();

            //IFactory gibson = factory.GetInstrument(InstrumentType.Gibson);
            //gibson.Play();
            //Console.ReadKey();

            //// Singleton
            //Console.WriteLine("Can I use a studio for 1 person? {0}", StudioWithoutLock.Instance.IsStudioAvailable(1) ? "Yes" : "No");
            //Console.WriteLine("Can I use a studio for 10 person? {0}", StudioWithoutLock.Instance.IsStudioAvailable(10) ? "Yes" : "No");

            //// Prototype
            var rickenbackerPrototype = new RickenbackerPrototype("R");
            var clonedrickenbackerPrototype = rickenbackerPrototype.Clone() as RickenbackerPrototype;
            Console.WriteLine($"Cloned rickenbacker concrete prototype: {clonedrickenbackerPrototype?.Id}");

            var warwickPrototype = new WarwickPrototype("W");
            var clonedWarwickPrototype = (WarwickPrototype)warwickPrototype.Clone();
            Console.WriteLine($"Cloned warwick concrete prototype: {clonedWarwickPrototype.Id}");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
