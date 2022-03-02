using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    internal class HeapSort : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            int[] result = (int[])array.Clone();
            int n = result.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(result, n, i);
            }
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
    }
}
