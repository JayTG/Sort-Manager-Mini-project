using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class SortingAlgorithms
    {

        public static (int[], int) SortArray(int chosenSort, int[] arrayToSort)
        {
            int[] sortedArray = {};
            DateTime time = DateTime.Now;
            switch (chosenSort)
            {
                case 1:
                    sortedArray = SortingAlgorithms.BubbleSortArray(arrayToSort);
                    break;
                case 2:
                    sortedArray = SortingAlgorithms.MergeArrays(arrayToSort);
                    break;
                case 3:
                    sortedArray = SortingAlgorithms.HeapSort(arrayToSort);
                    break;
            }
            time.Subtract(DateTime.Now);
            return (sortedArray, time.Millisecond);
        }


        public static int[] BubbleSortArray(int[] intArray)
        {
            int temp;
            int[] copy = (int[])intArray.Clone();

            bool sorting = true;
            bool swapped = true;
            do
            {
                if (!swapped)
                {
                    sorting = false;
                }
                swapped = false;
                for (int i = 0; i <= copy.Length; i++)
                {
                    if (i < copy.Length - 1 && copy[i] > copy[i + 1])
                    {
                        temp = copy[i + 1];
                        copy[i + 1] = copy[i];
                        copy[i] = temp;
                        swapped = true;
                    }
                }
            }
            while (sorting);
            return copy;
        }


        public static int[] MergeArrays(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            //As this is a recursive algorithm, we need to have a base case to 
            //avoid an infinite recursion and therfore a stackoverflow
            if (array.Length <= 1)
                return array;
            // The exact midpoint of our array  
            int midPoint = array.Length / 2;
            //Will represent our 'left' array
            left = new int[midPoint];

            //if array has an even number of elements, the left and right array will have the same number of 
            //elements
            if (array.Length % 2 == 0)
                right = new int[midPoint];
            //if array has an odd number of elements, the right array will have one more element than left
            else
                right = new int[midPoint + 1];
            //populate left array
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
            //populate right array   
            int x = 0;
            //We start our index from the midpoint, as we have already populated the left array from 0 to midpoint
            for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            //Recursively sort the left array
            left = MergeArrays(left);
            //Recursively sort the right array
            right = MergeArrays(right);
            //Merge our two sorted arrays
            result = Merge(left, right);
            return result;
        }
        private static int[] HeapSort(int[] array)
        {
            int[] result = (int[])array.Clone();
            int n = result.Length;
            for (int i = n / 2 - 1; i >= 0; i--) 
            {
                Heapify(result, n, i); }
            for (int i = n - 1; i >= 0; i--)
            {
                int temp = result[0];
                result[0] = result[i];
                result[i] = temp;
                Heapify(result, i, 0);
            }
            return result;
        }

        private static void Heapify(int[] array, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && array[left] > array[largest])
                largest = left;
            if (right < n && array[right] > array[largest])
                largest = right;
            if (largest != i)
            {
                int swap = array[i];
                array[i] = array[largest];
                array[largest] = swap;
                Heapify(array, n, largest);
            }
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            //
            int indexLeft = 0, indexRight = 0, indexResult = 0;
            //while either array still has an element
            while (indexLeft < left.Length || indexRight < right.Length)
            {
                //if both arrays have elements  
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    // else the item in the right array wll be added to the results array
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                //if only the left array still has elements, add all its items to the results array
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                //if only the right array still has elements, add all its items to the results array
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }
            }
            return result;
        }


    }
}
