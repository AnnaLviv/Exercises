using System;

namespace Exercises.MoveExercise
{
    public class MoveLeft: MoveBasic
    {
        public MoveLeft()
            : base(MoveConstants.Left)
        {
        }

        public override void DoMove()
        {
            Console.WriteLine("Here we are moving left");
        }
    }
}
