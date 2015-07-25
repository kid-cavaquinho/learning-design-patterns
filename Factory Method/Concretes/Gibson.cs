using Factory_Method.Interfaces;
using System;

namespace Factory_Method.Concretes
{
    public class Gibson : IFactory
    {
        public void Play()
        {
            Console.WriteLine("Rockin' down with a Gibson");
        }
    }
}
