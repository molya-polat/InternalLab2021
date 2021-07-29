using System;
using NUnit.Framework;

namespace TestTask2
{
    public class Tests
    {

        [Test]

        public void TestSum1()
        {
            var arr = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 0, 2, 40, 6},
                new int[] { 11, 22}
            };
            var expected = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 11, 22},
                new int[] { 0, 2, 40, 6}
            };
            var result = Task2.Program.SortSum(arr, 3);
            Assert.AreEqual(result, expected);
        }
        [Test]

        public void TestSum2()
        {
            var arr = new int[][]
            {
                new int[] { 20,10,30},
                new int[] { 1, 2},
                new int[] { 5,7,3,10},
                new int[]{8,0,1}
            };
            var expected = new int[][]
            {
                new int[] { 1, 2},
                new int[] {8,0,1},
                new int[] { 5,7,3,10},
                new int[] { 20,10,30}
            };
            var result = Task2.Program.SortSum(arr, 4);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestSumException()
        {
            var arr = new int[][]
            {
            };
            Assert.That(() => Task2.Program.SortSum(arr, 2), Throws.ArgumentException);
        }

        [Test]
        public void TestMax1()
        {
            var arr = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 0, 2, 40, 6},
                new int[] { 11, 22}
            };
            var expected = new int[][]
            {
                new int[] { 1, 3, 5, 7, 9},
                new int[] { 11, 22},
                new int[] { 0, 2, 40, 6}
            };
            var result = Task2.Program.SortMax(arr, 3);
            Assert.AreEqual(result, expected);
        }
        [Test]
        public void TestMax2()
        {
            var arr = new int[][]
            {
                 new int[] { 20,10,30},
                new int[] { 1, 2},
                new int[] { 5,7,3,10},
                new int[]{8,0,1}
            };
            var expected = new int[][]
            {
                new int[] { 1, 2},
                new int[]{8,0,1},
                new int[] { 5,7,3,10},
                new int[] { 20,10,30},
            };
            var result = Task2.Program.SortMax(arr, 4);
            Assert.AreEqual(result, expected);
        }

        [Test]
        public void TestMaxException()
        {
            var arr = new int[][]
            {
            };
            Assert.That(() => Task2.Program.SortMax(arr, 2), Throws.ArgumentException);
        }

        [Test]
            public void TestMin1()
            {
                var arr = new int[][]
                {
                    new int[] { 1, 3, 5, 7, 9},
                    new int[] { 0, 2, 40, 6},
                    new int[] { 11, 22}
                };
                var expected = new int[][]
                {
                    new int[] { 0, 2, 40, 6},
                    new int[] { 1, 3, 5, 7, 9},
                    new int[] { 11, 22}
                };
                var result = Task2.Program.SortMin(arr, 3);
                Assert.AreEqual(result, expected);
            }
            [Test]
            public void TestMin2()
            {
                var arr = new int[][]
                {
                    new int[] { 20,10,30},
                    new int[] { 1, 2},
                    new int[] { 5,7,3,10},
                    new int[]{8,0,1}
                };
                var expected = new int[][]
                {
                    new int[]{8,0,1},
                    new int[] { 1, 2},
                    new int[] { 5,7,3,10},
                    new int[] { 20,10,30},
                };
                var result = Task2.Program.SortMin(arr, 4);
                Assert.AreEqual(result, expected);
            }
            [Test]
            public void TestMinException()
            {
                var arr = new int[][]
                {
                };
                Assert.That(() => Task2.Program.SortMin(arr, 2), Throws.ArgumentException);
            }
        }
    }