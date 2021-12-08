namespace AdventOfCode._2021.Tests;

public class Day07Tests
{
    private readonly IDay day;

    public Day07Tests()
    {
        day = new Day07();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(37);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(168);
    }
}