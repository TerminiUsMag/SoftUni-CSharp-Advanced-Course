using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementing_MyList_and_MyStack
{
    public class MyList
    {
        private int capacity;
        private const int InitialLenght = 2;
        private int[] data;
        public int Count { get; private set; }
        public MyList()
            : this(InitialLenght)
        {
        }
        public MyList(int capacity)
        {
            this.capacity = capacity;
            this.data = new int[capacity];
            this.Count = 0;
        }

        private void ValidateIndex(int index)
        {

            if (index >= 0 && index < this.Count)
            {
                return;
            }
            var message = this.Count == 0
                ? "This list is empty"
                : $"This list has {this.Count} elements and it's zero-based, you are trying to access {index} index which is not in the list.";
            throw new Exception($"Index out of range. {message}");
        }
        public int this[int index]
        {
            get
            {
                this.ValidateIndex(index);
                return data[index];
            }
            set
            {
                this.ValidateIndex(index);
                data[index] = value;
            }
        }
        private void Resize()
        {
            var oldArray = this.data;
            this.capacity *= 2;
            var newArray = new int[this.capacity];
            for (int i = 0; i < oldArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }
            this.data = newArray;
        }
        private void Shrink()
        {
            var oldArray = this.data;
            this.capacity /= 2;
            var newArray = new int[this.capacity];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = oldArray[i];
            }
            this.data = newArray;
        }
        private void Shift(int startingIndex)
        {
            for (int i = startingIndex; i < this.Count - 1; i++)
            {
                this.data[i] = this.data[i + 1];
            }
        }
        private void ShiftToRight(int index)
        {
            for (int i = this.Count; i > index; i--)
            {
                this.data[i] = this.data[i - 1];
            }
        }
        public override string ToString()
        {
            return this.ToString();
        }
        public void Reverse()
        {
            var reverseCounter = this.Count - 1;
            var numberOfOperations = this.Count / 2;
            for (int i = 0; i < this.Count / 2; i++)
            {
                var temp = this.data[i];
                this.data[i] = this.data[reverseCounter];
                this.data[reverseCounter] = temp;
                reverseCounter--;
            }
        }
        public int Find(int item)
        {
            var result = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (item == this.data[i])
                    result = i;
            }

            return result;
        }
        public void Swap(int firstIndex, int secondIndex)
        {
            this.ValidateIndex(firstIndex);
            this.ValidateIndex(secondIndex);
            var swapper = this.data[firstIndex];
            this.data[firstIndex] = this.data[secondIndex];
            this.data[secondIndex] = swapper;
        }
        public bool Contains(int item)
        {
            for (int i = 0; i < this.Count; i++)
            {
                if (this.data[i] == item)
                {
                    return true;
                }
            }

            return false; ;
        }
        public void Insert(int index, int item)
        {
            this.ValidateIndex(index);

            if (this.Count + 1 == this.data.Length)
                this.Resize();

            this.ShiftToRight(index);
            this.data[index] = item;

        }
        public void Add(int number)
        {
            if (this.Count + 1 == this.data.Length)
                this.Resize();
            data[this.Count] = number;
            this.Count++;
        }
        public int RemoveAt(int index)
        {
            this.ValidateIndex(index);

            var removedElement = data[index];
            data[index] = default;
            this.Count--;
            this.Shift(index);
            if (this.Count <= this.data.Length / 4)
                this.Shrink();

            return removedElement;
        }
        public void Clear()
        {
            this.data = new int[InitialLenght];
            this.capacity = InitialLenght;
            this.Count = 0;
        }
        public int Capacity()
        {
            return this.capacity;
        }

    }
}
