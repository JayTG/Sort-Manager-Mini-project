using System;

namespace SortManagerApp;

public class Program
{
    public static int[] arrayToSort;
    public static int[] sortedArray;
    public static int chosenSort = 0;

    public static void Main()
    {
        ChooseSorting();
        ChooseLength();
        //set array length here
        //Adam testing space
        //int[] test = { 4, 5, 2, 7, 3 }; // {2,3,4,5,7}
        //DateTime time = DateTime.Now;
        //int[] sortedArray = SortingAlgorithms.MergeArrays(test);
        //time.Subtract(DateTime.Now);
        //foreach (var i in test)
        //{
        //    Console.Write($"{i}, ");
        //}
        //Console.WriteLine();
        //foreach (var i in sortedArray)
        //{
        //    Console.Write($"{i}, ");
        //}
        //Console.WriteLine($"It took exactly: {time.Millisecond}ms");

        //int[] test2 = { 4, 5, 2, 7, 3, 7 }; // {2,3,4,5,7}
        //DateTime time2 = DateTime.Now;
        //int[] sortedArray2 = SortingAlgorithms.BubbleSortArray(test2);
        //time2.Subtract(DateTime.Now);
        //foreach (var i in test2)
        //{
        //    Console.Write($"{i}, ");
        //}
        //Console.WriteLine();
        //foreach (var i in sortedArray2)
        //{
        //    Console.Write($"{i}, ");
        //}
       // Console.WriteLine($"It took exactly: {time2.Millisecond}ms");

        //EndOfAdamTestingSpace
    }

    static void ChooseSorting()
    {
        bool chosen = false;
        while (!chosen)
        {
            Console.WriteLine("Choose a sorting algorithm.");
            Console.WriteLine("[1] Bubble, [2] Merge");
            Console.Write("Please input a number: ");
            string input = Console.ReadLine();
            int num;

            if (Int32.TryParse(input, out num))
            {
                switch (num)
                {
                    case 1:
                        Console.WriteLine("You have choosen the Bubble Sort!");
                        chosen = true;
                        chosenSort = num; //setting global chosenSort
                        break;
                    case 2:
                        Console.WriteLine("You have choosen the Merge Sort!");
                        chosen = true;
                        chosenSort = num;
                        break;
                    default:
                        Console.WriteLine("Invaild number entered");
                        break;
                }
            }
            else
                continue;

        }
    }

    static void ChooseLength()
    {
        bool vaild = false;
        
        while (!vaild)
        {
            Console.WriteLine("Type in the length of the array"); 
            Console.Write("Please input a number: ");
            string input = Console.ReadLine();
            int lenInput;
            if(Int32.TryParse(input,out lenInput))
            {
                if (lenInput < 1)
                    Console.WriteLine("Invaild number entered");
                else
                {
                    Console.WriteLine("Unsorted Array:");
                    arrayToSort = ArrayGeneration.Generate(lenInput);
                    foreach (var i in arrayToSort)
                    {
                        Console.Write($"{i}, ");
                    }
                    break;
                }
            }
            else
            {
                continue;
            }
        }
      
    }
    //public static int[] BubbleSort(int[] arr)
    //{
    //    throw new NotImplementedException();
    //}
    //public static int[] MergeSort(int[] arr)
    //{
    //    throw new NotImplementedException();
    //}
    public static int[] HeapSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] SelectionSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] InsertionSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] ShellSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] QuickSort(int[] arr)
    {
        throw new NotImplementedException();
    }

}
