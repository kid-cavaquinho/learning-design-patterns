namespace Creational.Prototype.ConcretePrototypes
{
    internal class RickenbackerPrototype : Instrument
    {
        public RickenbackerPrototype(string id) : base(id) { }

        public override Instrument Clone()
        {
            return (Instrument)MemberwiseClone();
        }
    }
}