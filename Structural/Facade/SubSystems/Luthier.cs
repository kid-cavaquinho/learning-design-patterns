using System;
using System.Linq;

namespace Structural.Facade.SubSystems
{
    internal class Luthier
    {
        public bool Instruments(Musician musician)
        {
            if (!musician.Instruments.Any())
            {
                return false;
            }

            Console.WriteLine($"{musician.Name} has one or more instruments");
            return true;
        }
    }
}