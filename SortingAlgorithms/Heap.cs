using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class Heap
    {
        public int[] _heap;

        public Heap(int[] arr)
        {
            _heap = arr;
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

            if (leftChildIndex < size && _heap[leftChildIndex] > _heap[index])
            {
                largest = leftChildIndex;
            }

            if (rightChildIndex < size && _heap[rightChildIndex] > _heap[largest])
            {
                largest = rightChildIndex;
            }

            //Swap the elements and call the function again if the largest index is not equal to index
            if (largest != index)
            {
                var tmp = _heap[index];
                _heap[index] = _heap[largest];
                _heap[largest] = tmp;
                MaxHeapify(largest, size);
            }
        }

        public void BuildMaxHeap(int size)
        {
            for (int i = IndexOfParent(size - 1); i >= 0; i--)
            {
                MaxHeapify(i, size);
            }
        }

        public int[] Sort()
        {
            int size = _heap.Length;
            var result = new int[_heap.Length];

            BuildMaxHeap(size);
            for (int i = _heap.Length - 1; i > 1; i--)
            {
                result[i] = _heap[0];
                _heap[0] = _heap[i];
                size--;
                MaxHeapify(0, size);
            }
            return result;
        }
    }
}
