using System;

namespace SortManagerApp;

public class Program
{
    public static int[] arrayToSort;
    public static int[] sortedArray;
    public static int chosenSort;
    public static int time = 0;
    public static bool running = true;
    public static ISortingAlgorithm algorithm;
    public static string chosenText;

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
            Console.WriteLine("[1] Bubble, [2] Merge, [3] Heap, [4] Selection, [5] Insertion, [6] Quick, [7] Shell | [0] Quit");
            Console.Write("To select, enter a number: ");
            string input = Console.ReadLine();

            if (Int32.TryParse(input, out chosenSort))
            {
                switch (chosenSort)
                {
                    case 0:
                        Console.WriteLine("\nQuitting App");
                        System.Environment.Exit(0);
                        break;
                    case 1:
                        chosenText = "Bubble Sort";
                        chosen = true;
                        algorithm = new BubbleSort();
                        break;
                    case 2:
                        chosenText = "Merge Sort";
                        chosen = true;
                        algorithm = new MergeSort();
                        break;
                    case 3:
                        chosenText = "Heap Sort";
                        chosen = true;
                        algorithm = new HeapSort();
                        break;
                    case 4:
                        chosenText = "Selection Sort";
                        chosen = true;
                        algorithm = new SelectionSort();
                        break;
                    case 5:
                        chosenText = "Insertion Sort";
                        chosen = true;
                        algorithm = new InsertionSort();
                        break;
                     case 6:
                        chosenText = "Quick Sort";
                        chosen = true;
                        algorithm = new QuickSort();
                        break;
                    case 7:
                        chosenText = "Shell Sort";
                        chosen = true;
                        algorithm = new ShellSort();
                        break;
                    default:
                        Console.WriteLine("\nInvaild selection, please try again.\n");
                        break;
                }
            }
            else
                continue;
        }
        Console.WriteLine($"\nYou have chosen {chosenText}.");

    }

    static void ChooseLength()
    {
        bool vaild = false;
        
        while (!vaild)
        {
            Console.WriteLine("Generate unsorted array. (max length 10000)");
            Console.Write("To generate, enter array length: ");
            string input = Console.ReadLine();
            int lenInput;
            if(Int32.TryParse(input,out lenInput))
            {
                if (lenInput < 1 || lenInput > 10000)
                    Console.WriteLine("\nInvaild array length, please try again.\n");
                else
                {
                    Console.WriteLine("\nUnsorted Array:");
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
    
    static string GetArrayString(int[] array)
    {
        int j = 0;
        string arrayString = "{";
        foreach (var i in array)
        {
            if (++j % 15 == 0) arrayString += $"{i},".PadLeft(6).PadRight(3) + "\n ";
            else arrayString += $"{i},".PadLeft(6).PadRight(3);
        }
        return arrayString.TrimEnd(',') + "}";
    }
    

    static void DisplaySortedArray()
    {
        Console.WriteLine("");
        Console.WriteLine("Sorted Array");
        (sortedArray, time) = algorithm.SortArray(arrayToSort);
        Console.WriteLine(GetArrayString(sortedArray));
        Console.WriteLine($"\nTime taken: {time}ms\n");
    }

}