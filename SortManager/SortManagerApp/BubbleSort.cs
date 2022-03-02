using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    internal class BubbleSort : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            int temp;
            int[] copy = (int[])array.Clone();

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
    }
}
