using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public interface ISortingAlgorithm
    {
        (int[], int) SortArray(int chosenSort, int[] arrayToSort)
        {
            int[] sortedArray = { };
            DateTime time = DateTime.Now;
            sortedArray = Sort(arrayToSort);
            time.Subtract(DateTime.Now);
            return (sortedArray, time.Millisecond);
        }

        int[] Sort(int[] array);
    }
}
