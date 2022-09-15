using Microsoft.VisualStudio.TestTools.UnitTesting;

using factorial;

namespace TestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Fact1 Fact = new Fact1();
        }
        [TestMethod]

        public void ZeroFactorialIsOne()
        {
            Fact1 calculator = new Fact1();
            float result = calculator.GetFactorialOf(0);

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void OneFactorialIsOne()
        {
            Fact1 calculator = new Fact1();
            float result = calculator.GetFactorialOf(1);

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TwoFactorialIsTwo()
        {
            Fact1 calculator = new Fact1();
            float result = calculator.GetFactorialOf(2);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void ThreeFactorialIsSix()
        {
            Fact1 calculator = new Fact1();
            float result = calculator.GetFactorialOf(3);

            Assert.AreEqual(6, result);
        }
        }
    }

