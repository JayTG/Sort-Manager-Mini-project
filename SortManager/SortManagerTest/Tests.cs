using NUnit.Framework;
using SortManagerApp;

namespace SortManagerTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },                  new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 27, 10, 22, 39, 69, 68, 61, 100, 97, 73 },       new int[] { 10, 22, 27, 39, 61, 68, 69, 73, 97, 100 })]
        [TestCase(new int[] { -85, -30, -67, -70, -18, -28, -17, -1, -9, -2 }, new int[] { -85, -70, -67, -30, -28, -18, -17, -9, -2, -1 })]
        [TestCase(new int[] { 56, -45, 77, -34, -23, 22, 29, -91, -36, 95 },   new int[] { -91, -45, -36, -34, -23, 22, 29, 56, 77, 95 })]
        [TestCase(new int[] { 79, 73, 68, 25, 3, -2, -7, -8, -60, -81 },       new int[] { -81, -60, -8, -7, -2, 3, 25, 68, 73, 79 })]
        public void BubbleSortTest(int[] unsorted, int[] sorted)
        {
            Assert.AreEqual(sorted, SortingAlgorithms.BubbleSortArray(unsorted));
        }

        [TestCase(new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },                  new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 })]
        [TestCase(new int[] { 27, 10, 22, 39, 69, 68, 61, 100, 97, 73 },       new int[] { 10, 22, 27, 39, 61, 68, 69, 73, 97, 100 })]
        [TestCase(new int[] { -85, -30, -67, -70, -18, -28, -17, -1, -9, -2 }, new int[] { -85, -70, -67, -30, -28, -18, -17, -9, -2, -1 })]
        [TestCase(new int[] { 56, -45, 77, -34, -23, 22, 29, -91, -36, 95 },   new int[] { -91, -45, -36, -34, -23, 22, 29, 56, 77, 95 })]
        [TestCase(new int[] { 79, 73, 68, 25, 3, -2, -7, -8, -60, -81 },       new int[] { -81, -60, -8, -7, -2, 3, 25, 68, 73, 79 })]
        public void MergeSortTest(int[] unsorted, int[] sorted)
        {
            Assert.AreEqual(sorted, SortingAlgorithms.MergeArrays(unsorted));
        }
    }
}