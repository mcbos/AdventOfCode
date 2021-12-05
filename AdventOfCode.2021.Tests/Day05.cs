namespace AdventOfCode._2021.Tests;

public class Day05Tests
{
    private readonly IDay day;

    public Day05Tests()
    {
        day = new Day05();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(5);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(12);
    }
}