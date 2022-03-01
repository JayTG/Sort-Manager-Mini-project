using System;

namespace SortManagerApp;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Choose an sorting algorithm.");
        Console.WriteLine("[1] Bubble, [2] Merge");
        Console.Write("Please input a number: ");
        int sortInput = Convert.ToInt32(Console.ReadLine());
        //set sorting stuff here
        Console.WriteLine("Type in the length of the array");
        Console.Write("Please input a number: ");
        int lenInput = Convert.ToInt32(Console.ReadLine());
        //set array length here

        //Adam testing space
        int[] test = { 4,5,2,7,3}; // {2,3,4,5,7}
        DateTime time = DateTime.Now;
        int[] sortedArray = SortingAlgorithms.MergeArrays(test);
        time.Subtract(DateTime.Now);
        foreach(var i in test)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        foreach (var i in sortedArray)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine($"It took exactly: {time.Millisecond}ms");
        
        int[] test2 = { 4,5,2,7,3,7}; // {2,3,4,5,7}
        DateTime time2 = DateTime.Now;
        int[] sortedArray2 = SortingAlgorithms.BubbleSortArray(test2);
        time2.Subtract(DateTime.Now);
        foreach(var i in test2)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine();
        foreach (var i in sortedArray2)
        {
            Console.Write($"{i}, ");
        }
        Console.WriteLine($"It took exactly: {time2.Millisecond}ms");
        //EndOfAdamTestingSpace
    }

    public static int[] bubbleSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] mergeSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] heapSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] selectionSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] insertionSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] shellSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] quickSort(int[] arr)
    {
        throw new NotImplementedException();
    }

}
