using System;
using Structural.Facade.SubSystems;

namespace Structural.Facade
{
    internal class Stage
    {
        private readonly Studio _studio;
        private readonly Luthier _luthier;

        public Stage()
        {
            _studio = new Studio();
            _luthier = new Luthier();
        }

        public bool Approve(Musician musician)
        {
            Console.WriteLine($"Musician {musician.Name}");

            var result = true;

            if (!_studio.Rehearsed(musician)) 
            {
                result = false;
            }
            else if (!_luthier.Instruments(musician))
            {
                result = false;
            }

            return result;
        }
    }
}