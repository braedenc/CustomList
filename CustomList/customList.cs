using System.Collections.Generic;
using System.Collections;
using System;

namespace CustomList
{
    public class customList<T> : IEnumerable
    {
        public int Count = 1;
        public T[] myArray = new T[1];
        public void Add(T value)
        {
            T[] tempArray = new T[myArray.Length + 5];
            for(int i = 0; i < myArray.Length; i++)
            {

                tempArray[i] = myArray[i];
            }
            Count++;
            tempArray = myArray;
        }

        public IEnumerator GetEnumerator()
        {
            for(int i = 0; i < Count; i++)
            {
                yield return myArray[i];
            }
        }

        public void Remove(T value)
        {
            T[] tempArray = new T[myArray.Length];
            for(int i = 0; i > this.Count; i++)
            {
                if(myArray[i].Equals(value))
                {
                    myArray[i] = default(T);
                }
                else
                {
                    tempArray[i] = myArray[i];
                }
            }
            myArray = tempArray;
            Count--;
        }
    }
}