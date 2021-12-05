namespace AdventOfCode._2021.Tests;

public class Day06Tests
{
    private readonly IDay day;

    public Day06Tests()
    {
        day = new Day06();
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