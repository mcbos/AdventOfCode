namespace AdventOfCode._2021.Challenges;

[Day(2021, 6)]
public class Day06 : Day<IDictionary<int, long>>
{
    public override IDictionary<int, long> ParseInput(string[] lines)
    {
        var dict = lines.First().Split(',').Select(int.Parse)
            .GroupBy(x => x)
            .ToDictionary(x => x.Key, x => (long)x.Count());

        for (var i = 0; i < 9; i++)
            dict.TryAdd(i, 0);

        return dict;
    }

    public override object ExecutePart1()
    {
        ProcessFishes(80);

        return Input.Sum(x => x.Value);
    }

    public override object ExecutePart2()
    {
        ProcessFishes(256);

        return Input.Sum(x => x.Value);
    }

    private void ProcessFishes(int days)
    {
        for (int day = 0; day < days; day++)
        {
            var input0 = Input[0];

            for (int i = 0; i < 8; i++)
                Input[i] = Input[i + 1];

            Input[6] += input0;
            Input[8] = input0;
        }
    }
}
