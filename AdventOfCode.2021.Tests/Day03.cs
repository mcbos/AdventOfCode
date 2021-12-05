namespace AdventOfCode._2021.Tests;

public class Day03Tests
{
    private readonly IDay day;

    public Day03Tests()
    {
        day = new Day03();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(198);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(230);
    }
}