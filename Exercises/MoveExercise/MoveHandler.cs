using System.ComponentModel;

namespace Exercises.MoveExercise
{
    public class MoveHandler
    {
        public string ExecuteMove(string moveCommand)
        {
            var move = CreateMove(moveCommand);
            move.DoMove();
            return move.GetName();
        }

        private Move CreateMove(string moveCommand)
        {
            switch (moveCommand)
            {
                case MoveConstants.Up:
                    {
                        return new MoveUp();
                    }
                case MoveConstants.Down:
                    {
                        return new MoveDown();
                    }
                case MoveConstants.Left:
                    {
                        return new MoveLeft();
                    }
                case MoveConstants.Right:
                    {
                        return new MoveRight();
                    }
                case MoveConstants.Combo:
                    {
                        return new MoveCombo();
                    }
                default:
                    throw new InvalidEnumArgumentException($"Move {moveCommand} is not supported.");
            }
        }
    
    }
}
