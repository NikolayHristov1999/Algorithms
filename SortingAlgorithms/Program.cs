
using DataStructures;
using SortingAlgorithms.SortAlgos;
using System;
using System.Diagnostics;

namespace Algorithms
{
    public class StartUp
    {
        //If the array length is more than 10_000_000 remove count sort test
        const int ARRAY_LENGTH = 10_000_000;
        static void Main(string[] args)
        {
            
            int[] arr = CreateArray(ARRAY_LENGTH);

            //RunSortAlgorithm(BubbleSort.Sort, arr, nameof(BubbleSort));
            //RunSortAlgorithm(SelectionSort.Sort, arr, nameof(SelectionSort));
            //RunSortAlgorithm(InsertionSort.Sort, arr, nameof(InsertionSort));
            RunSortAlgorithm(MergeSort.Sort, arr, nameof(MergeSort));
            RunSortAlgorithm(QuickSort.Sort, arr, nameof(QuickSort));
            RunSortAlgorithm(RandomQuickSort.Sort, arr, nameof(RandomQuickSort));
            RunSortAlgorithm(CountingSort.Sort, arr, nameof(CountingSort));
            RunSortAlgorithm(RadixSort.Sort, arr, nameof(RadixSort));
            RunSortAlgorithm(HeapSort.Sort, arr, nameof(HeapSort));


            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var output = arr.OrderBy(arr => arr);
            
            stopwatch.Stop();
            Console.WriteLine($"Linq - time elapsed = {stopwatch.ElapsedMilliseconds} ms");
        }
        private static void RunSortAlgorithm(Action<int[]> sortingMethod, int[] arr, string name)
        {
            var coppiedArr = CopyArr(arr);
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            sortingMethod.Invoke(coppiedArr);
            stopwatch.Stop();
            Console.WriteLine($"{name} - time elapsed = {stopwatch.ElapsedMilliseconds} ms");

        }

        private static int[] CreateArray(int length)
        {
            int[] arr = new int[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, ARRAY_LENGTH);

            }
            return arr;
        }

        private static void PrintArray(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
            Console.WriteLine();
        }

        private static T[] CopyArr<T>(T[] arr)
        {
            var tmp = new T[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                tmp[i] = arr[i];
            }

            return tmp;
        }

        private static void isSorted(int[] arr)
        {
            
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < arr[i - 1])
                {
                    Console.WriteLine("Not sorted");
                    return;
                }
            }
            Console.WriteLine("Sorted");
        }

    }
}
