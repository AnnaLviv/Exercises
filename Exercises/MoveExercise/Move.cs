namespace Exercises.MoveExercise
{
    public abstract class Move
    {
        public string Key { get; }

        protected Move(string key)
        {
            Key = key;
        }

        public abstract string GetName();
        public abstract void DoMove();
    }
}
