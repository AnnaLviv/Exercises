using System;

namespace Exercises.StackExercise
{
    public class StackExceededSizeException : Exception
    {
        public StackExceededSizeException()
        {
        }

        public StackExceededSizeException(string message)
            : base(message)
        {
        }

        public StackExceededSizeException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
