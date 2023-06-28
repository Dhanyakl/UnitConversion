using System;
using System.Text.RegularExpressions;
using UnitCoversion;

namespace Pressure
{ 
    public static class UnitConverter
    {
        public static Measurement ConvertPressure(Measurement measurement, UnitOfMeasurement targetUnit)
        { 

            ConvertPressure convertPressure = new ConvertPressure(null);
            if (measurement.Unit == targetUnit)
            {
                throw new NotSupportedException($"Source unit '{measurement.Unit}' and target unit '{targetUnit}' are same. Not able to convert.");
            }
            switch (measurement.Unit)  
            { 
                case UnitOfMeasurement.Pa:
                    convertPressure.unitConverter = new PaToKpa();
                    break;
                case UnitOfMeasurement.MPa:
                    convertPressure.unitConverter = new MpaToKpa();
                    break;
                case UnitOfMeasurement.HPa:
                    convertPressure.unitConverter = new HpaToKpa();
                    break;
                default:
                    throw new NotSupportedException($"Source unit '{measurement.Unit}' cannot be converted to target unit '{targetUnit}'."); 
            }
            return convertPressure.ConvertPressureToUnit(measurement,targetUnit);
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter pressure with unit (Pa/MPa/HPa) : ");
                var pressureWithUnit = Console.ReadLine();
                Measurement measurement = MeasurementValueProcessing(pressureWithUnit);
                Console.WriteLine("Pressure before conversion : " + pressureWithUnit);
                ConvertPressure(measurement, UnitOfMeasurement.kPa);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private static Measurement MeasurementValueProcessing(string? pressureWithUnit)
        {
            double pressureVal = Convert.ToInt16(Regex.Match(pressureWithUnit, @"\d+").Value);
            string pressureUnit = Regex.Match(pressureWithUnit, @"\D+").Value;
            UnitOfMeasurement myEnum = (UnitOfMeasurement)Enum.Parse(typeof(UnitOfMeasurement), pressureUnit, true);
            Measurement measurement = new Measurement(pressureVal, myEnum);
            return measurement;
        }
    }
}