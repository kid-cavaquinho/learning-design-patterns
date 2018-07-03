namespace Creational.Prototype.ConcretePrototypes
{
    internal class WarwickPrototype : Instrument
    {
        public WarwickPrototype(string id) : base(id) { }

        public override Instrument Clone()
        {
            return (Instrument)MemberwiseClone();
        }
    }
}