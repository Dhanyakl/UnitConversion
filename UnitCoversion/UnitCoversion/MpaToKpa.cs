using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCoversion
{
    public class MpaToKpa : IUnitConverter
    {
        public Measurement ConvertUnit(double value, UnitOfMeasurement targetUnit)
        {
            var result = new Measurement(value * 1000, targetUnit);
            Console.WriteLine("Pressure after conversion : " + result.Value + targetUnit);
            return result;
        }
    }
}
