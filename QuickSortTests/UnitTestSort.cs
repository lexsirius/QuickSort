using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sorts;

namespace QuickSortTests
{
    [TestClass]
    public class UnitTestSort
    {
        [TestMethod]
        public void ThreeElements()
        {
            var array = new[] { 5, 1, 3 };
            Sort.QuickSort(array, 0, array.Length - 1);
            Assert.IsTrue(IsSorted(array));
        }

        [TestMethod]
        public void HundredIndentialElements()
        {
            var array = new int[100];
            var len = array.Length;
            for (int i = 0; i < len; i++)
                array[i] = 0;
            Sort.QuickSort(array, 0, len - 1);
            Assert.IsTrue(IsSorted(array));
        }

        [TestMethod]
        public void ThousandRandomElements()
        {
            var rnd = new Random();
            var array = new int[1000];
            var len = array.Length;
            for (int i = 0; i < len; i++)
                array[i] = rnd.Next(0, 1000);
            Sort.QuickSort(array, 0, len - 1);
            Assert.IsTrue(IsSortedRndCheck(array));
        }

        [TestMethod]
        public void IsEmpty()
        {
            var array = new int[0];
            Sort.QuickSort(array, 0, array.Length - 1);
            Assert.IsTrue(IsSorted(array));
        }

        [TestMethod]
        public void BigArray()
        {
            var rnd = new Random();
            var array = new int[100000000];
            var len = array.Length;
            for (int i = 0; i < len; i++)
                array[i] = rnd.Next(0, 100000);
            Sort.QuickSort(array, 0, len - 1);
            Assert.IsTrue(IsSorted(array));
        }

        private static bool IsSorted(int[] array)
        {
            var len = array.Length;
            for (int i = 1; i < len; i++)
            {
                if (array[i - 1] > array[i])
                    return false;
            }
            return true;
        }

        private static bool IsSortedRndCheck(int[] array)
        {
            var rnd = new Random();
            var len = array.Length;
            for (int i = 0; i < 10; i++)
            {
                var jLeft = rnd.Next(0, len / 2);
                var jRight = rnd.Next(len / 2 + 1, len - 1);
                if (array[jLeft] > array[jRight])
                    return false;
            }
            return true;
        }

    }
}
