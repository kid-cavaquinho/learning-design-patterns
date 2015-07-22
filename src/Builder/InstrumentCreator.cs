namespace Builder
{
    /// <summary>
    /// The 'Director' class
    /// </summary>
    public class InstrumentCreator
    {
        private readonly IInstrumentBuilder instrumentBuilder;

        public InstrumentCreator(IInstrumentBuilder builder)
        {
            instrumentBuilder = builder;
        }

        public void CreateInstrument()
        {
            instrumentBuilder.SetModel();
            instrumentBuilder.SetNeck();
            instrumentBuilder.SetWood();
        }

        public Instrument GetInstrument()
        {
            return instrumentBuilder.GetInstrument();
        }
    }
}
