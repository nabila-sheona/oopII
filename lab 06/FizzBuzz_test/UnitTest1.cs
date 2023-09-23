using lab6_210042111;

namespace FizzBuzz_test
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void FizzBuzz_Testing_divibleby5()
        {
            Assert.AreEqual("LA LA", FizzBuzz.getFizzyBuzz(10));
            Assert.AreEqual("LA LA", FizzBuzz.getFizzyBuzz(105));

        }
        [TestMethod]
        public void FizzBuzz_Testing_divibleby9()
        {
            Assert.AreEqual("LAND", FizzBuzz.getFizzyBuzz(9));
            Assert.AreEqual("LAND", FizzBuzz.getFizzyBuzz(99));

        }

        [TestMethod]
        public void FizzBuzz_Testing_divibleby9AND5()
        {
            Assert.AreEqual("LA LA LAND", FizzBuzz.getFizzyBuzz(45));
            Assert.AreEqual("LA LA LAND", FizzBuzz.getFizzyBuzz(360));

        }

        [TestMethod]
        public void FizzBuzz_Testing_divibleby9NOR5()
        {
            Assert.AreEqual("NOT FOUND", FizzBuzz.getFizzyBuzz(4));
            Assert.AreEqual("NOT FOUND", FizzBuzz.getFizzyBuzz(67));

        }


    }
}