using System;
using System.Linq;
using System.Diagnostics;

class AssertionsHomework
{
    //Add assertions in the code from the project "Assertions-Homework" to ensure all possible preconditions and postconditions are checked.


    public static void SelectionSort<T>(T[] arr) where T : IComparable<T>
    {
        byte emptyArray = 0;
        Debug.Assert(arr.Length > emptyArray, "Cant sort empty array");
        byte singleItem = 1;
        Debug.Assert(singleItem < arr.Length, "Imposible to sort single item.");


        for (int index = 0; index < arr.Length - 1; index++)
        {
            int minElementIndex = FindMinElementIndex(arr, index, arr.Length - 1);
            Swap(ref arr[index], ref arr[minElementIndex]);
        }
    }

    private static int FindMinElementIndex<T>(T[] arr, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        //Simple index rules.
        Debug.Assert((startIndex < endIndex), "Start index cant be above end index.");
        Debug.Assert((startIndex >= -1), "Start index must be positive or zero number.");

        int minElementIndex = startIndex;

        for (int i = startIndex + 1; i <= endIndex; i++)
        {
            if (arr[i].CompareTo(arr[minElementIndex]) < 0)
            {
                minElementIndex = i;
            }
        }

        return minElementIndex;
    }

    private static void Swap<T>(ref T x, ref T y)
    {
        T oldX = x;
        x = y;
        y = oldX;
    }

    public static int BinarySearch<T>(T[] arr, T value) where T : IComparable<T>
    {
        //Check array is it sorted.
        bool isSorted = false;
        int length = arr.Length;

        for (int i = 0; i < length - 1; i++)
        {
            if (arr[i].CompareTo(arr[i + 1]) < 0)
            {
                isSorted = true;
            }

            else
            {
                isSorted = false;
            }
        }

        Debug.Assert(isSorted, "Your array must be sorted before use BinarySearch.");

        return BinarySearch(arr, value, 0, arr.Length - 1);
    }

    private static int BinarySearch<T>(T[] arr, T value, int startIndex, int endIndex)
        where T : IComparable<T>
    {
        Debug.Assert(startIndex < endIndex, "Start index need to be below end index.");
        Debug.Assert(startIndex > -1, "Start index cant be negative.");
        Debug.Assert(endIndex > 0, "End index cant be negative.");

        while (startIndex <= endIndex)
        {
            int midIndex = (startIndex + endIndex) / 2;

            if (arr[midIndex].Equals(value))
            {
                return midIndex;
            }

            if (arr[midIndex].CompareTo(value) < 0)
            {
                // Search on the right half
                startIndex = midIndex + 1;
            }
            else
            {
                // Search on the right half
                endIndex = midIndex - 1;
            }
        }

        // Searched value not found
        return -1;
    }

    static void Main()
    {
        int[] arr = new int[] { 3, -1, 15, 4, 17, 2, 33, 0 };
        Console.WriteLine("arr = [{0}]", string.Join(", ", arr));
        SelectionSort(arr);
        Console.WriteLine("sorted = [{0}]", string.Join(", ", arr));

        SelectionSort(new int[0]); // Test sorting empty array
        SelectionSort(new int[1]); // Test sorting single element array

        Console.WriteLine(BinarySearch(arr, -1000));
        Console.WriteLine(BinarySearch(arr, 0));
        Console.WriteLine(BinarySearch(arr, 17));
        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(BinarySearch(arr, 1000));
    }
}
