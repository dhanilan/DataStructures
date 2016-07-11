using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class SortedLinkedListCell<T>
    {
        public T Value { get; set; }
        public SortedLinkedListCell<T> Next { get; set; }
    }
    public class SortedLinkedList<T>
    {
        private SortedLinkedListCell<T> Top;
        private SortedLinkedListCell<T> Bottom;

        public SortedLinkedList()
            : this(default(T), default(T))
        {


        }

        public SortedLinkedList(T top, T bottom)
        {
            Top = new SortedLinkedListCell<T>()
            {
                Value = top
            };

            Bottom = new SortedLinkedListCell<T>()
            {
                Value = bottom
            };
            Top.Next = Bottom;
        }

        public int Find(T item)
        {

            var itemPresentInList = false;
            var pos = 0;
            var current = Top;

            while (true)
            {
                if (current.Next == Bottom || (current.Next != Bottom && System.Collections.Generic.Comparer<T>.Default.Compare(current.Value, item) > 0))
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
                    pos++;
                }

            }

            return itemPresentInList ? pos : 0;
        }
        public void Insert(T item)
        {
            var current = Top;
            while (true)
            {
                if (current.Next == Bottom || (current.Next != Bottom && System.Collections.Generic.Comparer<T>.Default.Compare(current.Next.Value, item) > 0))
                {
                    break;
                }
                else
                {
                    current = current.Next;
                }
            }
            var temp = current.Next;
            current.Next = new SortedLinkedListCell<T>()
            {
                Next = temp,
                Value = item
            };

        }

        public bool Remove(T item)
        {
            var itemPresentInList = false;
            var before = Top;

            while (true)
            {
                if (before.Next == Bottom || ( before.Next != Bottom  && System.Collections.Generic.Comparer<T>.Default.Compare(before.Next.Value, item) > 0))
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
                before.Next = before.Next.Next;
            }
            return itemPresentInList;
        }

    }


}
