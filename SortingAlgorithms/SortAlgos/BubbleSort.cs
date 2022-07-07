using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    /// <summary>
    ///     Sorting element with bubble sort(Worst case - n^2) never use this algorithm
    /// </summary>
    public static class BubbleSort
    {

        /// <summary>
        ///     Sorting element with bubble sort(Worst case - n^2) never use this algorithm
        /// </summary>
        /// <param name="arr">The array to be sorted</param>
        public static void Sort(int[] arr)
        {

            int[] coppiedArray = (int[])arr.Clone();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                //TODO: bubble sort with flag
                bool swapped = false;
                for (int j = 1; j < coppiedArray.Length - i; j++)
                {
                    if (coppiedArray[j - 1] > coppiedArray[j])
                    {
                        //Bubble sort is slower than selection sort bcs swapping everytime is a slow operation
                        swapped = true;
                        int tmp = coppiedArray[j];
                        coppiedArray[j] = coppiedArray[j - 1];
                        coppiedArray[j - 1] = tmp;
                    }
                }
                if (swapped == false)
                {
                    break;
                }
            }
        }
    }
}
