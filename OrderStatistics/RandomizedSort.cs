using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStatistics
{
    public static class RandomizedSort
    {
        public static int Partition(int[] arr, int left, int right)
        {
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

    }
}
