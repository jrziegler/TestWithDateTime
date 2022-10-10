using DateTimeInTests.Services;

namespace DateTime.Tests.Unit;

public class GreeterServiceBadTest
{
    [Fact]
    public void GenerateGreetTextBad_ShouldReturnGoodMorning_WhenItsMorning()
    {
        // Arrange
        var sut = new GreeterServiceBad();

        // Act
        var message = sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good morning", message);
    }

    [Fact]
    public void GenerateGreetTextBad_ShouldReturnGoodAfternoon_WhenItsAfternoon()
    {
        // Arrange
        var sut = new GreeterServiceBad();

        // Act
        var message = sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good afternoon", message);
    }

    [Fact]
    public void GenerateGreetTextBad_ShouldReturnGoodEvening_WhenItsEvening()
    {
        // Arrange
        var sut = new GreeterServiceBad();

        // Act
        var message = sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good evening", message);
    }
}

