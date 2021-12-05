namespace AdventOfCode._2021.Challenges;

[Day(2021, 1)]
public class Day01 : Day<IEnumerable<int>>
{
    public override IEnumerable<int> ParseInput(string raw)
    {
        return raw.Split('\n').Select(int.Parse).ToList();
    }

    public override object ExecutePart1() => Input
        .Zip(Input.Skip(1), (previous, item) => (previous, item))
        .Where(zip => zip.item > zip.previous)
        .Count();

    public override object ExecutePart2()
    {
        var slindingWindows = Input
            .SlidingWindow()
            .Where(x => x.Count == 3);

        return slindingWindows
            .Zip(slindingWindows.Skip(1), (previous, item) => (previous, item))
            .Where(zip => zip.item.Sum() > zip.previous.Sum())
            .Count();
    }
}
