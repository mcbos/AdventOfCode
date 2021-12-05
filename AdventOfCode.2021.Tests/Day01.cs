namespace AdventOfCode._2021.Tests;

public class Day01Tests
{
    private readonly IDay day;

    public Day01Tests()
    {
        day = new Day01();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(7);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(5);
    }
}