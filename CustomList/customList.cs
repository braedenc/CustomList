using System.Collections.Generic;
using System.Collections;
using System;

namespace CustomList
{
    public class customList<T> : IEnumerable where T : IComparable
    {
        public int Count;
        public int Capacity;
        T[] myArray;

        public T this[int i]
        {
            get { return myArray[i]; }
            set { myArray[i] = value; }
        }
        public customList()
        {
            Count = 0;
            Capacity = 5;
            myArray = new T[Capacity];
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                yield return myArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void Add(T value)
        {
            if (Count >= Capacity)
            {
                T[] tempArray = new T[Capacity * 2];
                for (int i = 0; i < Count; i++)
                {

                    tempArray[i] = myArray[i];
                }
                tempArray[Count] = value;
                Count++;
                myArray = tempArray;
            }
            else
            {
                T[] tempArray = new T[Capacity];
                for (int i = 0; i < Count; i++)
                {

                    tempArray[i] = myArray[i];
                }
                tempArray[Count] = value;
                Count++;
                myArray = tempArray;
            }

        }

        public void Remove(T value)
        {
            T[] tempArray = new T[myArray.Length];
            for (int i = 0; i > this.Count; i++)
            {
                if (myArray[i].Equals(value))
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

        public override string ToString()
        {
            string convertedItems = "";
            foreach (T item in myArray)
            {
                if (convertedItems == "")
                {
                    convertedItems += item.ToString();
                }
                else
                {
                    convertedItems += string.Format(", {0}", item);
                }
            }
            return convertedItems;
        }

        public static customList<T> operator +(customList<T> firstList, customList<T> secondList)
        {
            T[] tempArray = new T[firstList.Capacity + secondList.Capacity];
            customList<T> addedList = new customList<T>();
            addedList.myArray = tempArray;

            for (int i = 0; i < firstList.Count; i++)
            {
                addedList.Add(firstList[i]);
            }
            for (int i = addedList.Count; i < firstList.Count + secondList.Count; i++)
            {
                addedList.Add(secondList[i - firstList.Count]);
            }
            return addedList;
        }
        public static customList<T> operator -(customList<T> firstList, customList<T> secondList)
        {
            T[] tempArray = new T[firstList.Capacity];
            customList<T> subtractedList = new customList<T>();
            subtractedList.myArray = tempArray;

            for (int i = 0; i < firstList.Count; i++)
            {
                subtractedList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.Count; i++)
            {
                if (subtractedList[i].Equals(secondList[i]))
                {
                    subtractedList.Remove(secondList[i]);
                }
            }
            return subtractedList;
        }
        public customList<T> Zip(customList<T> secondList)
        {
            T[] tempArray = new T[this.Capacity + secondList.Capacity];
            customList<T> zippedList = new customList<T>();
            zippedList.myArray = tempArray;

            if (this.Count > secondList.Count)
            {
                for (int i = 0; i < secondList.Count; i++)
                {
                    zippedList.Add(this[i]);
                    zippedList.Add(secondList[i]);
                }
                for (int i = secondList.Count; i < this.Count; i++)
                {
                    zippedList.Add(this[i]);
                }
            }
            else if (this.Count < secondList.Count)
            {
                for (int i = 0; i < this.Count; i++)
                {
                    zippedList.Add(this[i]);
                    zippedList.Add(secondList[i]);
                }
                for (int i = this.Count; i < secondList.Count; i++)
                {
                    zippedList.Add(secondList[i]);
                }
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    zippedList.Add(this[i]);
                    zippedList.Add(secondList[i]);
                }
            }

            return zippedList;
        }
    }
}
