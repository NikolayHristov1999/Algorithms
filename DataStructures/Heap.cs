using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Heap
    {
        public List<int> HeapArr { get; set; }

        public Heap(List<int> arr)
        {
            HeapArr = arr;
        }

        

        public int IndexOfParent(int currentIndex)
        {
            return (currentIndex - 1) / 2;
        }

        /// <summary>
        ///     Returns the index of the left child
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <returns></returns>
        public int IndexOfLeftChild(int currentIndex)
        {
            return currentIndex * 2 + 1;
        }

        /// <summary>
        ///     Returns the index of the right child
        /// </summary>
        /// <param name="currentIndex"></param>
        /// <returns></returns>
        public int IndexOfRightChild(int currentIndex)
        {
            return currentIndex * 2 + 2;
        }

        /// <summary>
        ///     Satisfy the max heap condition for a current element(given by index)
        /// </summary>
        /// <param name="index">The index of the element</param>
        public void MaxHeapify(int index, int size)
        {
            int leftChildIndex = IndexOfLeftChild(index);
            int rightChildIndex = IndexOfRightChild(index);
            int largest = index;

            if (leftChildIndex < size && HeapArr[leftChildIndex] > HeapArr[index])
            {
                largest = leftChildIndex;
            }

            if (rightChildIndex < size && HeapArr[rightChildIndex] > HeapArr[largest])
            {
                largest = rightChildIndex;
            }

            //Swap the elements and call the function again if the largest index is not equal to index
            if (largest != index)
            {
                var tmp = HeapArr[index];
                HeapArr[index] = HeapArr[largest];
                HeapArr[largest] = tmp;
                MaxHeapify(largest, size);
            }
        }
        /// <summary>
        ///     Builds the max heap data structure
        /// </summary>
        /// <param name="size">The number of Elements</param>
        public void BuildMaxHeap(int size)
        {
            for (int i = IndexOfParent(size - 1); i >= 0; i--)
            {
                MaxHeapify(i, size);
            }
        }

        public int[] Sort()
        {
            int size = HeapArr.Count;
            var result = new int[HeapArr.Count];

            BuildMaxHeap(size);
            for (int i = HeapArr.Count - 1; i > 1; i--)
            {
                result[i] = HeapArr[0];
                HeapArr[0] = HeapArr[i];
                size--;
                MaxHeapify(0, size);
            }
            return result;
        }
    }
}
