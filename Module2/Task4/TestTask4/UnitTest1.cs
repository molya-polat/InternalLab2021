using NUnit.Framework;

namespace TestTask4
{
    public class Tests
    {
      [Test]
      [TestCase("Hello", "World!", "HeloWrd")]
      [TestCase("456Qweceq", ")aaafv87bb", "Qwecqafvb")]
      [TestCase("8lkjhga", "$)!6", "lkjhga")]
        public void Test1(string str1, string str2, string expected)
        {
            string result = Task4.Program.Concat(str1, str2);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase("", "Hi")]
        public void Test2(string str1, string str2)
        {
            Assert.That(() => Task4.Program.Concat(str1, str2), Throws.ArgumentException);
        }
    }
}