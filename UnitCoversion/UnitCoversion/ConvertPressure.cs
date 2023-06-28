using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCoversion
{
    public class ConvertPressure
    {
        public IUnitConverter unitConverter;
        public ConvertPressure(IUnitConverter unitConverter)
        {
            this.unitConverter = unitConverter;
        }
        public Measurement ConvertPressureToUnit(Measurement measurement, UnitOfMeasurement targetUnit)
        {
            if (measurement.Unit == targetUnit)
            {
                throw new NotSupportedException($"Source unit '{measurement.Unit}' and target unit '{targetUnit}' are same. Not able to convert.");
            }
            return unitConverter.ConvertUnit(measurement.Value, targetUnit);
        }
    }
}
