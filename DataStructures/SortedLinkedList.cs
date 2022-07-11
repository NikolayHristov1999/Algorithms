using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class SortedLinkedList<T> : LinkedList<T> where T : IComparable<T> 
    {
        public override void Add(T value)
        {
            var node = new Node<T>(value);
            
            if (head == null)
            {
                tail = node;
                head = node;
                return;
            }

            var tmp = head;
            while (tmp.Value.CompareTo(value) <= 0)
            {
                if (tmp.Next == null)
                {
                    tmp.Next = node;
                    node.Previous = tmp;
                    tail = node;
                    return;
                }
                tmp = tmp.Next;
            }

            node.Next = tmp;
            node.Previous = tmp.Previous;
            tmp.Previous = node;

            if (node.Previous == null)
            {
                head = node;
                return;
            }
            node.Previous.Next = node;

        }
    }
}
