namespace AdventOfCode._2021.Tests;

public class Day02Tests
{
    private readonly IDay day;

    public Day02Tests()
    {
        day = new Day02();
    }

    [Fact]
    public async Task Part1()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(1);

        // Assert
        result.Should().Be(150);
    }

    [Fact]
    public async Task Part2()
    {
        // Arrange

        // Act
        var result = await day.ExecuteAsync(2);

        // Assert
        result.Should().Be(900);
    }
}