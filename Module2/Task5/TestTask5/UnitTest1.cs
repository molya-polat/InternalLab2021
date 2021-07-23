using NUnit.Framework;

namespace TestTask5
{
    public class Tests
    {
        [Test]
        [TestCase(833712, 833721)]
        [TestCase(321848, 321884)]
        [TestCase(12, 21)]
        [TestCase(513,531)]
        [TestCase(2017, 2071)]
        [TestCase(414,  441)]
        [TestCase(144, 414)]
        [TestCase(1234321, 1241233)]
        [TestCase(1234126, 1234162)]
        [TestCase(3456432,  3462345)]
        [TestCase(10,  -1)]
        [TestCase(20, -1)]
        public void Test1(int number, int expected)
        {
            int result = Task5.Program.MyFunc(number);
            Assert.AreEqual(result, expected);
        }
    }
}