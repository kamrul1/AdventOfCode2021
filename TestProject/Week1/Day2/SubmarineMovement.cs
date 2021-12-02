using System.Collections.Generic;
using System.Linq;

namespace TestProject.Week1.Day2
{
    public class SubmarineMovement
    {
        private readonly string[] _moves;

        public SubmarineMovement(string[] moves)
        {
            _moves = moves;
        }

        public int NumberOfForwards()
        {
            var forwardMovement = 
                _moves.Where(x => x.StartsWith("forward"))
                    .Select(x=>x);
            return forwardMovement.Count();
        }

        public int FinalHorizontalPosition()
        {
            var forwardMovement = _moves
                .Where(x => x.StartsWith("forward"))
                .Select(x => x.Replace("forward ", ""));

            return forwardMovement.Select(x => int.Parse(x)).Sum();
        }

        public int MovedDepth()
        {
            var depthChanges = UpOrDownMovements();

            var depth = 0;
            var changeValue = "";

            foreach (var depthChange in depthChanges)
            {
                if (depthChange.StartsWith("down"))
                {
                    changeValue = depthChange.Replace("down ", "");
                    depth += int.Parse(changeValue);
                    continue;
                }

                changeValue = depthChange.Replace("up ", "");
                depth += (int.Parse(changeValue)*-1);
            }

            return depth;
        }

        private IEnumerable<string>? UpOrDownMovements()
        {
            var depthMoved =
                _moves.Where(x => x.StartsWith("down") || x.StartsWith("up"));
            return depthMoved;
        }

        public int MultipledMoves()
        {
            return FinalHorizontalPosition() * MovedDepth();
        }
    }
}