using SortingAlgorithms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class PriorityQueue
    {
        public Heap Heap { get; set; }

        public PriorityQueue(List<int> arr)
        {
            Heap = new Heap(arr);
            Heap.BuildMaxHeap(arr.Count);
        }

        public int MaxHeapMaximum()
        {
            if (Heap.HeapArr.Count < 1)
            {
                throw new Exception("Empty heap");
            }
            return Heap.HeapArr[0];
        }

        public int MaxHeapExtractMax()
        {
            int max = MaxHeapMaximum();

            Heap.HeapArr[0] = Heap.HeapArr[Heap.HeapArr.Count - 1];
            Heap.HeapArr.RemoveAt(Heap.HeapArr.Count - 1);

            Heap.MaxHeapify(0, Heap.HeapArr.Count);
            return max;
        }

        /// <summary>
        ///     Increase the value of element at given index
        /// </summary>
        /// <param name="index">Index of the value</param>
        /// <param name="newValue"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public int MaxHeapIncreaseKey(int index, int newValue)
        {
            if (index < 0 || index >= Heap.HeapArr.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (newValue < Heap.HeapArr[index])
            {
                throw new ArgumentException("The new value must be greater or equal to the old value");
            }

            Heap.HeapArr[index] = newValue;
            int parentIndex = Heap.IndexOfParent(index);
            while (index > 0 && newValue > Heap.HeapArr[parentIndex])
            {
                var tmp = Heap.HeapArr[index];
                Heap.HeapArr[index] = Heap.HeapArr[parentIndex];
                Heap.HeapArr[parentIndex] = tmp;

                index = parentIndex;
                parentIndex = Heap.IndexOfParent(index);
            }
            return index;
        }

        public int MaxHeapInsert(int value)
        {
            Heap.HeapArr.Add(value);
            return MaxHeapIncreaseKey(Heap.HeapArr.Count - 1, value);
        }
    }
}
