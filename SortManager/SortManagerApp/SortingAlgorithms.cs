using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class SortingAlgorithms
    {
        public static void BubbleSortArray(int[] intArray)
        {
            int temp;

            bool sorting = true;
            bool swapped = true;
            do
            {
                if (!swapped)
                {
                    sorting = false;
                }
                swapped = false;
                for (int i = 0; i <= intArray.Length; i++)
                {
                    if (i < intArray.Length - 1 && intArray[i] > intArray[i + 1])
                    {
                        temp = intArray[i + 1];
                        intArray[i + 1] = intArray[i];
                        intArray[i] = temp;
                        swapped = true;
                    }
                }
            }
            while (sorting);
        }
        public static int[] MergeArrays(int[] array1, int[] array2)
        {
            int[] temp = new int[array1.Length + array2.Length];
            if (array1[array1.Length - 1] < array2[array2.Length - 1])
            {
                array1.CopyTo(temp, 0);
                array2.CopyTo(temp, array1.Length);
            }
            else if (array2[array2.Length - 1] < array1[array1.Length - 1])
            {
                array2.CopyTo(temp, 0);
                array1.CopyTo(temp, array2.Length);
            }
            else
            {
                throw new Exception("Arrays are not sorted!");
            }
            Array.Sort(temp);
            return temp;
        }


    }
}
