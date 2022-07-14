using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderStatistics
{
    public class Program
    {
        const int ARRAY_LENGTH = 1_000_000;
        private static int[] testArr = new int[] { 20, 9, 17, 4, 1, 33, 7, 5, 11, 2 };
        static void Main(string[] args)
        {
            int[] arr = CreateArray(ARRAY_LENGTH);
            var answer = RandomizedSelect(arr, 0, testArr.Length - 1, 3);
            Console.WriteLine(answer);
        }
        public static int RandomizedSelect(int[] arr, int left, int right, int searchedOrder)
        {
            if (left == right)
            {
                return arr[left];
            }
            int pivotIndex = RandomizePartition(arr, left, right);

            int k = pivotIndex + 1;
            if (searchedOrder == k)
            {
                return arr[pivotIndex];
            }
            else if (searchedOrder < k)
            {
                return RandomizedSelect(arr, left, pivotIndex - 1, searchedOrder);
            }
            return RandomizedSelect(arr, pivotIndex + 1, right, searchedOrder);
        }

        private static int[] CreateArray(int length)
        {
            int[] arr = new int[length];
            var random = new Random();
            for (int i = 0; i < length; i++)
            {
                arr[i] = random.Next(0, ARRAY_LENGTH);

            }
            return arr;
        }

        private static void SwapElements(int[] arr, int a, int b)
        {
            var tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }


        private static int RandomizePartition(int[] arr, int left, int right)
        {
            var rand = new Random();
            var pivot = rand.Next(left, right);
            SwapElements(arr, pivot, right);

            return RandomizedSort.Partition(arr, left, right);
        }
    }
}
