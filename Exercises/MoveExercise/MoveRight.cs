using System;

namespace Exercises.MoveExercise
{
    public class MoveRight : MoveBasic
    {
        public MoveRight()
            : base(MoveConstants.Right)
        {
        }

        public override void DoMove()
        {
            Console.WriteLine("Here we are moving right");
        }
    }
}
