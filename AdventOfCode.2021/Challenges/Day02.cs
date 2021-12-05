namespace AdventOfCode._2021.Challenges;

public record Instruction(string Direction, int Amount);

[Day(2021, 2)]
public class Day02 : Day<IEnumerable<Instruction>>
{
    public override IEnumerable<Instruction> ParseInput(string[] lines) =>
        lines
        .Select(x =>
        {
            var parts = x.Split(" ");

            return new Instruction(parts[0], int.Parse(parts[1]));
        })
        .ToList();

    public override object ExecutePart1()
    {
        var groups = Input
            .GroupBy(x => x.Direction)
            .ToDictionary(x => x.Key, x => x.Sum(y => y.Amount));

        return groups["forward"] * (groups["down"] - groups["up"]);
    }

    public override object ExecutePart2()
    {
        var aim = 0;
        var horizontal = 0;
        var depth = 0;

        foreach (var instruction in Input)
        {
            switch (instruction.Direction)
            {
                case "down":
                    aim += instruction.Amount;
                    break;
                case "up":
                    aim -= instruction.Amount;
                    break;
                case "forward":
                    horizontal += instruction.Amount;
                    depth += aim * instruction.Amount;
                    break;
            }
        }

        return horizontal * depth;
    }
}
