using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class ShellSort : ISortingAlgorithm
    {
        public int[] Sort(int[] array)
        {
            int array_size = array.Length;
            int i, j, inc, temp;
            int[] copy = (int[])array.Clone();
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < array_size; i++)
                {
                    j = i;
                    temp = copy[i];
                    while ((j >= inc) && (copy[j - inc] > temp))
                    {
                        copy[j] = copy[j - inc];
                        j = j - inc;
                    }
                    copy[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }
            return copy;
        }
    }
}
