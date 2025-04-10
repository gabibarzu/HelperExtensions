using Shouldly;
using Xunit;

namespace HelperExtensions.Tests;

public class DictionaryExtensionsTests
{
    [Theory]
    [InlineData("key-1", "value-1")]
    [InlineData("key-2", "value-2")]
    [InlineData("key-3", null)]
    public void Given_StringDictionary_When_GetValueOrDefault_When_ShouldReturnsExpectedValue(string key, string? expectedResult)
    {
        // Arrange
        var dictionary = new Dictionary<string, string>
        {
            { "key-1", "value-1" },
            { "key-2", "value-2" },
        };

        // Act
        var result = dictionary.GetValueOrDefault(key);

        // Assert
        result.ShouldBe(expectedResult);
    }

    [Theory]
    [InlineData("key-1", 1)]
    [InlineData("key-2", 2)]
    [InlineData("key-3", 0)]
    public void Given_IntDictionary_When_GetValueOrDefault_When_ShouldReturnsExpectedValue(string key, int expectedResult)
    {
        // Arrange
        var dictionary = new Dictionary<string, int>
        {
            { "key-1", 1 },
            { "key-2", 2 },
        };

        // Act
        var result = dictionary.GetValueOrDefault(key);

        // Assert
        result.ShouldBe(expectedResult);
    }
}