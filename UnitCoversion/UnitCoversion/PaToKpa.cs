using UnitCoversion;

namespace Pressure
{
    public class PaToKpa : IUnitConverter
    {
        public Measurement ConvertUnit(double valueInPa, UnitOfMeasurement targetUnit)
        {
            var result = new Measurement(valueInPa / 1000, targetUnit);
            Console.WriteLine("Pressure after conversion : " + result.Value + targetUnit);
            return result;
        }
    }
}