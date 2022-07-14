using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortAlgos
{
    public static class BucketSort
    {

        /// <summary>
        ///     Sorts array arr where arr[i] >= 0 && arr[i] < 1
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="floatingPointSize">
        /// the size of the bucket arr(numbers after the floating point used to store)
        /// </param>
        public static void Sort(double[] arr, int floatingPointSize)
        {
            var bucketArr = new List<double>[floatingPointSize];

            for (int i = 0; i < floatingPointSize; i++)
            {
                bucketArr[i] = new List<double>();
            }

            for (int i = 0; i < arr.Length; i++)
            {
                int index = (int)(floatingPointSize * arr[i]);
                bucketArr[index].Add(arr[i]);
            }

            int currentIndex = 0;
            foreach (var listArr in bucketArr)
            {
                listArr.Sort();
                foreach (var value in listArr)
                {
                    arr[currentIndex] = value;
                    currentIndex++;
                }
            }
        }
    }
}
