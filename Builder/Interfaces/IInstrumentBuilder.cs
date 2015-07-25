namespace Builder
{
    /// <summary>
    /// The 'Builder' interface
    /// </summary>
    public interface IInstrumentBuilder
    {
        void SetNeck();
        void SetWood();
        void SetModel();

        Instrument GetInstrument();
    }
}
