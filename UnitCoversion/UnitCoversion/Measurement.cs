using Pressure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCoversion
{
    public class Measurement
    {
        public Measurement(double val, UnitOfMeasurement unit)
        {
            Value = val;
            Unit = unit;
        }
        public double Value { get; set; }
        public UnitOfMeasurement Unit { get; set; }
    }
    public enum UnitOfMeasurement
    {
        Invalid,
        Pa,
        MPa,
        HPa,
        kPa
    }
}
