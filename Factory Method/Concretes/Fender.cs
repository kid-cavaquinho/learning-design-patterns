using Factory_Method.Interfaces;
using System;

namespace Factory_Method.Concretes
{
    class Fender : IFactory
    {
        public void Play()
        {
            Console.WriteLine("Jamming with a Fender");
        }
    }
}
