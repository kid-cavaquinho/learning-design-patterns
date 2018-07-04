using System;

namespace Structural.Facade.SubSystems
{
    internal class Studio
    {
        public bool Rehearsed(Musician musician)
        {
            if (musician.Name != "Jimi Hendrix")
            {
                return false;
            }

            Console.WriteLine($"{musician.Name} has rehearsed");
            return true;
        }
    }
}