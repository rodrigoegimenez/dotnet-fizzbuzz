using Xunit;
using FizzBuzz.Service;

namespace FizzBuzz.Service.Tests;

public class FizzBuzzServiceTest
{
    [Fact]
    public void Returns1For1()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();
        // Act
        var result = fizzBuzzService.Of(1);
        // Assert
        Assert.Equal("1", result);
    }

    [Fact]
    public void Returns2For2()
    {
        // Arrange
        var fizzBuzzService = new FizzBuzzService();
        // Act
        var result = fizzBuzzService.Of(2);
        // Assert
        Assert.Equal("2", result);
    }
}