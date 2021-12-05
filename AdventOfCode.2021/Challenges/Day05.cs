namespace AdventOfCode._2021.Challenges;

[Day(2021, 5)]
public class Day05 : Day<List<(Vector2, Vector2)>>
{
    public override List<(Vector2, Vector2)> ParseInput(string[] lines) => 
        lines.Select(row =>
        {
            var matches = Regex.Matches(row, @"(\d+)");

            var point1 = new Vector2(int.Parse(matches[0].Value), int.Parse(matches[1].Value));
            var point2 = new Vector2(int.Parse(matches[2].Value), int.Parse(matches[3].Value));

            return (point1, point2);
        }).ToList();

    public override object ExecutePart1() => FindHotspots();

    public override object ExecutePart2() => FindHotspots(true);

    private int FindHotspots(bool diagonals = false)
    {
        var map = new Dictionary<Vector2, int>();

        foreach (var (p1, p2) in Input)
        {
            if (diagonals || p1.X == p2.X || p1.Y == p2.Y)
            {
                var direction = new Vector2(Math.Sign(p2.X - p1.X), Math.Sign(p2.Y - p1.Y));
                var current = p1;

                while (current != p2 + direction)
                {
                    if (!map.ContainsKey(current))
                        map.Add(current, 0);

                    map[current]++;
                    current += direction;
                }
            }
        }

        return map.Values.Count(x => x > 1);
    }
}
