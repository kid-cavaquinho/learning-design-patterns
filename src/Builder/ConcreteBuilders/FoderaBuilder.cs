namespace Builder.ConcreteBuilders
{
    /// <summary>
    /// A 'ConcreteBuilder' class
    /// </summary>
    public class FoderaBuilder : IInstrumentBuilder
    {
        Instrument instrument = new Instrument();

        public Instrument GetInstrument()
        {
            return instrument;
        }

        public void SetNeck()
        {
            instrument.Neck = "V type";
        }

        public void SetModel()
        {
            instrument.Model = "Figured Chestnut Matt Garrison Imperial 5 Elite";
        }

        public void SetWood()
        {
            instrument.Wood = "Ebony";
        }
    }
}
