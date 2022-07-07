using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms.SortAlgos
{
    public static class HeapSort
    {
        public static void Sort(int[] arr)
        {

            var heap = new Heap(arr);
            arr = heap.Sort();

        }
        

    }
}
