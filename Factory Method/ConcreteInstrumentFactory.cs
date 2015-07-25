using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Factory_Method.Interfaces;
using Factory_Method.Concretes;

namespace Factory_Method
{
    public class ConcreteInstrumentFactory : InstrumentFactory
    {
        public override IFactory GetInstrument(InstrumentType instrument)
        {
            switch (instrument)
            {
                case InstrumentType.Fender:
                    return new Fender();
                case InstrumentType.Gibson:
                    return new Gibson();
                default:
                    throw new ApplicationException(string.Format("Instrument type {0} cannot be created", instrument));
            }
        }
    }
}
