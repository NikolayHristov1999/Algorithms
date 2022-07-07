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
            int[] output = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                int tmp = arr[i];
                tmpArr[tmp]++;
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
            //for (int i = 1; i < tmpArr.Length; ++i)
            //{
            //    tmpArr[i] += tmpArr[i - 1];
            //}

            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    output[tmpArr[arr[i]] - 1] = arr[i];
            //    --tmpArr[arr[i]];
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = output[i];
            //}
        }
    }
}
