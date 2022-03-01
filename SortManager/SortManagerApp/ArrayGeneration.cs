using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortManagerApp
{
    public class ArrayGeneration
    {
        public static int[] Generate(int leng)
        {
            int Min = -100;
            int Max = 100;
            
            int[] arr = new int[leng];

            Random randNum = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = randNum.Next(Min, Max);
            }

            return arr;
        }
    }
}
