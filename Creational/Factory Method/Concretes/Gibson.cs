using System;
using Creational.Factory_Method.Interfaces;

namespace Creational.Factory_Method.Concretes
{
    public class Gibson : IFactory
    {
        public void Play()
        {
            Console.WriteLine("Rockin' down with a Gibson");
        }
    }
}
