using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Resources;

namespace CustomList
{
    public class CustomList<T> : IList<T>
    {
        /// <summary>
        /// The property return first element of list 
        /// </summary>
        public Item<T> Head { get; private set; }

        /// <summary>
        /// The property return number of elements contained in the CustomList
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Gets a value indicating whether the IList is read-only.
        /// Make it always false
        /// </summary>
        public bool IsReadOnly => false;


        /// <summary>
        /// Constructor that gets params T as parameter       
        /// </summary>
        /// <exception cref="ArgumentNullException">Thrown when values is null</exception>
        /// <param name="values"></param>
        public CustomList(params T[] values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values), "cant be null");

            foreach (var value in values)
                Add(value);
        }


        /// <summary>
        /// Constructor that gets Ienumerable collection as parameter       
        /// </summary>
        ///<exception cref="ArgumentNullException">Thrown when values is null</exception>
        /// <param name="values"></param>
        public CustomList(IEnumerable<T> values)
        {
            if (values is null)
                throw new ArgumentNullException(nameof(values), "cant be null");

            foreach (var value in values)
                Add(value);
        }

        /// <summary>
        /// Get or set data at the position.
        /// </summary>
        /// <param name="index">Position</param>
        /// <exception cref="IndexOutOfRangeException">Throw when index is less than 0 or greater than Count - 1</exception>
        public T this[int index]
        {
            get
            {
                var e = new IndexOutOfRangeException("Incorrect value of index.");
                if (index < 0 || index > Count - 1)
                    throw e;

                var current = Head;

                for (int i = 0; i < index; i++)
                    current = current.Next;

                return current.Data;
            }
            set
            {
                var e = new IndexOutOfRangeException("Incorrect value of index.");
                if (index < 0 || index > Count - 1)
                    throw e;

                var current = Head;

                for (int i = 0; i < index; i++)
                    current = current.Next;

                current.Data = value;
            }
        }


        /// <summary>
        ///  Adds an object to the end of the CustomList.
        /// </summary>
        /// <param name="item">Object that should be added in the CustomList</param>
        /// <exception cref="ArgumentNullException">Throws when you try to add null</exception>
        public void Add(T item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item), "cant be null.");

            var element = new Item<T>(item);

            if (Head == null)
            {
                Head = element;
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                    current = current.Next;

                current.Next = element;
            }

            Count++;
        }


        /// <summary>
        /// Removes all elements from the CustomList
        /// </summary>
        public void Clear()
        {
            Head = default;
            Count = 0;
        }

        /// <summary>
        /// Determines whether an element is in the CustomList
        /// </summary>
        /// <param name="item">Object we check to see if it is on the CustomLIst</param>
        /// <returns>True if the element exists in the CustomList, else false</returns>
        public bool Contains(T item)
        {
            var current = Head;
            while (current != null)
            {
                if (current.Data.Equals(item)) 
                    return true;

                current = current.Next;
            }

            return false;
        }


        /// <summary>
        /// Removes the first occurrence of a specific object from the CustomList.
        /// </summary>
        /// <param name="item"> The object to remove from the CustomList</param>
        /// <returns>True if item is successfully removed; otherwise, false. This method also returns
        ///     false if item was not found in the CustomList.</returns>
        /// <exception cref="ArgumentNullException">Throws when you try to remove null</exception>
        public bool Remove(T item)
        {
            if (item is null)
                throw new ArgumentNullException(nameof(item), "cant be null.");

            var current = Head;
            Item<T> previous = null;

            while (current != null)
            {
                if (current.Data.Equals(item))
                {
                    if (previous != null)
                        previous.Next = current.Next;
                    else
                        Head = Head.Next;

                    Count--;
                    return true;
                }

                previous = current;
                current = current.Next;
            }

            return false;
        }


        /// <summary>
        /// Searches for the specified object and returns the zero-based index of the first
        ///     occurrence within the CustomList.
        /// </summary>
        /// <param name="item">The object whose index we want to get </param>
        /// <returns>The zero-based index of the first occurrence of item within the entire CustomList,
        ///    if found; otherwise, -1.</returns>
        public int IndexOf(T item)
        {
            var current = Head;
            var index = 0;

            while (current != null)
            {

                if (current.Data.Equals(item))
                    return index;

                index++;
                current = current.Next;
            }

            return -1;
        }


        /// <summary>
        /// Inserts an element into the CustomList at the specified index.
        /// </summary>
        /// <param name="index">The zero-based index at which item should be inserted.</param>
        /// <param name="item">The object to insert.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when index is less than 0 or greater than Count - 1</exception>
        /// <exception cref="ArgumentNullException">Thrown when item is null</exception>
        public void Insert(int index, T item)
        {
            var e = new IndexOutOfRangeException("Incorrect value of index.");
            if (index < 0 || index > Count)
                throw e;

            if (item is null)
                throw new ArgumentNullException(nameof(item), "cant be null.");

            var current = Head;
            Item<T> previous = null;

            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next;
            }
            
            var element = new Item<T>(item) {Next = current};
            Count++;

            if (previous != null)
                previous.Next = element;
            else
                Head = element;
        }


        /// <summary>
        /// Removes the element at the specified index of the CustomList.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when index is less than 0 or greater than Count - 1</exception>
        public void RemoveAt(int index)
        {
            if (index < 0 || index > Count - 1) 
                throw new ArgumentOutOfRangeException(nameof(index),"Incorrect value of index.");

            var current = Head;
            Item<T> previous = null;

            for (int i = 0; i < index; i++)
            {
                previous = current;
                current = current.Next;
            }

            Count--;

            if (previous is null)
                Head = current.Next;
            else
                previous.Next = current.Next;
        }


        /// <summary>
        /// Copies the entire CustomList to a compatible one-dimensional array, starting at the beginning of the target array.
        /// </summary>
        /// <param name="array">The one-dimensional System.Array that is the destination of the elements copied
        ///     from CustomList</param>
        /// <param name="arrayIndex">The zero-based index in the source System.Array at which
        ///   copying begins.</param>
        ///   <exception cref="ArgumentNullException">Array is null.</exception>
        ///   <exception cref="ArgumentException">The number of elements in the source CustomList is greater
        ///    than the number of elements that the destination array can contain</exception>
        public void CopyTo(T[] array, int arrayIndex)
        {
            if (array is null)
                throw new ArgumentNullException(nameof(array), "cant be null.");

            if (Count > array.Length)
                throw new ArgumentException("Incorrect length of destination array.");

            var current = Head;

            for (int i = 0; i < Count; i++)
            {
                array[i + arrayIndex] = current.Data;
                current = current.Next;
            }
        }


        /// <summary>
        /// Returns an enumerator that iterates through the CustomList.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
    }
}
