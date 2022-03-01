namespace SortManagerApp;

public class Program
{
    public static void Main()
    {
        ChooseSorting();
        ChooseLength();
        //set array length here
    }

    static void ChooseSorting()
    {
        bool chosen = false;
        while (!chosen)
        {
            Console.WriteLine("Choose an sorting algorithm.");
            Console.WriteLine("[1] Bubble, [2] Merge");
            Console.Write("Please input a number: ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("You have choosen the Bubble Sort!");
                    chosen = true;
                    break;
                case 2:
                    Console.WriteLine("You have choosen the Merge Sort!");
                    chosen = true;
                    break;
                default:
                    Console.WriteLine("Invaild number entered");
                    break;
            }
            
        }
    }

    static void ChooseLength()
    {
        bool vaild = false;
        while (!vaild)
        {
            Console.WriteLine("Type in the length of the array");
            Console.Write("Please input a number: ");
            int lenInput = Convert.ToInt32(Console.ReadLine());
            if (lenInput < 1)
                Console.WriteLine("Invaild number entered");
            else
                break;
        }
        
    }

    public static int[] BubbleSort(int[] arr)
    {
        throw new NotImplementedException();
    }
    public static int[] MergeSort(int[] arr)
    {
        throw new NotImplementedException();
    }
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
