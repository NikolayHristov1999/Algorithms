using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    public static class InsertionSort
    {
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();

            for (int i = 1; i < coppiedArray.Length; i++)
            {
                int num = coppiedArray[i];
                int j = i - 1;
                while (j >= 0 && coppiedArray[j] > num)
                {
                    coppiedArray[j + 1] = coppiedArray[j];
                    j = j - 1;
                }
                coppiedArray[j + 1] = num;
            }

        }
    }
}
