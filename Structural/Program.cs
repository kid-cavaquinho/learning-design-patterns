using System;
using Structural.Facade;

namespace Structural
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            // Facade
            var facade = new Stage();

            var musician = new Musician {Name = "Jimi Hendrix", Instruments = new [] {"Guitar", "Bass", "Voice"}};
            var result = facade.Approve(musician);
            Console.WriteLine($"{musician.Name} has been {(result ? "approved" : "rejected")} to play");

            Console.WriteLine("Press any key");
            Console.ReadKey();
        }
    }
}
