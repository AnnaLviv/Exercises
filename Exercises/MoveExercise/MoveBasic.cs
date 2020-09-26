namespace Exercises.MoveExercise
{
    public abstract class MoveBasic:Move
    {
        protected MoveBasic(string key): base(key)
        {  }

        public override string GetName()
        {
            return $"Basic {Key} Move";
        }
    }
}
