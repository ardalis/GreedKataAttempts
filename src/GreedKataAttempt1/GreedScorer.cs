using System.Linq;

namespace GreedKataAttempt1
{
    public class GreedScorer
    {
        public int ScoreRoll(params int[] dieValues)
        {
            if (dieValues.Count(i => i == 5) == 1)
            {
                return 50;
            }
            if (!dieValues.Any(i => i == 1)) return 0;

            if (dieValues.Count(i => i == 1) == 1)
            {
                return 100;
            }
            return 200;
        }
    }
}
