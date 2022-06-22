using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_Linked_List
{
    internal class DoublyLinkedList<T>
    {
        public int Count { get; set; }

        public Node Head { get; set; }
        public Node Tail { get; set; }

        public bool IsEmpty => this.Count == 0;

        public void AddHead(T value)
        {
            if (this.IsEmpty)
            {
                var newNode = new Node(value);
                this.Head = this.Tail = newNode;
            }
            else
            {
                var oldHead = this.Head;
                this.Head = new Node(value);
                this.Head.Next = oldHead;
                oldHead.Previous = this.Head;
            }
            this.Count++;
        }
        public void AddTail(T value)
        {
            if (this.IsEmpty)
            {
                var newNode = new Node(value);
                this.Head = this.Tail = newNode;
            }
            else
            {
                var oldTail = this.Tail;
                this.Tail = new Node(value);
                this.Tail.Previous = oldTail;
                this.Tail.Next = null;
                oldTail.Next = this.Tail;
            }
            this.Count++;
        }
        public T RemoveHead()
        {
            if (this.IsEmpty)
            {
                throw new Exception("The list is empty, cannot remove something that is not there :) !");
            }

            var removedHead = this.Head;
            var newHead = this.Head.Next;
            this.Head = newHead;
            newHead.Previous = null;
            this.Count--;

            return removedHead.Value;
        }
        public T RemoveTail()
        {
            if (this.IsEmpty)
            {
                throw new Exception("The list is empty, cannot remove something that is not there :) !");
            }

            if (this.Tail.Previous == null)
            {
                this.Head = this.Tail = null;
                this.Count = 0;
            }
            else
            {
                var removedTail = this.Tail;
                var newTail = this.Tail.Previous;
                newTail.Next = null;
                this.Tail = newTail;
                this.Count--;
            }

            return removedTail.Value;
        }
        public void ForEach(Action<T> action)
        {
            var currNode = this.Head;
            while (currNode != null)
            {
                action(currNode.Value);
                currNode = currNode.Next;
            }
        }

        public class Node
        {
            public Node(T value)
            {
                this.Value = value;
            }
            public T Value { get; set; }
            public Node Next { get; set; }

            public Node Previous { get; set; }


        }
    }
}
