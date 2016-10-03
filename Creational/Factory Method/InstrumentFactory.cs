using Creational.Factory_Method.Interfaces;

namespace Creational.Factory_Method
{
    public abstract class InstrumentFactory
    {
        public abstract IFactory GetInstrument(InstrumentType instrument);
    }
}
