namespace AdventOfCode._2021.Tests;

public class Day09Tests
{
    private readonly IDay day;

    public Day09Tests()
    {
        day = new Day09();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(null!);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(null!);
    }
}