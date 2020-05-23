using System;
using System.Collections;
using System.Collections.Generic;

namespace CustomList
{
    public class CustomList<T> : IList<T>
    {
        /// <summary>
        /// The property return first element of list 
        /// </summary>
        public Item<T> Head
        {
            get => throw new NotImplementedException();
        }

        /// <summary>
        /// The property return number of elements contained in the CustomList
        /// </summary>
        public int Count
        {
            get => throw new NotImplementedException();
            private set => throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a value indicating whether the IList is read-only.
        /// Make it always false
        /// </summary>
        public bool IsReadOnly => false;


        /// <summary>
        /// Constructor that gets params T as parameter       
        /// </summary>
        /// <exception cref="NullReferenceException">Thrown when values is null</exception>
        /// <param name="values"></param>
        public CustomList(params T[] values)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Constructor that gets Ienumerable collection as parameter       
        /// </summary>
        ///<exception cref="NullReferenceException">Thrown when values is null</exception>
        /// <param name="values"></param>
        public CustomList(IEnumerable<T> values)
        {
            throw new NotImplementedException();
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
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }


        /// <summary>
        ///  Adds an object to the end of the CustomList.
        /// </summary>
        /// <param name="data">Object that should be added in the CustomList</param>
        /// <exception cref="ArgumentNullException">Throws when you try to add null</exception>
        public void Add(T data)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// Removes all elements from the CustomList
        /// </summary>
        public void Clear()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Determines whether an element is in the CustomList
        /// </summary>
        /// <param name="item">Object we check to see if it is on the CustomLIst</param>
        /// <returns>True if the element exists in the CustomList, else false</returns>
        public bool Contains(T item)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }


        /// <summary>
        /// Removes the element at the specified index of the CustomList.
        /// </summary>
        /// <param name="index">The zero-based index of the element to remove.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throw when index is less than 0 or greater than Count - 1</exception>
        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }


        /// <summary>
        /// Returns an enumerator that iterates through the CustomList.
        /// </summary>
        /// <returns></returns>
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

       

    }
}
