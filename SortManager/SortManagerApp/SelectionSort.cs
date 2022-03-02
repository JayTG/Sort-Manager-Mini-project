using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class SelectionSort : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            int i, j, min_idx;
            int n = array.Length;
            int[] copy = (int[])array.Clone();

            // One by one move boundary of unsorted subarray 
            for (i = 0; i < n - 1; i++)
            {
                // Find the minimum element in unsorted array 
                min_idx = i;
                for (j = i + 1; j < n; j++)
                    if (copy[j] < copy[min_idx])
                        min_idx = j;

                // Swap the found minimum element with the first element 
                int temp = copy[min_idx];
                copy[min_idx] = copy[i];
                copy[i] = temp;
            }
            return copy;
        }
    }
}
