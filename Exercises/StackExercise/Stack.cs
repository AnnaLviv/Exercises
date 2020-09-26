using System;

namespace Exercises.StackExercise
{
    public class Stack<T>
    {
        private readonly T[] stackArray;
        private readonly int maximumLength;

        public int Size { get; private set; }
        public Stack(int maximumLength)
        {
            if(maximumLength <=0)
            {
                throw new ArgumentOutOfRangeException("Stack must be at least 1 element long");
            }
            this.maximumLength = maximumLength;
            stackArray  = new T[maximumLength];
            Size = 0;
        }
        public void Push(T value)
        {
            if (Size >= maximumLength)
            {
                throw new StackExceededSizeException($"Stack is already filled with maximum number of elements, which is '{maximumLength}'." +
                    " Pop some elements before you can push new elements.");
            }
            else
            {
                stackArray[Size] = value;
                Size++;
            }
        }
        public T Pop()
        {
            if (Size < 1)
            {
                throw new StackExpenditureProhibitedException("Stack is empty. There are no elements to pop.");
            }
            else
            {
                Size--;
                return stackArray[Size];
            }
        }

        public T Peek()
        {
            if (Size < 1)
            {
                throw new StackExpenditureProhibitedException("Stack is empty. There are no elements to peek.");
            }
            else
            {
                return stackArray[Size - 1];
            }
        }
    }
}
