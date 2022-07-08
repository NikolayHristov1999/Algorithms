using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    public static class SelectionSort
    {
        /// <summary>
        ///     Selection sort ( Worst case = n^2) (Slightly better than bubble sort)
        /// </summary>
        /// <param name="arr">The array</param>
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();

            for (int i = 0; i < coppiedArray.Length - 1; i++)
            {
                int indexOfMin = 0;

                for (int j = i + 1; j < coppiedArray.Length; j++)
                {
                    if (coppiedArray[indexOfMin] > coppiedArray[j])
                    {
                        indexOfMin = j;
                    }
                }
                int tmp = coppiedArray[indexOfMin];
                coppiedArray[indexOfMin] = coppiedArray[i];
                coppiedArray[i] = tmp;
            }
        }
    }
}
