using System;
using NUnit.Framework;

namespace TestTask2
{
    public class Tests
    {
        private int[][] arr1;
        private int[][] expected1;
        private int[][] arr2;
        private int[][] expected2;
        private int[][] arr3;
        private int[][] expected3;
        private int[][] arr;
        [SetUp]
        public void SetUp()
        {
            arr1 = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 0, 2, 40, 6},
                new int[] { 11, 22}
            };
            expected1 = new int[][]
            {
               new int[] { 1, 3, 5, 7, 9},
                new int[] { 11, 22},
                new int[] { 0, 2, 40, 6}
            };

            arr2 = new int[][]
            {
                new int[] { 20,10,30},
                new int[] { 1, 2},
                new int[] { 5,7,3,10},
                new int[]{8,0,1}
            };
            expected2 = new int[][]
            {
                new int[] { 1, 2},
                new int[] {8,0,1},
                new int[] { 5,7,3,10},
                new int[] { 20,10,30}
            };
            arr = new int[][]
            {
            };
        }
        [Test]
        public void TestSum1()
        {
            var result = Task2.Program.SortSum(arr1, 3);
            Assert.AreEqual(result, expected1);
        }
        [Test]

        public void TestSum2()
        {
            var result = Task2.Program.SortSum(arr2, 4);
            Assert.AreEqual(result, expected2);
        }
        [Test]
        public void TestSumException()
        {
            Assert.That(() => Task2.Program.SortSum(arr, 2), Throws.ArgumentException);
        }

        [Test]
        public void TestMax1()
        {
            var expected = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 11, 22},
                new int[] { 0, 2, 40, 6},
            };
            var result = Task2.Program.SortMax(arr1, 3);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestMax2()
        {
            var expected = new int[][]
            {
                new int[] { 1, 2},
                new int[] {8,0,1},
                new int[] { 5,7,3,10},
                new int[] { 20,10,30}
            };
            var result = Task2.Program.SortMax(arr2, 4);
            Assert.AreEqual(result, expected2);
        }

        [Test]
        public void TestMaxException()
        {
            Assert.That(() => Task2.Program.SortMax(arr, 2), Throws.ArgumentException);
        }

        [Test]
        public void TestMin1()
        {
            var expected = new int[][]
            {
                new int[] { 0, 2, 40, 6},
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 11, 22}
            };
            var result = Task2.Program.SortMin(arr1, 3);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestMin2()
        {
            var expected = new int[][]
            {
                new int[] {8,0,1},
                new int[] { 1, 2},
                new int[] { 5,7,3,10},
                new int[] { 20,10,30}
            };
            var result = Task2.Program.SortMin(arr2, 4);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestMinException()
        {
            Assert.That(() => Task2.Program.SortMin(arr, 2), Throws.ArgumentException);
        }
    }
}