namespace AdventOfCode._2021.Challenges;

[Day(2021, 4)]
public class Day04 : Day<List<Board>>
{
    private const int BoardSize = 5;

    private IEnumerable<int> numbers = Enumerable.Empty<int>();

    public override List<Board> ParseInput(string[] lines)
    {
        numbers = lines.First().AsCsv<int>();

        return lines
            .Skip(2)
            .Where(x => !string.IsNullOrWhiteSpace(x))
            .Chunk(BoardSize)
            .Select(x => new Board(BoardSize, x))
            .ToList();
    }

    public override object ExecutePart1()
    {
        foreach (var number in numbers)
        {
            foreach (var board in Input)
            {
                board.Mark(number);

                if (board.HasWon())
                {
                    return board.CalculateScore(number);
                }
            }
        }

        return null!;
    }

    public override object ExecutePart2()
    {
        foreach (var number in numbers)
        {
            foreach (var board in Input)
            {
                board.Mark(number);

                if (board.HasWon() && !Input.Any(x => !x.Won))
                {
                    return board.CalculateScore(number);
                }
            }
        }

        return null!;
    }
}

public class Board
{
    public bool Won = false;
    public IList<List<int>> Grid;

    private readonly int boardSize;

    public Board(int boardSize, IEnumerable<string> data)
    {
        // Add one to be able to mark zero's
        Grid = data.Select(x => x.AsCsv<int>(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => x + 1).ToList()).ToList();
        this.boardSize = boardSize;
    }

    public void Mark(int i)
    {
        i++;
        for (var y = 0; y < boardSize; y++)
        {
            for (var x = 0; x < boardSize; x++)
            {
                if (Grid[y][x] == i)
                {
                    Grid[y][x] = -i;
                    return;
                }
            }
        }
    }

    public int CalculateScore(int lastNumber)
    {
        var results = Grid.SelectMany(x => x).Where(x => x > 0).ToList();
        return (results.Sum() - results.Count) * lastNumber;
    }

    public bool HasWon()
    {
        for (var y = 0; y < boardSize; y++)
        {
            if (Grid[y].All(x => x < 0))
            {
                return Won = true;
            }
        }

        for (var y = 0; y < boardSize; y++)
        {
            if (Grid.Select(x => x[y]).All(x => x < 0))
            {
                return Won = true;
            }
        }

        return false;
    }
}
