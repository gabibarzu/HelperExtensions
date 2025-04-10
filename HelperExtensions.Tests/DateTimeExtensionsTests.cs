using Shouldly;
using Xunit;

namespace HelperExtensions.Tests;

public class DateTimeExtensionsTests
{
    [Theory]
    [InlineData("2023-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2020-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2025-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2026-01-01", "2020-01-01", "2025-01-01", false)]
    public void Given_ValueAndInterval_When_IsInRange_Then_ShouldReturnExpectedResult(string value, string min, string max, bool expectedResult)
    {
        // Arrange
        var valueDateTime = DateTime.Parse(value);
        var minDateTime = DateTime.Parse(min);
        var maxDateTime = DateTime.Parse(max);

        // Act
        var result = valueDateTime.IsInRange(minDateTime, maxDateTime);

        // Assert
        result.ShouldBe(expectedResult);
    }

    [Theory]
    [InlineData(null, "2020-01-01", "2025-01-01", false)]
    [InlineData("2020-01-01", null, "2025-01-01", false)]
    [InlineData("2025-01-01", "2020-01-01", null, false)]
    [InlineData("2023-01-01", "2020-01-01", "2025-01-01", true)]
    public void Given_ValueAndIntervalNullable_When_IsInRange_Then_ShouldReturnExpectedResult(string? value, string? min, string? max, bool expectedResult)
    {
        // Arrange
        var valueDateTime = value == null ? (DateTime?)null : DateTime.Parse(value);
        var minDateTime = min == null ? (DateTime?)null : DateTime.Parse(min);
        var maxDateTime = max == null ? (DateTime?)null : DateTime.Parse(max);

        // Act
        var result = valueDateTime.IsInRange(minDateTime, maxDateTime);

        // Assert
        result.ShouldBe(expectedResult);
    }

    [Theory]
    [InlineData("2023-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2020-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2025-01-01", "2020-01-01", "2025-01-01", true)]
    [InlineData("2025-01-01", "2020-01-01", null, true)]
    [InlineData("2026-01-01", "2020-01-01", "2025-01-01", false)]
    public void Given_ValueAndInterval_When_IsInOpenRange_Then_ShouldReturnExpectedResult(string value, string min, string? max, bool expectedResult)
    {
        // Arrange
        var valueDateTime = DateTime.Parse(value);
        var minDateTime = DateTime.Parse(min);
        var maxDateTime = max == null ? (DateTime?)null : DateTime.Parse(max);

        // Act
        var result = valueDateTime.IsInOpenRange(minDateTime, maxDateTime);

        // Assert
        result.ShouldBe(expectedResult);
    }
}