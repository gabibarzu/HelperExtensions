using Shouldly;
using Xunit;

namespace HelperExtensions.Tests;

public class DecimalExtensionsTests
{
    [Theory]
    [InlineData(5.5, 5.0, 6.0, true)]
    [InlineData(5.0, 5.0, 6.0, true)]
    [InlineData(6.0, 5.0, 6.0, true)]
    [InlineData(5.5, 5.5, 5.5, true)]
    [InlineData(4.9, 5.0, 6.0, false)]
    [InlineData(6.1, 5.0, 6.0, false)]
    [InlineData(5.4, 5.5, 5.5, false)]
    public void Given_ValueAndInterval_When_IsIBetween_Then_ShouldReturnExpectedResult(decimal value, decimal minValue, decimal maxValue, bool expectedResult)
    {
        // Act
        var result = value.IsBetween(minValue, maxValue);

        // Assert
        result.ShouldBe(expectedResult);
    }

    [Theory]
    [InlineData("123.456789", 2, "123.45")]
    [InlineData("123.456789", 4, "123.4567")]
    [InlineData("123.456789", 0, "123")]
    [InlineData("-123.456789", 3, "-123.456")]
    [InlineData("0.000123456", 5, "0.00012")]
    public void Given_ValueAndNumberOfDecimals_When_TruncateToNrOfDecimals_Then_ShouldReturnExpectedResult(string value, int numberOfDecimals, string expectedResult)
    {
        var valueDecimal = decimal.Parse(value);
        var expectedResultDecimal = decimal.Parse(expectedResult);

        // Act
        var result = valueDecimal.TruncateToNrOfDecimals(numberOfDecimals);

        // Assert
        result.ShouldBe(expectedResultDecimal);
    }
}