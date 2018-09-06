using System;
using System.Reflection;

namespace Behavioral.Template_Method.Concretes
{
    internal class Stratocaster : AbstractGuitar
    {
        public override void Tune()
        {
            Console.WriteLine($"Concrete class {GetType().Name} and method {MethodBase.GetCurrentMethod().Name}");
        }

        public override void Play()
        {
            Console.WriteLine($"Concrete class {GetType().Name} and method {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
