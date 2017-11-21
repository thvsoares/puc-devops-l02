using Lista2DevOps;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        public void ConvertNumber1()
        {
            Assert.AreEqual(_RomanConverter.Convert(1), "I");
        }
    }
}
