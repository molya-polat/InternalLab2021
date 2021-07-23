using NUnit.Framework;

namespace TestTask1
{
    public class Tests
    {
       

        [Test]
        [TestCase(8,15,3,8,120)]
        [TestCase(15,15,0,0,15)]
        [TestCase(8,15,0,0,9)]
        [TestCase(8, -7, 0, 2, 9)]
        [TestCase(-7, 1, 1, 2, -5)]
        public void Test1(int numberSource, int numberIn, int i, int j, int expected)
        {
            int result = Task1.Program.InsertNumber(numberSource, numberIn, i, j);
            Assert.AreEqual(result, expected);
        }
    }
}