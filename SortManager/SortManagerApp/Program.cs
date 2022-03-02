using System;

namespace SortManagerApp;

public class Program
{
    public static int[] arrayToSort;
    public static int[] sortedArray;
    public static int chosenSort = 0;
    public static int time = 0;

    public static void Main()
    {
        
        do
        {
            ChooseSorting();
            ChooseLength();
            DisplaySortedArray();
        }
        while (true);
        //arrayToSort = new int[]{4,5,2,7,3};
        //(sortedArray, time) = SortingAlgorithms.SortArray(chosenSort, arrayToSort);
    }

    public static void ChooseSorting()
    {
        bool chosen = false;
        while (!chosen)
        {
            Console.WriteLine("Available sorting algorithms.");
            Console.WriteLine("[1] Bubble, [2] Merge, [3] Heap | [0] Quit");
            Console.Write("To select, enter a number: ");
            string input = Console.ReadLine();
            int num;

            if (Int32.TryParse(input, out num))
            {
                switch (num)
                {
                    case 0:
                        Console.WriteLine("Quitting App");
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("\nYou have chosen Bubble Sort.");
                        chosen = true;
                        chosenSort = num;
                        break;
                    case 2:
                        Console.WriteLine("\nYou have chosen Merge Sort.");
                        chosen = true;
                        chosenSort = num;
                        break;
                    case 3:
                        Console.WriteLine("You have choosen the Heap Sort!");
                        chosen = true;
                        chosenSort = num;
                        break;
                    default:
                        Console.WriteLine("Invaild selection, please try again.\n");
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
            Console.WriteLine("Generate unsorted array.");
            Console.Write("To generate, enter array length: ");
            string input = Console.ReadLine();
            int lenInput;
            if(Int32.TryParse(input,out lenInput))
            {
                if (lenInput < 1)
                    Console.WriteLine("Invaild array length, please try.");
                else
                {
                    Console.WriteLine("Unsorted Array:");
                    arrayToSort = ArrayGeneration.Generate(lenInput);
                    Console.WriteLine(GetArrayString(arrayToSort));
                    break;
                }
            }
            else
            {
                continue;
            }
        }
      
    }
    static void DisplaySortedArray()
    {
        Console.WriteLine("");
        Console.WriteLine("Sorted Array");
        (sortedArray, time) = SortingAlgorithms.SortArray(chosenSort, arrayToSort);
        Console.WriteLine(GetArrayString(sortedArray));
        Console.WriteLine("");
        Console.WriteLine($"Time taken: {time}ms");
    }

    static string GetArrayString(int[] array)
    {
        string arrayString = "{";
        foreach (var i in array)
        {
            arrayString += $" {i},";
        }
        return arrayString.TrimEnd(',') + " }";
    }

    //public static int[] BubbleSort(int[] arr)
    //{
    //    throw new NotImplementedException();
    //}
    //public static int[] MergeSort(int[] arr)
    //{
    //    throw new NotImplementedException();
    //}
    //public static int[] HeapSort(int[] arr)
    //{
    //    throw new NotImplementedException();
    //}
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