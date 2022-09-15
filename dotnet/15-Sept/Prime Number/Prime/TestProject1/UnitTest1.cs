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
        public void Oneisprime()
        {
            PrimeNumber calculator = new PrimeNumber();
            int result = (int)calculator.GetPrime(3);

            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Twoisprime()
        {
            PrimeNumber calculator = new PrimeNumber();
            int result = (int)calculator.GetPrime(2);

            Assert.AreEqual(0, result);
        }
    }
}
