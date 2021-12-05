namespace AdventOfCode._2021.Tests;

public class Day04Tests
{
    private readonly IDay day;

    public Day04Tests()
    {
        day = new Day04();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(4512);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(1924);
    }
}