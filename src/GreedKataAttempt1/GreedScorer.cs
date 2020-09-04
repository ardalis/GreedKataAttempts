using System;
using System.Collections.Generic;
using System.Linq;

namespace GreedKataAttempt1
{
    public class GreedScorer
    {
        private Dictionary<int, int> _dieValueCounts = new Dictionary<int, int>();

        public int ScoreRoll(params int[] dieValues)
        {
            LoadDieValueCounts(dieValues);
            int score = 0;

            score += ScoreStraight();

            score += ScoreQuadOneValue();

            for (int dieValue = 2; dieValue <= 6; dieValue++)
            {
                score += ScoreQuadDieValue(dieValue);
            }

            score += ScoreTripleOneValue();

            for (int dieValue = 2; dieValue <= 6; dieValue++)
            {
                score += ScoreTripleDieValue(dieValue);
            }

            score += ScoreSingleOneValues();
            score += ScoreSingleFiveValues();

            return score;
        }

        private int ScoreStraight()
        {
            if(_dieValueCounts.Values.All(d => d == 1))
            {
                for (int i = 1; i <= 6; i++)
                {
                    _dieValueCounts[i] -= 1;
                }
                return 1200;
            }
        }

        private void LoadDieValueCounts(int[] dieValues)
        {
            for (int i = 1; i <= 6; i++)
            {
                _dieValueCounts.Add(i, dieValues.Count(die => die == i));
            }
        }

        private int ScoreTripleOneValue()
        {
            if (_dieValueCounts[1] >= 3)
            {
                _dieValueCounts[1] -= 3;
                return 1000;
            }
            return 0;
        }

        private int ScoreQuadOneValue()
        {
            if (_dieValueCounts[1] >= 4)
            {
                _dieValueCounts[1] -= 4;
                return 2000;
            }
            return 0;
        }

        private int ScoreQuadDieValue(int dieValue)
        {
            if (_dieValueCounts[dieValue] >= 4)
            {
                _dieValueCounts[dieValue] -= 4;
                return dieValue * 200;
            }

            return 0;
        }
        private int ScoreTripleDieValue(int dieValue)
        {
            if (_dieValueCounts[dieValue] >= 3)
            {
                _dieValueCounts[dieValue] -= 3;
                return dieValue * 100;
            }

            return 0;
        }

        private int ScoreSingleOneValues()
        {
            int score = _dieValueCounts[1] * 100;
            _dieValueCounts[1] = 0;
            return score;
        }

        private int ScoreSingleFiveValues()
        {
            int score = _dieValueCounts[5] * 50;
            _dieValueCounts[1] = 0;
            return score;
        }
    }
}
