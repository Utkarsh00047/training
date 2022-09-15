using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            PrimeNumber Prime = new PrimeNumber();
        }
        [TestMethod]
        public void oneisprime()
        {
            PrimeNumber calculator = new PrimeNumber();
            float result = calculator.GetPrime(1);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void twoisprime()
        {
            PrimeNumber calculator = new PrimeNumber();
            float result = calculator.GetPrime(2);

            Assert.AreEqual(0, result);
        }
    }
}
