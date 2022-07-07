using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    /// <summary>
    ///     Use Sort(arr) to sort the array with merge sort
    /// </summary>
    public static class MergeSort
    {
        /// <summary>
        ///     Method that implements merge sort (worst complexity - n*log(n))
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        /// <param name="stopwatch"></param>
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();
            Sort(coppiedArray, 0, coppiedArray.Length - 1);
            //Uncomment to see the sorted array
            //Console.WriteLine(string.Join(", ",coppiedArray));
            //Console.WriteLine($"Merge sort - time elapsed = {stopwatch.ElapsedMilliseconds} ms");
        }
        private static void Merge(int[] arr, int left, int middle, int right)
        {
            //Find the size of the two arrays
            int leftSize = middle - left + 1;
            int rightSize = right - middle;
            
            //Initiliaze two arrays with the appropriate size
            int[] leftArr = new int[leftSize];
            int[] rightArr = new int[rightSize];

            //Initiliaze the arrays with the appropriate numbers
            for (int i = 0; i < leftSize; i++)
            {
                leftArr[i] = arr[left + i];
            }
            for (int i = 0; i < rightSize; i++)
            {
                rightArr[i] = arr[middle + 1 + i];
            }
            //Initialize indexes for the two arrays
            int leftIndex = 0, rightIndex = 0, currentIndex;
            for (currentIndex = left; leftIndex < leftSize && rightIndex < rightSize; currentIndex++)
            {
                //If the left number of the current leftIndex is bigger than the right number in the currentRightIndex
                if (leftArr[leftIndex] <= rightArr[rightIndex])
                {
                    arr[currentIndex] = leftArr[leftIndex];
                    leftIndex++;
                }
                //If the left number of the current leftIndex is smaller than the right number in the currentRightIndex
                else
                {
                    arr[currentIndex] = rightArr[rightIndex];
                    rightIndex++;
                }
            }
            //If there are numbers left in the left array add them till the end
            for (; leftIndex < leftSize; currentIndex++, leftIndex++)
            {
                //Adding the number in the whole array
                arr[currentIndex] = leftArr[leftIndex];
            }
            //If there are numbers left in the right array add them till the end
            for (; rightIndex < rightSize; currentIndex++, rightIndex++)
            {
                //Adding the number in the whole array
                arr[currentIndex] = rightArr[rightIndex];
            }

        }
        private static void Sort(int[] arr, int left, int right)
        {
            if (left < right)
            {
                //Find the middle point
                int middle = left + (right - left) / 2;
                Sort(arr, left, middle);
                Sort(arr, middle + 1, right);
                Merge(arr, left, middle, right);
            }
        }
    } 
}
