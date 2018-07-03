namespace Creational.Prototype
{
    internal abstract class Instrument
    {
        protected Instrument(string id)
        {
            Id = id;
        }

        public string Id { get; }

        public abstract Instrument Clone();
    }
}