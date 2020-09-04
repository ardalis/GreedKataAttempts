using System.Linq;

namespace GreedKataAttempt1
{
    public class GreedScorer
    {
        public int ScoreRoll(params int[] dieValues)
        {
            int fiveCount = dieValues.Count(i => i == 5);
            if (fiveCount > 0) return fiveCount * 50;

            if (!dieValues.Any(i => i == 1)) return 0;

            if (dieValues.Count(i => i == 1) == 1)
            {
                return 100;
            }
            return 200;
        }
    }
}
