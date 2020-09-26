using System;

namespace Exercises.MoveExercise
{
    public class MoveUp : MoveBasic
    {
        public MoveUp()
            :base(MoveConstants.Up)
        {
        }

        public override void DoMove()
        {
            Console.WriteLine("Here we are moving up");
        }
    }
}
