using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitCoversion
{
    public interface IUnitConverter
    {
        Measurement ConvertUnit(double value, UnitOfMeasurement targetUnit);
    }
}
