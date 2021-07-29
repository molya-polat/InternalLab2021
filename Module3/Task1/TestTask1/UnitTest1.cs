using NUnit.Framework;

namespace TestTask1
{
    public class Tests
    {
        

        [Test]
        [TestCase(0.04100625, 4, 0.0001, 0.45)]
        [TestCase(8, 3, 0.0001, 2)]
        [TestCase(0.0279936, 7, 0.0001, 0.6)]
        [TestCase(0.0081, 4, 0.01, 0.3)]
        [TestCase(-0.008, 3, 0.001, -0.2)]
        [TestCase(0.004241979, 9, 0.00000001, 0.545)]
        public void TestWithResults(double number, double n, double precision, double expected)
        {
            double result = Task1.Program.FindNthRoot(number, n, precision);
            Assert.AreEqual(result, expected);
        }
        [Test]
        [TestCase(-0.01, 2, 0.0001)]
        [TestCase(0.001, -2,  0.0001)]
        [TestCase(0.01, 2, -1)]

        public void TestWithExceptions(double number, double n, double precision)
        {
            Assert.That(() => Task1.Program.FindNthRoot(number, n, precision), Throws.ArgumentException);
        }
    }
}