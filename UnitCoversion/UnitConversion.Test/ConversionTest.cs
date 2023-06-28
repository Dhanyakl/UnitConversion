using Pressure;
using System.Net.Http.Headers;
using UnitCoversion;

namespace UnitConversion.Test
{
    [TestClass]
    public class ConversionTest
    {
        [TestMethod]
        public void IsConverted_ResultAreSame()
        {
            IUnitConverter unitConverter = new PaToKpa();
            var result = unitConverter.ConvertUnit(50, UnitOfMeasurement.Pa);
            Assert.AreEqual(result.Value, 0.05);
        }
    }
}