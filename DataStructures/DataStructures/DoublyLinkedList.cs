using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{

    public class DoublyLinkedListCell<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListCell<T> Next { get; set; }
        public DoublyLinkedListCell<T> Previous { get; set; }
    }
    public class DoublyLinkedList<T>
    {
        private DoublyLinkedListCell<T> Top;
        private DoublyLinkedListCell<T> Bottom;

        public DoublyLinkedList()
            : this(default(T), default(T))
        {


        }

        public DoublyLinkedList(T top, T bottom)
        {
            Top = new DoublyLinkedListCell<T>()
            {
                Value = top
            };

            Bottom = new DoublyLinkedListCell<T>()
            {
                Value = bottom
            };
            Top.Next = Bottom;
            Top.Previous = Bottom;
            Bottom.Next = Top;
            Bottom.Previous = Top;
        }

        public DoublyLinkedListCell<T> Find(T item)
        {

            var current = Top;

            while (true)
            {
                if (current == Bottom)
                {
                    break;
                }
                else if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    return current;
                }
                else
                {
                    current = current.Next;
                }

            }
            return null;

        }
        public void Insert(T item)
        {
            var current = Top;
            while (true)
            {
                if (current.Next == Bottom)
                {
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }

            current.Next = new DoublyLinkedListCell<T>()
            {
                Next = Bottom,
                Value = item,
                Previous = current
            };

        }

        public bool Remove(T item)
        {
            var itemPresentInList = false;
            var before = Top;

            while (true)
            {
                if (before.Next == Bottom)
                {
                    break;
                }
                else if (EqualityComparer<T>.Default.Equals(before.Next.Value, item))
                {
                    itemPresentInList = true;
                    break;
                }
                else
                {
                    before = before.Next;
                }

            }

            if (itemPresentInList)
            {
                var current = before.Next;
                before.Next = current.Next;
                current.Next.Previous = before;
            }
            return itemPresentInList;
        }

    }
}
