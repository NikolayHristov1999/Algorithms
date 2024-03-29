﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    /// <summary>
    ///     Use Sort(arr) to sort the array with quick sort
    /// </summary>
    public static class QuickSort
    {
        /// <summary>
        ///     Fast algorithm (little better than merge sort because it is In-Place) and don't use any addition space
        ///     (worst complexity - n^2)
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        public static void Sort(int[] arr)
        {
            
            int[] coppiedArray = (int[])arr.Clone();
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
                int partitionIndex = Partition(arr, left, right);
                Sort(arr, left, partitionIndex - 1);
                Sort(arr, partitionIndex + 1, right);
                
            }
        }
        //Finds the partition index
        private static int Partition(int[] arr, int left, int right)
        {
            //Choosing a pivot(there are randomizing algos to choose the right pivot but for now we choose the right one)
            int pivot = arr[right];
            int leftIndex = left;
            
            for(int i = left; i < right; i++)
            {
                if(arr[i] <= pivot)
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
    }
}
