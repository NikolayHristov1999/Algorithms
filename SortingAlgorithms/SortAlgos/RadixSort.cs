using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SortingAlgorithms.SortAlgos
{
    public static class RadixSort
    {
        private const int DECIMAL_NUMBER = 10;
        public static void Sort(int[] arr)
        {
            int[] coppiedArray = (int[])arr.Clone();
            int max = coppiedArray.Max();
            //for (int place = 1; max / place > 0; place *= 10)
            //    CountingSort(coppiedArray, place);
            Sort(coppiedArray, max);
            //Uncomment to see the sorted array
            //Console.WriteLine(string.Join(", ", coppiedArray));
        }
        private static void Sort(int[] arr, int max)
        {
            
            //List<Queue<int>> bucket = new List<Queue<int>>(10);
            
            Queue<int>[] bucket = new Queue<int>[DECIMAL_NUMBER];
            for (int i = 0; i < DECIMAL_NUMBER; i++)
            {
                bucket[i] = new Queue<int>();
            }
            int lastDivider = 1;
            while (lastDivider <= max)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    int index = (arr[i] / lastDivider) % 10;
                    bucket[index].Enqueue(arr[i]);
                }

                for (int i = 0, index = 0; i < bucket.Length; i++)
                {
                    while(bucket[i].Count > 0)
                    {
                        arr[index] = bucket[i].Dequeue();
                        index++;
                    }
                }
                lastDivider *= 10;

            }                                 
            
        }
    }
}
