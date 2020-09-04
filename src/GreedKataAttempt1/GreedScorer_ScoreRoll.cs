using System;
using Xunit;
using FluentAssertions;

namespace GreedKataAttempt1
{
    public class GreedScorer_ScoreRoll
    {
        private GreedScorer _scorer = new GreedScorer();

        [Theory]
        [InlineData(100, 1)]
        [InlineData(200, 1, 1)]
        public void Returns100PerOneFewerThanThree(int expectedValue, params int[] ones)
        {
            var result = _scorer.ScoreRoll(ones);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(50, 5)]
        [InlineData(100, 5, 5)]
        public void Returns50PerFiveFewerThanThree(int expectedValue, params int[] fives)
        {
            var result = _scorer.ScoreRoll(fives);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(5, 1)]
        public void Returns150GivenOneAndFive(params int[] dieValues)
        {
            var result = _scorer.ScoreRoll(dieValues);

            result.Should().Be(150);
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

        [Theory]
        [InlineData(1000, 1, 1, 1)]
        [InlineData(1000, 1, 1, 1, 6)]
        [InlineData(1050, 1, 1, 1, 5)]
        public void ReturnsTripleOneScoreGivenThreeOnesAndOtherValues(int expectedValue, params int[] dieValues)
        {
            var result = _scorer.ScoreRoll(dieValues);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(200, 2, 2, 2)]
        [InlineData(300, 3, 3, 3)]
        [InlineData(400, 4, 4, 4)]
        [InlineData(500, 5, 5, 5)]
        [InlineData(600, 6, 6, 6)]
        public void ReturnsTripleValueGivenThreeTwosThroughSixes(int expectedValue, params int[] dieValues)
        {
            var result = _scorer.ScoreRoll(dieValues);

            result.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData(1150, 1, 1, 1, 5, 1)]
        [InlineData(0, 2, 3, 4, 6, 2)]
        [InlineData(350, 3, 4, 5, 3, 3)]
        public void ReturnsExpectedValueFromSampleScoresGiven(int expectedValue, params int[] dieValues)
        {
            var result = _scorer.ScoreRoll(dieValues);

            result.Should().Be(expectedValue);
        }


    }
}
