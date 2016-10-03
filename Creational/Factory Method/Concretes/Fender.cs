using System;
using Creational.Factory_Method.Interfaces;

namespace Creational.Factory_Method.Concretes
{
    class Fender : IFactory
    {
        public void Play()
        {
            Console.WriteLine("Jamming with a Fender");
        }
    }
}
