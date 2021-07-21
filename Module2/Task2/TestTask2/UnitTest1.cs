using Microsoft.VisualStudio.TestPlatform.TestHost;
using NUnit.Framework;
using Task2;
namespace TestTask2
{
    public class Tests
    {
        [Test]
        [TestCase(new []{2,12,34,69},4,69)]
        [TestCase(new[] { 56, -34, 61, 12, -5, 99}, 6, 99)]
        [TestCase(new[] { 66, 12, 61, -9, -45, -56, 568 }, 7, 568)]
        [TestCase(new[] { 4, -4, 10}, 3, 10)]
     
        public void Test1(int [] arr, int size, int expected)
        {
            int result = Task2.Program.FindMax(arr, size);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(new[] { 34, 76 }, -2)]
        public void Test2(int[] arr, int size)
        {
            Assert.That(() => Task2.Program.FindMax(arr, size), Throws.ArgumentException);

        }
    }
}