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
        int[] sortedArray = SortingAlgorithms.MergeArrays(test);
        foreach(var i in test)
        {
            Console.Write($"{i}, ");
        }
        foreach (var i in sortedArray)
        {
            Console.Write($"{i}, ");
        }
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
