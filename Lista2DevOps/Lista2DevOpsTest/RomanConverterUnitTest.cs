using Lista2DevOps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lista2DevOpsTest
{
    [TestClass]
    public class RomanConverterUnitTest
    {
        private RomanConverter _RomanConverter;

        [TestInitialize]
        public void Init()
        {
            _RomanConverter = new RomanConverter();
        }

        [TestMethod]
        public void ConvertNumber1to10()
        {
            Assert.AreEqual(_RomanConverter.Convert(01), "I");
            Assert.AreEqual(_RomanConverter.Convert(02), "II");
            Assert.AreEqual(_RomanConverter.Convert(03), "III");
            Assert.AreEqual(_RomanConverter.Convert(04), "IV");
            Assert.AreEqual(_RomanConverter.Convert(05), "V");
            Assert.AreEqual(_RomanConverter.Convert(06), "VI");
            Assert.AreEqual(_RomanConverter.Convert(07), "VII");
            Assert.AreEqual(_RomanConverter.Convert(08), "VIII");
            Assert.AreEqual(_RomanConverter.Convert(09), "IX");
            Assert.AreEqual(_RomanConverter.Convert(10), "X");
        }

        [TestMethod]
        [ExpectedException(typeof( InvalidCastException))]
        public void TryConvert0()
        {
            Assert.AreEqual(_RomanConverter.Convert(0), "");
        }

        [TestMethod]
        public void Convert998()
        {
            // C-100 M900 X910 V915 III918
            Assert.AreEqual(_RomanConverter.Convert(998), "CMXCVIII");
        }
    }
}
