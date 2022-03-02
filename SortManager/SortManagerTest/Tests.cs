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

        public static readonly object[] _ArraysToTest =
        {
            new object[]{new int[]{ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 } },
            new object[]{ new int[] { -85, -30, -67, -70, -18, -28, -17, -1, -9, -2 }, new int[] { -85, -70, -67, -30, -28, -18, -17, -9, -2, -1 } },
            new object[]{ new int[] { 56, -45, 77, -34, -23, 22, 29, -91, -36, 95 }, new int[] { -91, -45, -36, -34, -23, 22, 29, 56, 77, 95 } },
            new object[] { new int[] { 79, 73, 68, 25, 3, -2, -7, -8, -60, -81 }, new int[] { -81, -60, -8, -7, -2, 3, 25, 68, 73, 79 } }
        };

        [TestCaseSource("_ArraysToTest")]
        public void BubbleSortTest(int[] unsorted, int[] sorted)
        {
            ISortingAlgorithm algorithm = new BubbleSort();
            Assert.AreEqual(sorted, algorithm.Sort(unsorted));
        }

        [TestCaseSource("_ArraysToTest")]
        public void MergeSortTest(int[] unsorted, int[] sorted)
        {
            ISortingAlgorithm algorithm = new MergeSort();
            Assert.AreEqual(sorted, algorithm.Sort(unsorted));
        }

        [TestCaseSource("_ArraysToTest")]
        public void HeapeSortTest(int[] unsorted, int[] sorted)
        {
            ISortingAlgorithm algorithm = new HeapSort();
            Assert.AreEqual(sorted, algorithm.Sort(unsorted));
        }
        [Test]
        public void RandomArrayContainsNumbersBetween_Minus100And100()
        {
            int[] rand = ArrayGeneration.Generate(101);
            Assert.That(rand, Is.All.GreaterThan(-101));
            Assert.That(rand, Is.All.LessThan(101));
        }
        [TestCase(0)]
        [TestCase(1)]
        [TestCase(100)]
        [TestCase(500)]
        [TestCase(10000)]
        public void RandomArrayLengthIsEqualToUserInput(int leng)
        {
            int[] rand = ArrayGeneration.Generate(leng);
            Assert.That(rand.Length, Is.EqualTo(leng));
        }
    }
}