using System;

namespace Exercises.StackExercise
{
    public class StackExpenditureProhibitedException : Exception
    {
        public StackExpenditureProhibitedException()
        {
        }

        public StackExpenditureProhibitedException(string message)
            : base(message)
        {
        }

        public StackExpenditureProhibitedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
