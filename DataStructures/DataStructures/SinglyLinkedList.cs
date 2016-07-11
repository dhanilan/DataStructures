using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class SinglyLinkedListCell<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListCell<T> Next { get; set; }
    }
    public class SinglyLinkedList<T>
    {
        private SinglyLinkedListCell<T> Top;
        private SinglyLinkedListCell<T> Bottom;

        public SinglyLinkedList()
            : this(default(T), default(T))
        {


        }

        public SinglyLinkedList(T top, T bottom)
        {
            Top = new SinglyLinkedListCell<T>()
            {
                Value = top
            };

            Bottom = new SinglyLinkedListCell<T>()
            {
                Value = bottom
            };
            Top.Next = Bottom;
        }

        public bool Find(T item)
        {

            var itemPresentInList = false;
            var current = Top;

            while (true)
            {
                if (current == Bottom)
                {
                    break;
                }
                else if (EqualityComparer<T>.Default.Equals(current.Value, item))
                {
                    itemPresentInList = true;
                    break;
                }
                else
                {
                    current = current.Next;
                }

            }

            return itemPresentInList;
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

            current.Next = new SinglyLinkedListCell<T>()
            {
                Next = Bottom,
                Value = item
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
                else if (EqualityComparer<T>.Default.Equals(before.Next.Value , item))
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
                before.Next = before.Next.Next;
            }
            return itemPresentInList;
        }

    }
}
