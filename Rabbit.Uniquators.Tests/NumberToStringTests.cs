using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Rabbit.Uniquators.Tests
{
    [TestClass]
    public class NumberToStringTests
    {
        [TestMethod]
        public void CanConvert_Hexadecimal()
        {
            const int value = 16;

            var result = NumberToString.Convert(value, IdBase.Hexadecimal);

            Assert.AreEqual("10", result);
        }

        [TestMethod]
        public void CanConvert_Hexatrigesimal1()
        {
            const int value = 16;

            var result = NumberToString.Convert(value, IdBase.Hexatrigesimal);

            Assert.AreEqual("G", result);
        }

        [TestMethod]
        public void CanConvert_Hexatrigesimal2()
        {
            const int value = 46;

            var result = NumberToString.Convert(value, IdBase.Hexatrigesimal);

            Assert.AreEqual("1A", result);
        }


        [TestMethod]
        public void CanConvert_Sexagesimal1()
        {
            const int value = 246;

            var result = NumberToString.Convert(value, IdBase.Sexagesimal);

            Assert.AreEqual("46", result);
        }

        [TestMethod]
        public void CanConvert_Duosexagesimal()
        {
            const int value = 246;

            var result = NumberToString.Convert(value, IdBase.Duosexagesimal);

            Assert.AreEqual("3y", result);
        }
    }
}
