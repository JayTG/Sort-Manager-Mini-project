using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class QuickSort : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            int start = 0;
            int end = array.Length - 1;
            SortLoop(array, start, end);
            return array;
        }

        private void SortLoop(int[] array, int start, int end)
        {
            int i;
            if (start < end)
            {
                i = Partition(array, start, end);

                SortLoop(array, start, i - 1);
                SortLoop(array, i + 1, end);
            }
        }

        private int Partition(int[] array, int start, int end)
        {
            int temp;
            int p = array[end];
            int i = start - 1;

            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] <= p)
                {
                    i++;
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }

            temp = array[i + 1];
            array[i + 1] = array[end];
            array[end] = temp;
            return i + 1;
        }

    }
}
