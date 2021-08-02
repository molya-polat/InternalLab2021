using NUnit.Framework;

namespace TestTask3
{
    public class Tests
    {

        [Test]
        [TestCase(null, true)]
        [TestCase("123456", false)]
        [TestCase(783.2, false)]
        [TestCase(new int []{1,2,3}, false)]
        public void Test1(object? obj, bool expected)
        {
            bool result = Task3.Program.IsNull(obj);
            Assert.AreEqual(result, expected);
        }
    }
}