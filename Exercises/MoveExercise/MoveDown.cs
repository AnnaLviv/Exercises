using System;
namespace Exercises.MoveExercise
{
    public class MoveDown : MoveBasic
    {
        public MoveDown()
            : base(MoveConstants.Down)
        {
        }

        public override void DoMove()
        {
            Console.WriteLine("Here we are moving down");
        }
    }
}
