using DateTimeInTests.Interfaces;
using DateTimeInTests.Services;
using NSubstitute;

namespace DateTime.Tests.Unit;

public class GreeterServiceGoodTest
{
    private readonly GreeterServiceGood _sut;
    private readonly IDateTimeProvider _dateTimeProvider = Substitute.For<IDateTimeProvider>();

    public GreeterServiceGoodTest()
    {
        _sut = new GreeterServiceGood(_dateTimeProvider);
    }

    [Fact]
    public void GenerateGreetText_ShouldReturnGoodMorning_WhenItsMorning()
    {
        // Arrange
        _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 10, 10, 8, 0, 0, TimeSpan.Zero));

        // Act
        var message = _sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good morning", message);
    }

    [Fact]
    public void GenerateGreetText_ShouldReturnGoodAfternoon_WhenItsAfternoon()
    {
        // Arrange
        _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 10, 10, 13, 0, 0, TimeSpan.Zero));

        // Act
        var message = _sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good afternoon", message);
    }

    [Fact]
    public void GenerateGreetText_ShouldReturnGoodEvening_WhenItsEvening()
    {
        // Arrange
        _dateTimeProvider.Now.Returns(new DateTimeOffset(2022, 10, 10, 20, 0, 0, TimeSpan.Zero));

        // Act
        var message = _sut.GenerateGreetText();

        // Assert
        Assert.Equal("Good evening", message);
    }
}
