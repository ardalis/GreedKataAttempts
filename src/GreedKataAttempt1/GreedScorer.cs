using System.Linq;

namespace GreedKataAttempt1
{
    public class GreedScorer
    {
        public int ScoreRoll(params int[] dieValues)
        {
            int fiveCount = dieValues.Count(i => i == 5);
            if (fiveCount > 0) return fiveCount * 50;

            int oneCount = dieValues.Count(i => i == 1);
            if (oneCount > 0) return oneCount * 100;

            return 0;
        }
    }
}
