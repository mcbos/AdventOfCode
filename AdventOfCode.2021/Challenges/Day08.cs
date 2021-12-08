namespace AdventOfCode._2021.Challenges;

[Day(2021, 8)]
public class Day08 : Day<IList<(string[] Inputs, string[] Outputs)>>
{
    public override IList<(string[] Inputs, string[] Outputs)> ParseInput(string[] lines) =>
        lines.Select(x =>
        {
            var parts = x.Split(" | ");
            return (Inputs: parts[0].Split(' '), Outputs: parts[1].Split(' '));
        }).ToList();

    public override object ExecutePart1() =>
        Input.SelectMany(x => x.Outputs)
            .Count(x => x.Length == 2 || x.Length == 3 || x.Length == 4 || x.Length == 7);

    public override object ExecutePart2() =>
        Input.Select(x => new SevenSegmentedDisplay(x))
            .Sum(x => x.Number);
}

public class SevenSegmentedDisplay
{
    private readonly IDictionary<int, string> mapping;

    public int Number { get; set; }

    public SevenSegmentedDisplay((string[] Inputs, string[] Outputs) line)
    {
        mapping = line.Inputs
            .GroupBy(x => x.Length)
            .Where(x => x.Key == 2 || x.Key == 3 || x.Key == 4 || x.Key == 7)
            .ToDictionary(x => x.Key, x => x.First());

        var result = new StringBuilder();
        foreach (var segment in line.Outputs)
        {
            switch (segment.Length)
            {
                case 2:
                    result.Append(1);
                    break;
                case 3:
                    result.Append(7);
                    break;
                case 4:
                    result.Append(4);
                    break;
                case 5:
                    if (mapping[3].All(x => segment.Contains(x)))
                        result.Append(3);
                    else if (mapping[4].Count(x => segment.Contains(x)) == 3)
                        result.Append(5);
                    else
                        result.Append(2);
                    break;
                case 6:
                    if (mapping[4].All(x => segment.Contains(x)))
                        result.Append(9);
                    else if (mapping[3].All(x => segment.Contains(x)))
                        result.Append(0);
                    else
                        result.Append(6);
                    break;
                case 7:
                    result.Append(8);
                    break;
            }
        }

        Number = int.Parse(result.ToString());
    }
}