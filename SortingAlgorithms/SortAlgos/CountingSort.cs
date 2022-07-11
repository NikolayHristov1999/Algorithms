using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    public static class CountingSort
    {
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();
            int max = coppiedArray.Max();
            Sort(coppiedArray, max);

            //Uncomment to see the sorted array
            //Console.WriteLine(string.Join(", ", coppiedArray));
        }
        private static void Sort(int[] arr, int max)
        {
            int[] tmpArr = new int[max + 1];

            for (int i = 0; i < arr.Length; i++)
            {
                tmpArr[arr[i]]++;
            }

            int index = 0;
            for (int i = 0; i < tmpArr.Length; i++)
            {
                while (tmpArr[i] > 0)
                {
                    arr[index] = i;
                    tmpArr[i]--;
                    index++;
                }
            }
        }
    }
}
