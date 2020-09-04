using System;
using Xunit;
using FluentAssertions;

namespace GreedKataAttempt1
{
    public class GreedScorer_ScoreRoll
    {
        [Fact]
        public void Returns100GivenSingleOne()
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(1);

            result.Should().Be(100);
        }
        [Fact]
        public void Returns200GivenTwoOnes()
        {
            var scorer = new GreedScorer();

            var result = scorer.ScoreRoll(1,1);

            result.Should().Be(200);
        }
    }
}
