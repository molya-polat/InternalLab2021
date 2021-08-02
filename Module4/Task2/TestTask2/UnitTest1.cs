using NUnit.Framework;

namespace TestTask2
{
    public class Tests
    {

        [Test]
        [TestCase(15, new int [] { 45, 90, 30, 105 })]
        [TestCase(24  , new int[] { 456, 24 })]
        [TestCase(13, new int[] { -78, 39, 13 })]

        public void TestEuclidean(int expected,params int [] nums)
        {
            int result = Task2.Extension.Euclidean(nums);
            Assert.AreEqual(result, expected);
        }
        [Test]
        [TestCase(15, new int[] { 45, 90, 30, 105 })]
        [TestCase(24, new int[] { 456, 24 })]
        [TestCase(13, new int[] { -78, 39, 13 })]

        public void TestStein(int expected, params int[] nums)
        {
            int result = Task2.Extension.SteinAlgorithm(nums);
            Assert.AreEqual(result, expected);
        }

        [Test]
        [TestCase(new int[] { })]
        public void TestExceptionStein(params int[] arr)
        {
            Assert.That(()=>Task2.Extension.SteinAlgorithm(arr), Throws.ArgumentException);
        }
        [Test]
        [TestCase(new int[] { 12, 0, 8 })]
        public void TestZeroExceptionStein(params int[] arr)
        {
            Assert.That(() => Task2.Extension.SteinAlgorithm(arr), Throws.Exception);
        }
        [Test]
        [TestCase(new int[] { })]
        public void TestExceptionEuclidean(params int[] arr)
        {
            Assert.That(() => Task2.Extension.Euclidean(arr), Throws.ArgumentException);
        }
        [Test]
        [TestCase(new int[] { 12, 0, 8 })]
        public void TestZeroException(params int[] arr)
        {
            Assert.That(() => Task2.Extension.Euclidean(arr), Throws.Exception);
        }
    }
}