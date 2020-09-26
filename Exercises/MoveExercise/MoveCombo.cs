using System.Collections.Generic;
using System.Linq;

namespace Exercises.MoveExercise
{
    public class MoveCombo : Move
    {
        private IList<Move> moves
            = new List<Move> { new MoveUp(), new MoveUp(), new MoveDown(), new MoveDown() };

        public MoveCombo() 
            : base(MoveConstants.Combo)
        {    }

        public override void DoMove()
        {
            foreach(var move in moves)
            {
                move.DoMove();
            }
        }

        public override string GetName()
        {
            var movesSequenceName = string.Join(" ", moves.Select(move => move.Key));
            var completeName = $"{movesSequenceName} Combo Move";
            return completeName;
        }
    }
}
