using System;

namespace Behavioral.Chain_of_responsability.Concretes
{
    internal class Vox : Handler
    {
        public override void Process(int level)
        {
            if (level >= 0 && level <= 10)
            {
                Console.WriteLine($"{GetType().Name} processes sound level at {level}");
            }
            else
            {
                Successor?.Process(level);
            }
        }
    }
}