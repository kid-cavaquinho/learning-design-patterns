namespace Builder.ConcreteBuilders
{
    /// <summary>
    /// A 'ConcreteBuilder' class
    /// </summary>
    public class FenderBuilder : IInstrumentBuilder
    {
        Instrument instrument = new Instrument();

        public Instrument GetInstrument()
        {
            return instrument;
        }

        public void SetNeck()
        {
            instrument.Neck = "C type";
        }

        public void SetModel()
        {
            instrument.Model = "1975 Jazz Bass Re-Issue";
        }
        
        public void SetWood()
        {
            instrument.Wood = "Alder";
        }
    }
}
