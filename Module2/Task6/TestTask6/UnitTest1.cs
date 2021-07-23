using System.Runtime.InteropServices.WindowsRuntime;
using NUnit.Framework;

namespace TestTask6
{
    public class Tests
    {

        [Test]
        [TestCase(new []{7,71,45,55,76,70}, 7, new []{7,71,76,70})]
        [TestCase(new[] { 78,125,34,7,9 }, 5, new[]{125})]
        [TestCase(new[] { 7, 6, 45, 55, 76, 70 }, 1, null)]
        public void Test1(int [] arr, int number, int[] expected)
        {
            int[] result = Task6.Program.FilterDigit(arr, number);
            Assert.AreEqual(result, expected);
        }
    }
}