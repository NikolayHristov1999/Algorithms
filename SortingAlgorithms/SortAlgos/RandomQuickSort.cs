using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    public static class RandomQuickSort
    {
        /// <summary>
        ///     Fast algorithm (little better than merge sort because it is In-Place) and don't use any addition space
        ///     (worst complexity - n^2)
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        public static void Sort(int[] arr)
        {

            int[] coppiedArray = (int[])arr.Clone();
            //var stopwatch = new Stopwatch();
            //stopwatch.Restart();
            Sort(coppiedArray, 0, coppiedArray.Length - 1);

            //stopwatch.Stop();
            //Uncomment to see the sorted array
            //Console.WriteLine(string.Join(", ", coppiedArray));
            //Console.WriteLine($"Quick sort - time elapsed = {stopwatch.ElapsedMilliseconds} ms");
        }
        private static void Sort(int[] arr, int left, int right)
        {
            //To stop the recursion when left and right are equal or right is less
            if (left < right)
            {
                //Find the partition index
                RandomPivotAtMostRightElement(arr, left, right);
                int partitionIndex = Partition(arr, left, right);
                Sort(arr, left, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, right);

            }
        }
        private static int Partition(int[] arr, int left, int right)
        {
            //Choosing a pivot(Randomized)
            int pivot = arr[right];
            int leftIndex = left;

            for (int i = left; i < right; i++)
            {
                if (arr[i] <= pivot)
                {


                    int tmp = arr[leftIndex];
                    arr[leftIndex] = arr[i];
                    arr[i] = tmp;

                    leftIndex++;
                }
            }
            int temp = arr[leftIndex];
            arr[leftIndex] = arr[right];
            arr[right] = temp;

            return leftIndex;
        }

        private static void RandomPivotAtMostRightElement(int[] arr, int left, int right)
        {
            //TO DO:
            //There can be written custom random function that will give better results
            int random = GenerateRandomNumber(left, right);

            int tmp = arr[right];
            arr[right] = arr[random];
            arr[random] = tmp;
        }

        private static int GenerateRandomNumber(int left, int right)
        {
            int random = (333 * 757) % right;
            return random;

        }
    }
}
