using NUnit.Framework;

namespace TestTask3
{
    public class Tests
    {
        [Test]
        [TestCase(new [] {12.1, 45.89, 58.0, 7.88, 25.32, 24.79}, 2)]
        [TestCase(new[] { -48.2, 98.45, 15.12, 23.1, 8.0, 112.75, -24.28 }, 4)]
        [TestCase(new [] {45.23, 87.2, 85.78, -66.3, 19.2},-1)]
        public void Test1(double []arr, int expected)
        {
            int index = Task3.Program.FindSpecialIndex(arr);
            Assert.AreEqual(index, expected);
        }
    }
}