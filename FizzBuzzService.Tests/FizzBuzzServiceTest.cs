using Xunit;
using FizzBuzz.Service;

namespace FizzBuzz.Service.Tests;

public class FizzBuzzServiceTest
{
    [Theory]
    [InlineData(1)]
    [InlineData(2)]
    [InlineData(4)]
    public void ReturnsNumberForNotMultipleOf3Or5(int value)
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();
        // Act
        var result = fizzBuzzService.Of(value);
        // Assert
        Assert.Equal(value.ToString(), result);
    }

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    [InlineData(9)]
    public void ReturnsFizzForMultiplesOf3(int value)
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();
        // Act
        var result = fizzBuzzService.Of(value);
        // Assert
        Assert.Equal("Fizz", result);
    }

    [Theory]
    [InlineData(5)]
    public void ReturnsBuzzFor5(int value)
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();
        // Act
        var result = fizzBuzzService.Of(value);
        // Assert
        Assert.Equal("Buzz", result);
    }
}