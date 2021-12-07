namespace AdventOfCode._2021.Challenges;

[Day(2021, 7)]
public class Day07 : Day<IList<int>>
{
    public override IList<int> ParseInput(string[] lines) => (IList<int>)lines.First().AsCsv<int>();

    public override object ExecutePart1() =>
        Enumerable.Range(0, Input.Count).Min(i => Input.Sum(x => Math.Abs(i - x)));

    public override object ExecutePart2() =>
        Enumerable.Range(0, Input.Count).Min(i => Input.Sum(x => (Math.Abs(i - x) * (Math.Abs(i - x) + 1)) / 2));
}
