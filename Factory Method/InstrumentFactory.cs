using Factory_Method.Interfaces;

namespace Factory_Method
{
    public abstract class InstrumentFactory
    {
        public abstract IFactory GetInstrument(InstrumentType instrument);
    }
}
