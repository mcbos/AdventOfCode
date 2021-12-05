namespace AdventOfCode._2021.Challenges;

[Day(2021, 3)]
public class Day03 : Day<IEnumerable<char[]>>
{
    private int recordLength;

    public override IEnumerable<char[]> ParseInput(string[] lines)
    {
        recordLength = lines.First().Length;

        return lines
            .Select(x => x.ToCharArray())
            .ToList();
    }

    public override object ExecutePart1()
    {
        var bits = Input
            .Transpose()
            .Select(row => row
                .GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .First());
        var binary = string.Join("", bits);
        var gamma = Convert.ToUInt16(binary, 2);

        var epsilon = ~gamma & ((int)Math.Pow(2, recordLength) - 1);

        return gamma * epsilon;
    }

    public override object ExecutePart2()
    {
        IEnumerable<char[]> data = Input.ToList();
        for (int i = 0; i < recordLength; i++)
        {
            data = Reduce(data, i, OrderByDirection.Descending);
        }
        var generating = Convert.ToInt32(string.Join("", data.Single()), 2);

        data = Input.ToList();
        for (int i = 0; i < recordLength; i++)
        {
            data = Reduce(data, i, OrderByDirection.Ascending);
        }
        var scrubbing = Convert.ToInt32(string.Join("", data.Single()), 2);

        return generating * scrubbing;
    }

    private static IEnumerable<char[]> Reduce(IEnumerable<char[]> records, int position, OrderByDirection order)
    {
        var bit = records
            .Select(x => x[position])
            .GroupBy(x => x)
            .OrderBy(x => x.Count(), order)
                .ThenBy(x => x.Key, order)
            .Select(x => x.Key)
            .First();

        return records.Where(x => x[position] == bit);
    }
}
