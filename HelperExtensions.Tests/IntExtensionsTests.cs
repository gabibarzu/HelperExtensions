using Shouldly;
using Xunit;

namespace HelperExtensions.Tests
{
    public class IntExtensionsTests
    {
        [Theory]
        [InlineData(5, 1, 10, true)]
        [InlineData(1, 1, 10, true)]
        [InlineData(10, 1, 10, true)]
        [InlineData(11, 1, 10, false)]
        public void Given_ValueAndInterval_When_IsBetween_Then_ShouldReturnExpectedResult(int value, int min, int max, bool expectedResult)
        {
            // Act
            var result = value.IsBetween(min, max);

            // Assert
            result.ShouldBe(expectedResult);
        }
    }
}