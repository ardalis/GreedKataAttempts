using System;
using Xunit;
using FluentAssertions;

namespace GreedKataAttempt1
{
    public class GreedScorer_ScoreRoll
    {
        private GreedScorer _scorer = new GreedScorer();

        [Fact]
        public void Returns100GivenSingleOne()
        {
            var result = _scorer.ScoreRoll(1);

            result.Should().Be(100);
        }
        [Fact]
        public void Returns50GivenSingleFive()
        {
            var result = _scorer.ScoreRoll(5);

            result.Should().Be(50);
        }
        [Fact]
        public void Returns200GivenTwoOnes()
        {
            var result = _scorer.ScoreRoll(1, 1);

            result.Should().Be(200);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(4)]
        [InlineData(6)]
        public void Returns0GivenSingleWorthlessValue(int val)
        {
            var result = _scorer.ScoreRoll(val);

            result.Should().Be(0);
        }
    }
}
