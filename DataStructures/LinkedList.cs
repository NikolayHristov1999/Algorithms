using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Node<T>
    {
        public Node<T>? Next { get; set; }
        
        public Node<T>? Previous { get; set; }

        public T Value { get; set; }

        public Node(T value)
        {
            this.Value = value;
        }

    }
    public class LinkedList<T> : IEnumerable<T>
    {
        protected Node<T>? head;

        protected Node<T>? tail;

        public int Count { get; set; }

        public virtual void Add(T value)
        {
            var node = new Node<T>(value);
            
            if (tail != null)
            {
                tail.Next = node;
                node.Previous = tail;
                tail = node;
            }
            else
            {
                tail = node;
                head = node;
            }
            Count++;
        }

        public T? GetFirst()
        {
            if (head != null)
            {
                return head.Value;
            }
            return default;
        }

        public T? GetLast()
        {
            if (tail != null)
            {
                return tail.Value;
            }
            return default;
        }

        public void Remove(T value)
        {
            var node = head;
            while(node != null)
            {
                if (node.Value.Equals(value))
                {
                    if (node.Previous != null)
                    {
                        node.Previous.Next = node.Next;
                    }
                    if (node.Next != null)
                    {
                        node.Next.Previous = node.Previous;
                    }
                }
                node = node.Next;
            }
        }


        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
