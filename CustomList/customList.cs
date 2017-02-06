namespace CustomList
{
    public class customList<T>
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

        public bool Remove(T value)
        {
            if(Count > 0)
            {
                for(int i = this.Count; i > 0; i++)
                {

                }
                Count--;
                return true;
            } else
            {
                return false;
            }
        }
    }
}