using System;

namespace Behavioral.Chain_of_responsability.Concretes
{
    internal class Glockenklang : Handler
    {
        public override void Process(int level)
        {
            if (level == 11)
            {
                Console.WriteLine($"{GetType().Name} goes until {level}. What an amplifier!");
            }
            else
            {
                Successor?.Process(level);
            }
        }
    }
}